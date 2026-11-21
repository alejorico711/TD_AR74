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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoIS_64PR
{
    public partial class FrmReporteInteligente : Form, Idioma.IObservadorIdioma_64PR
    {
        private BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;
        private int _filaActualReporte = 0;
        private bool _seccionPredictivaPendiente = false;
        private ProyeccionPredictiva _proyeccionActual = null;

        public class DatoHistoricoMes
        {
            public int Anio { get; set; }
            public int Mes { get; set; }
            public string Etiqueta { get; set; }
            public decimal Ingresos { get; set; }
            public int Reservas { get; set; }
        }

        public class ProyeccionPredictiva
        {
            public string MesProyectado { get; set; }
            public decimal IngresoEstimado { get; set; }
            public int ReservasEstimadas { get; set; }
            public decimal PorcentajeVariacion { get; set; }
            public string Tendencia { get; set; }
            public List<DatoHistoricoMes> Historico { get; set; }
        }

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

            lblTituloPrediccion.Visible = false;
            lblProyeccionIngresos.Visible = false;
            lblProyeccionIngresosValor.Visible = false;
            lblProyeccionReservas.Visible = false;
            lblProyeccionReservasValor.Visible = false;
            lblTendencia.Visible = false;
            lblTendenciaValor.Visible = false;
            chartTendencia.Visible = false;

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
                    Math.Max(10, (this.ClientSize.Width - panel1.Width) / 2),
                    Math.Max(10, (this.ClientSize.Height - panel1.Height) / 2)
                );
            }
        }

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            string aux1 = lblProyeccionIngresosValor.Text;
            string aux2 = lblProyeccionReservasValor.Text;
            string aux3 = lblTendenciaValor.Text;
            string aux4 = lblTotalPeriodoValor.Text;
            string aux5 = lblTotalReservasValor.Text;
            Traductor_64PR.Traducir(this, textos);
            lblProyeccionIngresosValor.Text = aux1;
            lblProyeccionReservasValor.Text = aux2;
            lblTendenciaValor.Text = aux3;
            lblTotalPeriodoValor.Text = aux4;
            lblTotalReservasValor.Text = aux5;
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

            // Fechas sugeridas: 2 meses anteriores hasta hoy para disponer de base histórica suficiente para predecir
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-2);
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
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                ActualizarIdioma(textos);

                lblTotalReservasValor.Text = totalReservas.ToString();
                lblTotalPeriodoValor.Text = $"${totalIngresos:N2}";

                // Procesar cálculo predictivo y gráfico
                GenerarAnalisisPredictivo(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GenerarAnalisisPredictivo(DataTable dt)
        {
            var mesesDict = new Dictionary<string, DatoHistoricoMes>();

            DateTime inicio = new DateTime(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, 1);
            DateTime fin = new DateTime(dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, 1);

            DateTime iter = inicio;
            while (iter <= fin)
            {
                string clave = $"{iter.Year}-{iter.Month:D2}";
                mesesDict[clave] = new DatoHistoricoMes
                {
                    Anio = iter.Year,
                    Mes = iter.Month,
                    Etiqueta = iter.ToString("MMM yyyy"),
                    Ingresos = 0,
                    Reservas = 0
                };
                iter = iter.AddMonths(1);
            }

            foreach (DataRow row in dt.Rows)
            {
                if (row["FechaCheckOut"] != DBNull.Value)
                {
                    DateTime fOut = Convert.ToDateTime(row["FechaCheckOut"]);
                    string clave = $"{fOut.Year}-{fOut.Month:D2}";
                    if (mesesDict.ContainsKey(clave))
                    {
                        mesesDict[clave].Reservas++;
                        if (row["Total"] != DBNull.Value)
                        {
                            mesesDict[clave].Ingresos += Convert.ToDecimal(row["Total"]);
                        }
                    }
                }
            }

            List<DatoHistoricoMes> historico = mesesDict.Values.OrderBy(m => m.Anio).ThenBy(m => m.Mes).ToList();

            if (historico.Count < 2)
            {
                lblTituloPrediccion.Visible = true;
                lblProyeccionIngresos.Visible = true;
                lblProyeccionIngresosValor.Visible = true;
                lblProyeccionIngresosValor.Text = "N/D (Período menor a 2 meses)";
                lblProyeccionReservas.Visible = false;
                lblProyeccionReservasValor.Visible = false;
                lblTendencia.Visible = false;
                lblTendenciaValor.Visible = false;
                chartTendencia.Visible = false;
                _proyeccionActual = null;
                return;
            }

            int n = historico.Count;

            // Regresión lineal simple por Mínimos Cuadrados para Ingresos
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            double sumR = 0, sumXR = 0;

            for (int i = 0; i < n; i++)
            {
                double x = i + 1;
                double y = (double)historico[i].Ingresos;
                double r = (double)historico[i].Reservas;

                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;

                sumR += r;
                sumXR += x * r;
            }

            double divisor = (n * sumX2 - sumX * sumX);
            double mIngresos = divisor != 0 ? (n * sumXY - sumX * sumY) / divisor : 0;
            double bIngresos = (sumY - mIngresos * sumX) / n;

            double mReservas = divisor != 0 ? (n * sumXR - sumX * sumR) / divisor : 0;
            double bReservas = (sumR - mReservas * sumX) / n;

            // Proyección para x = n + 1 (mes siguiente)
            double xPred = n + 1;
            double yPred = mIngresos * xPred + bIngresos;
            if (yPred < 0) yPred = 0;

            double rPred = mReservas * xPred + bReservas;
            if (rPred < 0) rPred = 0;

            DateTime ultimoMes = new DateTime(historico.Last().Anio, historico.Last().Mes, 1);
            DateTime proxMes = ultimoMes.AddMonths(1);
            string mesProyStr = proxMes.ToString("MMM yyyy");

            double ultimoIngreso = (double)historico.Last().Ingresos;
            decimal varPorc = 0;
            if (ultimoIngreso > 0)
            {
                varPorc = Convert.ToDecimal(((yPred - ultimoIngreso) / ultimoIngreso) * 100.0);
            }

            string tendStr;
            Color colorTend;
            if (varPorc > 2m)
            {
                tendStr = $"Creciente (+{varPorc:N1}%)";
                colorTend = Color.FromArgb(59, 110, 78);
            }
            else if (varPorc < -2m)
            {
                tendStr = $"Decreciente ({varPorc:N1}%)";
                colorTend = Color.FromArgb(180, 50, 50);
            }
            else
            {
                tendStr = $"Estable ({varPorc:N1}%)";
                colorTend = Color.FromArgb(108, 117, 125);
            }

            _proyeccionActual = new ProyeccionPredictiva
            {
                MesProyectado = mesProyStr,
                IngresoEstimado = Convert.ToDecimal(yPred),
                ReservasEstimadas = (int)Math.Round(rPred),
                PorcentajeVariacion = varPorc,
                Tendencia = tendStr,
                Historico = historico
            };

            lblTituloPrediccion.Visible = true;
            lblProyeccionIngresos.Visible = true;
            lblProyeccionIngresosValor.Visible = true;
            lblProyeccionReservas.Visible = true;
            lblProyeccionReservasValor.Visible = true;
            lblTendencia.Visible = true;
            lblTendenciaValor.Visible = true;

            

            lblProyeccionIngresosValor.Text = $"${_proyeccionActual.IngresoEstimado:N2}";
            lblProyeccionReservasValor.Text = $"{_proyeccionActual.ReservasEstimadas} reservas";
            lblTendenciaValor.Text = tendStr;
            lblTendenciaValor.ForeColor = colorTend;

            // Renderizar gráfico de barras
            RenderizarGrafico(historico, _proyeccionActual);
        }

        private void RenderizarGrafico(List<DatoHistoricoMes> historico, ProyeccionPredictiva proyeccion)
        {
            chartTendencia.Series.Clear();
            chartTendencia.Titles.Clear();
            chartTendencia.ChartAreas.Clear();
            chartTendencia.Legends.Clear();

            ChartArea area = new ChartArea("AreaTendencia");
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Format = "$#,##0";
            area.AxisX.Interval = 1;
            chartTendencia.ChartAreas.Add(area);

            // Leyenda explicativa con items personalizados
            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Top;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Segoe UI", 8.5F);
            legend.BackColor = Color.Transparent;

            LegendItem itemReal = new LegendItem();
            itemReal.Name = "Ingresos Reales";
            itemReal.Color = Color.FromArgb(59, 110, 78);
            legend.CustomItems.Add(itemReal);

            LegendItem itemProy = new LegendItem();
            itemProy.Name = "Proyección Estimada";
            itemProy.Color = Color.FromArgb(143, 168, 149);
            itemProy.BorderColor = Color.FromArgb(59, 110, 78);
            itemProy.BorderWidth = 2;
            itemProy.BorderDashStyle = ChartDashStyle.Dash;
            legend.CustomItems.Add(itemProy);

            chartTendencia.Legends.Add(legend);

            // Serie unificada para que las barras se ubiquen de forma 100% cronológica (el mes proyectado al final)
            Series ser = new Series("Ingresos");
            ser.ChartType = SeriesChartType.Column;
            ser.IsValueShownAsLabel = true;
            ser.LabelFormat = "$#,##0";
            ser.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ser.IsVisibleInLegend = false;

            // Barras de meses históricos reales
            foreach (var d in historico)
            {
                int idx = ser.Points.AddXY(d.Etiqueta, d.Ingresos);
                ser.Points[idx].Color = Color.FromArgb(59, 110, 78);
            }

            // Barra del mes proyectado al final de la serie temporal
            int pIdx = ser.Points.AddXY(proyeccion.MesProyectado + " (Est.)", proyeccion.IngresoEstimado);
            ser.Points[pIdx].Color = Color.FromArgb(143, 168, 149);
            ser.Points[pIdx].BorderColor = Color.FromArgb(59, 110, 78);
            ser.Points[pIdx].BorderWidth = 2;
            ser.Points[pIdx].BorderDashStyle = ChartDashStyle.Dash;

            chartTendencia.Series.Add(ser);
            chartTendencia.Visible = true;
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
            _seccionPredictivaPendiente = false;
            doc.BeginPrint += (s, ev) => { 
                _filaActualReporte = 0; 
                _seccionPredictivaPendiente = false; 
            };
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

                // Si quedó pendiente la sección predictiva para una hoja dedicada
                if (_seccionPredictivaPendiente)
                {
                    g.DrawString("RoomIn Hotel", fontTitulo, brush, x, y);
                    y += rowH * 1.5f;

                    DibujarSeccionPredictivaConGrafico(g, fontSub, fontTotals, fontData, brush, x, right, ref y, rowH);

                    _seccionPredictivaPendiente = false;
                    e.HasMorePages = false;
                    return;
                }

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
                    if (y + rowH > e.MarginBounds.Bottom - 60)
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
                y += rowH;

                // Sección predictiva y gráfico en el PDF si fue calculada
                if (_proyeccionActual != null)
                {
                    float espacioRequerido = 320f;
                    if (y + espacioRequerido > e.MarginBounds.Bottom)
                    {
                        _seccionPredictivaPendiente = true;
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        y += rowH * 0.5f;
                        DibujarSeccionPredictivaConGrafico(g, fontSub, fontTotals, fontData, brush, x, right, ref y, rowH);
                    }
                }

                e.HasMorePages = false;
            }
        }

        private void DibujarSeccionPredictivaConGrafico(Graphics g, Font fontSub, Font fontTotals, Font fontData, Brush brush, float x, float right, ref float y, float rowH)
        {
            if (_proyeccionActual == null) return;

            g.DrawLine(Pens.Black, x, y, right, y);
            y += 10;

            g.DrawString("ANÁLISIS PREDICTIVO (REGRESIÓN LINEAL - MÍNIMOS CUADRADOS)", fontSub, brush, x, y);
            y += rowH * 1.3f;

            string lineaPred = $"Período proyectado: {_proyeccionActual.MesProyectado}   |   Ingreso estimado: ${_proyeccionActual.IngresoEstimado:N2}   |   Reservas estimadas: {_proyeccionActual.ReservasEstimadas}";
            g.DrawString(lineaPred, fontTotals, brush, x, y);
            y += rowH;

            string lineaTend = $"Tendencia esperada: {_proyeccionActual.Tendencia}";
            g.DrawString(lineaTend, fontData, brush, x, y);
            y += rowH * 1.3f;

            // Renderizado nativo del gráfico en alta resolución
            try
            {
                if (chartTendencia != null && chartTendencia.Visible)
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        chartTendencia.SaveImage(ms, ChartImageFormat.Png);
                        using (Image imgChart = Image.FromStream(ms))
                        {
                            float maxW = Math.Min(580f, right - x);
                            float ratio = (float)imgChart.Height / (float)imgChart.Width;
                            float chartW = maxW;
                            float chartH = chartW * ratio;
                            if (chartH > 240f) chartH = 240f;

                            float chartX = x + ((right - x) - chartW) / 2f;
                            g.DrawImage(imgChart, chartX, y, chartW, chartH);
                            y += chartH + 10;
                        }
                    }
                }
            }
            catch
            {
                // Si la imagen no puede ser exportada, la generación de texto del PDF continúa normalmente
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            PdfAyuda.Abrir(this.Name);
        }
    }
}
