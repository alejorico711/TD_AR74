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
    public partial class FrmReporteInteligente : Form, Idioma.IObservadorIdioma_64PR
    {
        private BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;
        private int _filaActualReporte = 0;

        public FrmReporteInteligente()
        {
            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this);

            InitializeComponent();
            ConfigurarControles();

            var textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            lblTotalPeriodoValor.Visible = false;
            lblTotalReservasValor.Visible = false;
            lblTotalReservas.Visible = false;
            lblTotalPeriodo.Visible = false;

            this.Resize += FrmReporteInteligente_Resize;
            CentrarPanel();
        }

        private void FrmReporteInteligente_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
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

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }

        private void ConfigurarControles()
        {
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.RowHeadersVisible = false;
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.ReadOnly = true;
            dgvReservas.MultiSelect = false;
            dgvReservas.BackgroundColor = Color.White;
            dgvReservas.BorderStyle = BorderStyle.None;

            // Fechas por defecto: primer día del mes actual hasta la fecha actual
            dtpFechaInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaFin.MaxDate = DateTime.Today;
            dtpFechaInicio.MaxDate = DateTime.Now - TimeSpan.FromDays(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
                {
                    string msg = (textos != null && textos.ContainsKey("error_reporte")) ? textos["error_reporte"] : "La fecha de inicio no puede ser mayor a la fecha de fin.";
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = bllReservas.ObtenerReporteIngresos(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date);
                dgvReservas.DataSource = dt;

                if (dgvReservas.Columns.Contains("NroReserva"))
                    dgvReservas.Columns["NroReserva"].HeaderText = "Nro. Reserva";

                if (dgvReservas.Columns.Contains("FechaCheckIn"))
                {
                    dgvReservas.Columns["FechaCheckIn"].HeaderText = "Check-In";
                    dgvReservas.Columns["FechaCheckIn"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvReservas.Columns.Contains("FechaCheckOut"))
                {
                    dgvReservas.Columns["FechaCheckOut"].HeaderText = "Check-Out";
                    dgvReservas.Columns["FechaCheckOut"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvReservas.Columns.Contains("NumeroHabitacion"))
                    dgvReservas.Columns["NumeroHabitacion"].HeaderText = "Nro. Habitación";

                if (dgvReservas.Columns.Contains("Huesped"))
                    dgvReservas.Columns["Huesped"].HeaderText = "Huésped";

                if (dgvReservas.Columns.Contains("Total"))
                {
                    dgvReservas.Columns["Total"].HeaderText = "Total ($)";
                    dgvReservas.Columns["Total"].DefaultCellStyle.Format = "N2";
                }

                int totalReservas = dt.Rows.Count;
                decimal totalIngresos = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Total"] != DBNull.Value)
                    {
                        totalIngresos += Convert.ToDecimal(row["Total"]);
                    }
                }

                lblTotalPeriodoValor.Visible = true;
                lblTotalReservasValor.Visible = true;
                lblTotalReservas.Visible = true;
                lblTotalPeriodo.Visible = true;
                lblTotalReservasValor.Text = totalReservas.ToString();
                lblTotalPeriodoValor.Text = $"${totalIngresos:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar en el período seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GuardarReportePdf();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarReportePdf()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento PDF (*.pdf)|*.pdf";
            sfd.FileName = $"Reporte_Ingresos_{dtpFechaInicio.Value:yyyyMMdd}_{dtpFechaFin.Value:yyyyMMdd}.pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = sfd.FileName;

            _filaActualReporte = 0;
            doc.BeginPrint += (s, ev) => { _filaActualReporte = 0; };
            doc.PrintPage += (s, ev) => DibujarReportePdf(ev);
            doc.Print();

            MessageBox.Show("Reporte generado exitosamente en PDF.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DibujarReportePdf(PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font fontTitulo = new Font("Arial", 16, FontStyle.Bold))
            using (Font fontSub = new Font("Arial", 11, FontStyle.Bold))
            using (Font fontData = new Font("Arial", 9, FontStyle.Regular))
            using (Font fontHeader = new Font("Arial", 9, FontStyle.Bold))
            using (Font fontTotals = new Font("Arial", 10, FontStyle.Bold))
            {
                Brush brush = Brushes.Black;
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float right = e.MarginBounds.Right;
                float rowH = fontData.GetHeight(g) + 6;

                // Cabecera principal (sólo en la primera página)
                if (_filaActualReporte == 0)
                {
                    g.DrawString("RoomIn Hotel", fontTitulo, brush, x, y);
                    y += rowH * 1.5f;

                    g.DrawString("REPORTE DE INGRESOS POR PERÍODO", fontSub, brush, x, y);
                    y += rowH * 1.2f;

                    g.DrawString($"Fecha de emisión: {DateTime.Now:dd/MM/yyyy HH:mm}", fontData, brush, x, y);
                    y += rowH;

                    g.DrawString($"Período: {dtpFechaInicio.Value:dd/MM/yyyy} al {dtpFechaFin.Value:dd/MM/yyyy}", fontData, brush, x, y);
                    y += rowH * 1.3f;

                    g.DrawString($"Total de reservas: {lblTotalReservasValor.Text}    |    Total de ingresos: {lblTotalPeriodoValor.Text}", fontTotals, brush, x, y);
                    y += rowH * 1.5f;

                    g.DrawLine(Pens.Black, x, y, right, y);
                    y += 10;
                }

                // Cabecera de la tabla
                float colNroX = x;
                float colInX = colNroX + 70;
                float colOutX = colInX + 85;
                float colHabX = colOutX + 85;
                float colHuespedX = colHabX + 55;
                float colTotalRight = right - 5;

                g.DrawString("Nro. Res.", fontHeader, brush, colNroX, y);
                g.DrawString("Check-In", fontHeader, brush, colInX, y);
                g.DrawString("Check-Out", fontHeader, brush, colOutX, y);
                g.DrawString("Hab.", fontHeader, brush, colHabX, y);
                g.DrawString("Huésped", fontHeader, brush, colHuespedX, y);

                string txtHeaderTotal = "Total ($)";
                float wHeaderTotal = g.MeasureString(txtHeaderTotal, fontHeader).Width;
                g.DrawString(txtHeaderTotal, fontHeader, brush, colTotalRight - wHeaderTotal, y);

                y += rowH;
                g.DrawLine(Pens.Gray, x, y, right, y);
                y += 4;

                // Dibujar filas
                while (_filaActualReporte < dgvReservas.Rows.Count)
                {
                    if (y + rowH > e.MarginBounds.Bottom - 30)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    DataGridViewRow row = dgvReservas.Rows[_filaActualReporte];

                    string nro = row.Cells["NroReserva"].Value?.ToString() ?? "";

                    string checkIn = "";
                    if (row.Cells["FechaCheckIn"].Value is DateTime dtIn)
                        checkIn = dtIn.ToString("dd/MM/yyyy");
                    else if (row.Cells["FechaCheckIn"].Value != null && DateTime.TryParse(row.Cells["FechaCheckIn"].Value.ToString(), out DateTime dtInP))
                        checkIn = dtInP.ToString("dd/MM/yyyy");
                    else
                        checkIn = row.Cells["FechaCheckIn"].Value?.ToString() ?? "";

                    string checkOut = "";
                    if (row.Cells["FechaCheckOut"].Value is DateTime dtOut)
                        checkOut = dtOut.ToString("dd/MM/yyyy");
                    else if (row.Cells["FechaCheckOut"].Value != null && DateTime.TryParse(row.Cells["FechaCheckOut"].Value.ToString(), out DateTime dtOutP))
                        checkOut = dtOutP.ToString("dd/MM/yyyy");
                    else
                        checkOut = row.Cells["FechaCheckOut"].Value?.ToString() ?? "";

                    string hab = row.Cells["NumeroHabitacion"].Value?.ToString() ?? "";
                    string huesped = row.Cells["Huesped"].Value?.ToString() ?? "";
                    if (huesped.Length > 28)
                        huesped = huesped.Substring(0, 25) + "...";

                    decimal total = 0;
                    if (row.Cells["Total"].Value != null && row.Cells["Total"].Value != DBNull.Value)
                        decimal.TryParse(row.Cells["Total"].Value.ToString(), out total);
                    string totalStr = $"${total:N2}";

                    g.DrawString(nro, fontData, brush, colNroX, y);
                    g.DrawString(checkIn, fontData, brush, colInX, y);
                    g.DrawString(checkOut, fontData, brush, colOutX, y);
                    g.DrawString(hab, fontData, brush, colHabX, y);
                    g.DrawString(huesped, fontData, brush, colHuespedX, y);

                    float wTotal = g.MeasureString(totalStr, fontData).Width;
                    g.DrawString(totalStr, fontData, brush, colTotalRight - wTotal, y);

                    y += rowH;
                    _filaActualReporte++;
                }

                // Línea final de cierre y resumen
                y += 4;
                g.DrawLine(Pens.Black, x, y, right, y);
                y += 8;
                string pie = $"Fin del reporte - {lblTotalReservasValor.Text} reserva(s) | Total ingresos: {lblTotalPeriodoValor.Text}";
                g.DrawString(pie, fontTotals, brush, x, y);

                e.HasMorePages = false;
            }
        }
    }
}
