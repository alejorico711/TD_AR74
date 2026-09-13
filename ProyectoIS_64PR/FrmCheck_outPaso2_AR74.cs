using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmCheck_outPaso2_AR74 : Form
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        BLL_64PR.BLL_Pagos_AR74 bllPagos = new BLL_64PR.BLL_Pagos_AR74();
        public FrmCheck_outPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            CargarResumen();
        }
        private void CargarResumen()
        {
            lblHuespedNombre.Text = $"Huésped: {reserva.Huesped.Nombre} {reserva.Huesped.Apellido} (DNI: {reserva.Huesped.DNI})";

            lblHabitacion2.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if (reserva.Habitacion.Descripcion != null)
            {
                lblHabitacion2.Text += ", " + reserva.Habitacion.Descripcion;
            }
            lblFechas2.Text = $"{reserva.FechaInicio:dd/MM/yyyy} --> {reserva.FechaFin:dd/MM/yyyy}";
            lblPersonas2.Text = reserva.CantidadPersonas.ToString();

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;

            lblNochesxPrecio2.Text = $"{noches} noches x ${precioPorNoche:N0}";
            lblTotal2.Text = $"${total:N0}";
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false; // primera línea, evita doble click por si la consulta a la BD tarda

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;

            bllPagos.RegistrarPago(reserva.IdReserva, total, cmbMetodoDePago.SelectedItem.ToString());
            bllReservas.ConfirmarCheckOut(reserva.IdReserva);

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

            MessageBox.Show("Comprobante guardado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Pago
            g.DrawString("Pago", fontHeader, brush, x, y);
            y += rowH;
            g.DrawString($"Método: {metodoPago}", fontData, brush, x, y);
            y += rowH;
            g.DrawString($"Total abonado: ${montoTotal:N2}", new Font("Arial", 12, FontStyle.Bold), brush, x, y);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPadre.AbrirFormularioHijo(new FrmCheck_out_AR74(frmPadre));
        }
    }
}
