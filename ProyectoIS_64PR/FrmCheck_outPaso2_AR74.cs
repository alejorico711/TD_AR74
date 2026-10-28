using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmCheck_outPaso2_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        BLL_64PR.BLL_Pagos_AR74 bllPagos = new BLL_64PR.BLL_Pagos_AR74();
        BLL_64PR.BLL_SolicitudesServicio_AR74 bllSolicitudes = new BLL_64PR.BLL_SolicitudesServicio_AR74();
        List<SolicitudServicio> serviciosCuenta = new List<SolicitudServicio>();
        decimal subtotalServicios;
        Dictionary<string, string> textos;
        public FrmCheck_outPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;

            string rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "doorway.png");
            pbHabitacion.BackgroundImageLayout = ImageLayout.Zoom;
            pbHabitacion.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "calendar.png");
            pbCalendario.BackgroundImageLayout = ImageLayout.Zoom;
            pbCalendario.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "people.png");
            pbPersonas.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonas.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "crescent-moon.png");
            pbNoches.BackgroundImageLayout = ImageLayout.Zoom;
            pbNoches.BackgroundImage = Image.FromFile(rutaLogo);

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            lstServiciosCuenta.Visible = false;
            lblSubtotalServicios.Visible = false;
            CargarServiciosCuenta();
            CargarResumen();

            this.Resize += FrmCheck_outPaso2_AR74_Resize;
            CentrarPanel();
            cmbMetodoDePago.SelectedIndex = 0;
        }

        private void CentrarPanel()
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void FrmCheck_outPaso2_AR74_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }
        private void CargarResumen()
        {
            lblHuespedNombre.Text = $"Huésped: {reserva.Huesped.Nombre} {reserva.Huesped.Apellido} (DNI: {reserva.Huesped.DNI})";

            lblValorHabitacion.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if (reserva.Habitacion.Descripcion != null)
            {
                lblValorHabitacion.Text += ", " + reserva.Habitacion.Descripcion;
            }
            lblValorFechas.Text = $"{reserva.FechaInicio:dd/MM/yyyy} --> {reserva.FechaFin:dd/MM/yyyy}";
            lblValorPersonas.Text = reserva.CantidadPersonas.ToString();

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;
            decimal montoCobrado = total + subtotalServicios;

            lblValorNochesxPrecio.Text = $"{noches} noches x ${precioPorNoche:N0}";
            lblValorTotal.Text = $"${montoCobrado:N0}";
        }
        private void CargarServiciosCuenta()
        {
            serviciosCuenta = bllSolicitudes.ListarServiciosPendientesDePago(reserva.IdReserva);
            if(serviciosCuenta.Count > 0)
            {
                lstServiciosCuenta.Visible = true;
                lblSubtotalServicios.Visible = true;

                subtotalServicios = serviciosCuenta.Sum(s => s.Precio);
                lstServiciosCuenta.DataSource = serviciosCuenta;

                lblSubtotalServicios.Text = $"${subtotalServicios:N0}";
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                btnConfirmar.Enabled = false; // primera línea, evita doble click por si la consulta a la BD tarda

                if (cmbMetodoDePago.SelectedItem == null)
                {
                    MessageBox.Show(textos["msgSeleccionarMetodo"]);
                    btnConfirmar.Enabled = true;
                    return;
                }

                int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
                decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
                decimal total = noches * precioPorNoche;
                decimal montoCobrado = total + subtotalServicios;
                string metodoPago = cmbMetodoDePago.SelectedItem.ToString();

                bllPagos.RegistrarPago(reserva.IdReserva, total, cmbMetodoDePago.SelectedItem.ToString());
                bllReservas.ConfirmarCheckOut(reserva.IdReserva, cmbMetodoDePago.SelectedItem.ToString());

                FrmOpcionesComprobante dialogo = new FrmOpcionesComprobante();
                dialogo.StartPosition = FormStartPosition.CenterParent;
                dialogo.ShowDialog(frmPadre);

                switch (dialogo.Opcion)
                {
                    case FrmOpcionesComprobante.OpcionElegida.Imprimir:
                        ImprimirComprobante(reserva, total, cmbMetodoDePago.SelectedItem.ToString());
                        break;
                    case FrmOpcionesComprobante.OpcionElegida.DescargarPdf:
                        GuardarComprobantePdf(reserva, total, cmbMetodoDePago.SelectedItem.ToString());
                        break;
                }

                frmPadre.AbrirFormularioHijo(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnConfirmar.Enabled = true;
            }
        }

        private void ImprimirComprobante(Reserva_AR74 reserva, decimal montoTotal, string metodoPago)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) => DibujarComprobante(ev, reserva, montoTotal, metodoPago);

            PrintDialog pd = new PrintDialog();
            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void GuardarComprobantePdf(Reserva_AR74 reserva, decimal montoTotal, string metodoPago)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento PDF (*.pdf)|*.pdf";
            sfd.FileName = $"Comprobante_Reserva_{reserva.IdReserva}.pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = sfd.FileName;
            doc.PrintPage += (s, ev) => DibujarComprobante(ev, reserva, montoTotal, metodoPago);
            doc.Print();
        }

        private void DibujarComprobante(PrintPageEventArgs e, Reserva_AR74 reserva, decimal montoTotal, string metodoPago)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fontSub = new Font("Arial", 11, FontStyle.Bold);
            Font fontData = new Font("Arial", 10, FontStyle.Regular);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float rowH = fontData.GetHeight(g) + 6;

            // Encabezado
            g.DrawString("RoomIn Hotel", fontTitulo, brush, x, y);
            y += rowH * 1.5f;
            g.DrawString("COMPROBANTE DE CHECK-OUT", fontSub, brush, x, y);
            y += rowH * 1.2f;
            g.DrawString($"Fecha de emisión: {DateTime.Now:dd/MM/yyyy HH:mm}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Nro. Reserva: {reserva.IdReserva}", fontData, brush, x, y);
            y += rowH * 1.5f;

            // Línea separadora
            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 8;

            // Datos del huésped
            g.DrawString($"Huésped: {reserva.Huesped.Nombre} {reserva.Huesped.Apellido}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"DNI: {reserva.Huesped.DNI}", fontData, brush, x, y);
            y += rowH * 1.5f;

            // Línea separadora
            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 8;

            // Detalle estadía
            g.DrawString("Detalle de la estadía", fontSub, brush, x, y);
            y += rowH * 1.2f;

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;

            g.DrawString($"Habitación: Nro {reserva.Habitacion.Numero} ({reserva.Habitacion.Tipo.Descripcion})", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Check-In:  {reserva.FechaInicio:dd/MM/yyyy}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Check-Out: {reserva.FechaFin:dd/MM/yyyy}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Huéspedes: {reserva.CantidadPersonas}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Noches: {noches} x ${precioPorNoche:N2}", fontData, brush, x, y);
            y += rowH * 1.5f;

            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 12;

            if (serviciosCuenta.Count > 0)
            {
                g.DrawString("Servicios adicionales", fontHeader, brush, x, y);
                y += rowH;
                foreach (var s in serviciosCuenta)
                {
                    g.DrawString(s.Servicio.Descripcion, fontData, brush, x, y);
                    string precio = $"${s.Precio:N2}";
                    float anchoPrecio = g.MeasureString(precio, fontData).Width;
                    g.DrawString(precio, fontData, brush, e.MarginBounds.Right - anchoPrecio, y);
                    y += rowH;
                }
                g.DrawString($"Subtotal servicios: ${subtotalServicios:N2}", fontHeader, brush, x, y);
                y += rowH + 10;
            }

            // Pago
            g.DrawString($"Método: {metodoPago}", fontData, brush, x, y);
            y += rowH;
            if (serviciosCuenta.Count > 0)
            {
                g.DrawString($"Estadía: ${montoTotal:N2}", fontData, brush, x, y);
                y += rowH;
            }
            g.DrawString($"Total abonado: ${montoTotal + subtotalServicios:N2}", new Font("Arial", 12, FontStyle.Bold), brush, x, y);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPadre.AbrirFormularioHijo(new FrmCheck_out_AR74(frmPadre));
        }
    }
}
