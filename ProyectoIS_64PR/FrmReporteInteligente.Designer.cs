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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotalReservasValor = new System.Windows.Forms.Label();
            this.lblTotalPeriodoValor = new System.Windows.Forms.Label();
            this.lblTotalPeriodo = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDescargar);
            this.panel1.Controls.Add(this.lblTotalPeriodo);
            this.panel1.Controls.Add(this.lblTotalReservas);
            this.panel1.Controls.Add(this.lblTotalPeriodoValor);
            this.panel1.Controls.Add(this.lblTotalReservasValor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.dgvReservas);
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 480);
            this.panel1.TabIndex = 0;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Location = new System.Drawing.Point(20, 45);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(760, 280);
            this.dgvReservas.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(20, 345);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(150, 29);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(20, 385);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(150, 29);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(190, 343);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(315, 28);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Reporte de ingresos por período";
            // 
            // lblTotalReservasValor
            // 
            this.lblTotalReservasValor.AutoSize = true;
            this.lblTotalReservasValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblTotalReservasValor.Location = new System.Drawing.Point(660, 348);
            this.lblTotalReservasValor.Name = "lblTotalReservasValor";
            this.lblTotalReservasValor.Size = new System.Drawing.Size(20, 23);
            this.lblTotalReservasValor.TabIndex = 5;
            this.lblTotalReservasValor.Text = "0";
            // 
            // lblTotalPeriodoValor
            // 
            this.lblTotalPeriodoValor.AutoSize = true;
            this.lblTotalPeriodoValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeriodoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblTotalPeriodoValor.Location = new System.Drawing.Point(660, 385);
            this.lblTotalPeriodoValor.Name = "lblTotalPeriodoValor";
            this.lblTotalPeriodoValor.Size = new System.Drawing.Size(60, 25);
            this.lblTotalPeriodoValor.TabIndex = 6;
            this.lblTotalPeriodoValor.Text = "$0,00";
            // 
            // lblTotalPeriodo
            // 
            this.lblTotalPeriodo.AutoSize = true;
            this.lblTotalPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTotalPeriodo.Location = new System.Drawing.Point(510, 386);
            this.lblTotalPeriodo.Name = "lblTotalPeriodo";
            this.lblTotalPeriodo.Size = new System.Drawing.Size(151, 23);
            this.lblTotalPeriodo.TabIndex = 8;
            this.lblTotalPeriodo.Text = "Total del periodo:";
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblTotalReservas.Location = new System.Drawing.Point(510, 348);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(142, 21);
            this.lblTotalReservas.TabIndex = 7;
            this.lblTotalReservas.Text = "Total de reservas:";
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(190, 383);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(120, 32);
            this.btnDescargar.TabIndex = 9;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // FrmReporteInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(860, 530);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteInteligente";
            this.Text = "FrmReporteInteligente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
