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
        }

        private void GuardarComprobantePdf(Reserva_AR74 reserva, decimal total, string metodoPago)
        {

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
            saveDialog.FileName = $"Comprobante_{reserva.IdReserva:D6}.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = saveDialog.FileName;

            printDoc.PrintPage += (s, ev) => PrintDoc_PrintComprobante(s, ev, reserva, total, metodoPago);

            printDoc.Print();

            MessageBox.Show(textos["msgComprobanteGuardado"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImprimirComprobante(Reserva_AR74 reserva, decimal montoTotal, string metodoPago)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false; // Portrait, es un comprobante angosto

            printDoc.PrintPage += (sender, e) => PrintDoc_PrintComprobante(sender, e, reserva, montoTotal, metodoPago);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }

        private void PrintDoc_PrintComprobante(object sender, PrintPageEventArgs e, Reserva_AR74 reserva, decimal montoTotal, string metodoPago)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontData = new Font("Arial", 10, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float rowH = fontData.GetHeight(g) + 8;

            // Encabezado del comprobante
            g.DrawString("Sistema Hotelero - Comprobante de Pago", fontTitulo, brush, x, y);
            y += rowH + 10;
            g.DrawString($"Comprobante N°: {reserva.IdReserva:D6}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Fecha de emisión: {DateTime.Now:dd/MM/yyyy HH:mm}", fontData, brush, x, y);
            y += rowH + 6;

            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 12;

            // Datos del huésped
            g.DrawString("Huésped", fontHeader, brush, x, y);
            y += rowH;
            g.DrawString($"{reserva.Huesped.Nombre} {reserva.Huesped.Apellido} - DNI: {reserva.Huesped.DNI}", fontData, brush, x, y);
            y += rowH + 10;

            // Datos de la estadía
            g.DrawString("Detalle de la estadía", fontHeader, brush, x, y);
            y += rowH;
            g.DrawString($"Habitación N° {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Check-in: {reserva.FechaInicio:dd/MM/yyyy}   Check-out: {reserva.FechaFin:dd/MM/yyyy}", fontData, brush, x, y);
            y += rowH;

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            g.DrawString($"Cantidad de noches: {noches}   Personas: {reserva.CantidadPersonas}", fontData, brush, x, y);
            y += rowH + 10;

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
