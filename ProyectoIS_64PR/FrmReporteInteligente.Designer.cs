namespace ProyectoIS_64PR
{
    partial class FrmReporteInteligente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTendenciaValor = new System.Windows.Forms.Label();
            this.lblTendencia = new System.Windows.Forms.Label();
            this.lblProyeccionReservasValor = new System.Windows.Forms.Label();
            this.lblProyeccionReservas = new System.Windows.Forms.Label();
            this.lblProyeccionIngresosValor = new System.Windows.Forms.Label();
            this.lblProyeccionIngresos = new System.Windows.Forms.Label();
            this.lblTituloPrediccion = new System.Windows.Forms.Label();
            this.chartTendencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.lblTotalPeriodo = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.lblTotalPeriodoValor = new System.Windows.Forms.Label();
            this.lblTotalReservasValor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTendencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvReservas);
            this.panel1.Controls.Add(this.lblTendenciaValor);
            this.panel1.Controls.Add(this.lblTendencia);
            this.panel1.Controls.Add(this.lblProyeccionReservasValor);
            this.panel1.Controls.Add(this.lblProyeccionReservas);
            this.panel1.Controls.Add(this.lblProyeccionIngresosValor);
            this.panel1.Controls.Add(this.lblProyeccionIngresos);
            this.panel1.Controls.Add(this.lblTituloPrediccion);
            this.panel1.Controls.Add(this.chartTendencia);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnDescargar);
            this.panel1.Controls.Add(this.lblTotalPeriodo);
            this.panel1.Controls.Add(this.lblTotalReservas);
            this.panel1.Controls.Add(this.lblTotalPeriodoValor);
            this.panel1.Controls.Add(this.lblTotalReservasValor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 485);
            this.panel1.TabIndex = 0;
            // 
            // lblTendenciaValor
            // 
            this.lblTendenciaValor.AutoSize = true;
            this.lblTendenciaValor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTendenciaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblTendenciaValor.Location = new System.Drawing.Point(800, 405);
            this.lblTendenciaValor.Name = "lblTendenciaValor";
            this.lblTendenciaValor.Size = new System.Drawing.Size(16, 21);
            this.lblTendenciaValor.TabIndex = 17;
            this.lblTendenciaValor.Text = "-";
            // 
            // lblTendencia
            // 
            this.lblTendencia.AutoSize = true;
            this.lblTendencia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTendencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblTendencia.Location = new System.Drawing.Point(570, 405);
            this.lblTendencia.Name = "lblTendencia";
            this.lblTendencia.Size = new System.Drawing.Size(165, 21);
            this.lblTendencia.TabIndex = 16;
            this.lblTendencia.Text = "Tendencia esperada:";
            // 
            // lblProyeccionReservasValor
            // 
            this.lblProyeccionReservasValor.AutoSize = true;
            this.lblProyeccionReservasValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProyeccionReservasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblProyeccionReservasValor.Location = new System.Drawing.Point(800, 373);
            this.lblProyeccionReservasValor.Name = "lblProyeccionReservasValor";
            this.lblProyeccionReservasValor.Size = new System.Drawing.Size(20, 23);
            this.lblProyeccionReservasValor.TabIndex = 15;
            this.lblProyeccionReservasValor.Text = "0";
            // 
            // lblProyeccionReservas
            // 
            this.lblProyeccionReservas.AutoSize = true;
            this.lblProyeccionReservas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProyeccionReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblProyeccionReservas.Location = new System.Drawing.Point(570, 375);
            this.lblProyeccionReservas.Name = "lblProyeccionReservas";
            this.lblProyeccionReservas.Size = new System.Drawing.Size(162, 21);
            this.lblProyeccionReservas.TabIndex = 14;
            this.lblProyeccionReservas.Text = "Reservas estimadas:";
            // 
            // lblProyeccionIngresosValor
            // 
            this.lblProyeccionIngresosValor.AutoSize = true;
            this.lblProyeccionIngresosValor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblProyeccionIngresosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblProyeccionIngresosValor.Location = new System.Drawing.Point(800, 343);
            this.lblProyeccionIngresosValor.Name = "lblProyeccionIngresosValor";
            this.lblProyeccionIngresosValor.Size = new System.Drawing.Size(57, 25);
            this.lblProyeccionIngresosValor.TabIndex = 13;
            this.lblProyeccionIngresosValor.Text = "$0,00";
            // 
            // lblProyeccionIngresos
            // 
            this.lblProyeccionIngresos.AutoSize = true;
            this.lblProyeccionIngresos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProyeccionIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblProyeccionIngresos.Location = new System.Drawing.Point(570, 345);
            this.lblProyeccionIngresos.Name = "lblProyeccionIngresos";
            this.lblProyeccionIngresos.Size = new System.Drawing.Size(236, 21);
            this.lblProyeccionIngresos.TabIndex = 12;
            this.lblProyeccionIngresos.Text = "Ingreso estimado (próx. mes):";
            // 
            // lblTituloPrediccion
            // 
            this.lblTituloPrediccion.AutoSize = true;
            this.lblTituloPrediccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrediccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTituloPrediccion.Location = new System.Drawing.Point(570, 15);
            this.lblTituloPrediccion.Name = "lblTituloPrediccion";
            this.lblTituloPrediccion.Size = new System.Drawing.Size(302, 28);
            this.lblTituloPrediccion.TabIndex = 11;
            this.lblTituloPrediccion.Text = "Análisis Predictivo (Tendencia)";
            // 
            // chartTendencia
            // 
            this.chartTendencia.Location = new System.Drawing.Point(487, 46);
            this.chartTendencia.Name = "chartTendencia";
            this.chartTendencia.Size = new System.Drawing.Size(470, 280);
            this.chartTendencia.TabIndex = 10;
            this.chartTendencia.Text = "chartTendencia";
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAyuda.Location = new System.Drawing.Point(20, 420);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(110, 32);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = "? Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(175, 383);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(115, 32);
            this.btnDescargar.TabIndex = 9;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // lblTotalPeriodo
            // 
            this.lblTotalPeriodo.AutoSize = true;
            this.lblTotalPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTotalPeriodo.Location = new System.Drawing.Point(305, 386);
            this.lblTotalPeriodo.Name = "lblTotalPeriodo";
            this.lblTotalPeriodo.Size = new System.Drawing.Size(152, 23);
            this.lblTotalPeriodo.TabIndex = 8;
            this.lblTotalPeriodo.Text = "Total del periodo:";
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblTotalReservas.Location = new System.Drawing.Point(305, 348);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(142, 21);
            this.lblTotalReservas.TabIndex = 7;
            this.lblTotalReservas.Text = "Total de reservas:";
            // 
            // lblTotalPeriodoValor
            // 
            this.lblTotalPeriodoValor.AutoSize = true;
            this.lblTotalPeriodoValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeriodoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblTotalPeriodoValor.Location = new System.Drawing.Point(450, 385);
            this.lblTotalPeriodoValor.Name = "lblTotalPeriodoValor";
            this.lblTotalPeriodoValor.Size = new System.Drawing.Size(61, 25);
            this.lblTotalPeriodoValor.TabIndex = 6;
            this.lblTotalPeriodoValor.Text = "$0,00";
            // 
            // lblTotalReservasValor
            // 
            this.lblTotalReservasValor.AutoSize = true;
            this.lblTotalReservasValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblTotalReservasValor.Location = new System.Drawing.Point(450, 348);
            this.lblTotalReservasValor.Name = "lblTotalReservasValor";
            this.lblTotalReservasValor.Size = new System.Drawing.Size(20, 23);
            this.lblTotalReservasValor.TabIndex = 5;
            this.lblTotalReservasValor.Text = "0";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 28);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Reporte de ingresos por período";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(175, 343);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(20, 385);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(145, 29);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(20, 345);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(145, 29);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Location = new System.Drawing.Point(20, 45);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(491, 280);
            this.dgvReservas.TabIndex = 0;
            // 
            // FrmReporteInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1004, 508);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteInteligente";
            this.Text = "FrmReporteInteligente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTendencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotalReservasValor;
        private System.Windows.Forms.Label lblTotalPeriodoValor;
        private System.Windows.Forms.Label lblTotalPeriodo;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTendencia;
        private System.Windows.Forms.Label lblTituloPrediccion;
        private System.Windows.Forms.Label lblProyeccionIngresos;
        private System.Windows.Forms.Label lblProyeccionIngresosValor;
        private System.Windows.Forms.Label lblProyeccionReservas;
        private System.Windows.Forms.Label lblProyeccionReservasValor;
        private System.Windows.Forms.Label lblTendencia;
        private System.Windows.Forms.Label lblTendenciaValor;
    }
}
