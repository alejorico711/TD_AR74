namespace ProyectoIS_64PR
{
    partial class FrmReservaPaso3_AR74
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbHuesped = new System.Windows.Forms.ComboBox();
            this.btnRegistrarHuesped = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblValorFechas = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblValorPersonas = new System.Windows.Forms.Label();
            this.lblNochesxPrecio = new System.Windows.Forms.Label();
            this.lblValorNochesxPrecio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorHabitacion = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.pbHabitacion = new System.Windows.Forms.PictureBox();
            this.pbCalendario = new System.Windows.Forms.PictureBox();
            this.pbNoches = new System.Windows.Forms.PictureBox();
            this.pbPersonas = new System.Windows.Forms.PictureBox();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHuesped);
            this.panel1.Controls.Add(this.cmbHuesped);
            this.panel1.Controls.Add(this.btnRegistrarHuesped);
            this.panel1.Controls.Add(this.lblResumen);
            this.panel1.Controls.Add(this.pbHabitacion);
            this.panel1.Controls.Add(this.pbCalendario);
            this.panel1.Controls.Add(this.pbPersonas);
            this.panel1.Controls.Add(this.pbNoches);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnConfirmarReserva);
            this.panel1.Location = new System.Drawing.Point(45, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblHuesped.Location = new System.Drawing.Point(25, 25);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(193, 21);
            this.lblHuesped.TabIndex = 9;
            this.lblHuesped.Text = "Seleccione un huésped:";
            // 
            // cmbHuesped
            // 
            this.cmbHuesped.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHuesped.FormattingEnabled = true;
            this.cmbHuesped.Location = new System.Drawing.Point(215, 22);
            this.cmbHuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHuesped.Name = "cmbHuesped";
            this.cmbHuesped.Size = new System.Drawing.Size(250, 28);
            this.cmbHuesped.TabIndex = 0;
            this.cmbHuesped.SelectedIndexChanged += new System.EventHandler(this.cmbHuesped_SelectedIndexChanged);
            this.cmbHuesped.SelectedValueChanged += new System.EventHandler(this.cmbHuesped_SelectedValueChanged);
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnRegistrarHuesped.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHuesped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarHuesped.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(475, 20);
            this.btnRegistrarHuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(185, 32);
            this.btnRegistrarHuesped.TabIndex = 1;
            this.btnRegistrarHuesped.Text = "Nuevo Huésped";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = false;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.btnRegistrarHuesped_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblResumen.Location = new System.Drawing.Point(25, 75);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(222, 28);
            this.lblResumen.TabIndex = 4;
            this.lblResumen.Text = "Resumen de la reserva";
            // 
            // pbHabitacion
            // 
            this.pbHabitacion.Location = new System.Drawing.Point(30, 118);
            this.pbHabitacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbHabitacion.Name = "pbHabitacion";
            this.pbHabitacion.Size = new System.Drawing.Size(36, 36);
            this.pbHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHabitacion.TabIndex = 5;
            this.pbHabitacion.TabStop = false;
            // 
            // pbCalendario
            // 
            this.pbCalendario.Location = new System.Drawing.Point(30, 172);
            this.pbCalendario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCalendario.Name = "pbCalendario";
            this.pbCalendario.Size = new System.Drawing.Size(36, 36);
            this.pbCalendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCalendario.TabIndex = 6;
            this.pbCalendario.TabStop = false;
            // 
            // pbPersonas
            // 
            this.pbPersonas.Location = new System.Drawing.Point(30, 226);
            this.pbPersonas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPersonas.Name = "pbPersonas";
            this.pbPersonas.Size = new System.Drawing.Size(36, 36);
            this.pbPersonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonas.TabIndex = 8;
            this.pbPersonas.TabStop = false;
            // 
            // pbNoches
            // 
            this.pbNoches.Location = new System.Drawing.Point(30, 280);
            this.pbNoches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbNoches.Name = "pbNoches";
            this.pbNoches.Size = new System.Drawing.Size(36, 36);
            this.pbNoches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNoches.TabIndex = 7;
            this.pbNoches.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblHabitacion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValorHabitacion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblValorFechas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPersonas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblValorPersonas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNochesxPrecio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblValorNochesxPrecio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblValorTotal, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 110);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 260);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblHabitacion.Location = new System.Drawing.Point(3, 15);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(95, 21);
            this.lblHabitacion.TabIndex = 0;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblValorHabitacion
            // 
            this.lblValorHabitacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorHabitacion.AutoSize = true;
            this.lblValorHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValorHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblValorHabitacion.Location = new System.Drawing.Point(521, 15);
            this.lblValorHabitacion.Name = "lblValorHabitacion";
            this.lblValorHabitacion.Size = new System.Drawing.Size(56, 21);
            this.lblValorHabitacion.TabIndex = 1;
            this.lblValorHabitacion.Text = "label2";
            // 
            // lblFechas
            // 
            this.lblFechas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblFechas.Location = new System.Drawing.Point(3, 67);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(65, 21);
            this.lblFechas.TabIndex = 2;
            this.lblFechas.Text = "Fechas:";
            // 
            // lblValorFechas
            // 
            this.lblValorFechas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorFechas.AutoSize = true;
            this.lblValorFechas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValorFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblValorFechas.Location = new System.Drawing.Point(521, 67);
            this.lblValorFechas.Name = "lblValorFechas";
            this.lblValorFechas.Size = new System.Drawing.Size(56, 21);
            this.lblValorFechas.TabIndex = 3;
            this.lblValorFechas.Text = "label4";
            // 
            // lblPersonas
            // 
            this.lblPersonas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblPersonas.Location = new System.Drawing.Point(3, 119);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(81, 21);
            this.lblPersonas.TabIndex = 4;
            this.lblPersonas.Text = "Personas:";
            // 
            // lblValorPersonas
            // 
            this.lblValorPersonas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorPersonas.AutoSize = true;
            this.lblValorPersonas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValorPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblValorPersonas.Location = new System.Drawing.Point(521, 119);
            this.lblValorPersonas.Name = "lblValorPersonas";
            this.lblValorPersonas.Size = new System.Drawing.Size(56, 21);
            this.lblValorPersonas.TabIndex = 5;
            this.lblValorPersonas.Text = "label6";
            // 
            // lblNochesxPrecio
            // 
            this.lblNochesxPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNochesxPrecio.AutoSize = true;
            this.lblNochesxPrecio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNochesxPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblNochesxPrecio.Location = new System.Drawing.Point(3, 171);
            this.lblNochesxPrecio.Name = "lblNochesxPrecio";
            this.lblNochesxPrecio.Size = new System.Drawing.Size(65, 21);
            this.lblNochesxPrecio.TabIndex = 6;
            this.lblNochesxPrecio.Text = "Noches:";
            // 
            // lblValorNochesxPrecio
            // 
            this.lblValorNochesxPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorNochesxPrecio.AutoSize = true;
            this.lblValorNochesxPrecio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValorNochesxPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblValorNochesxPrecio.Location = new System.Drawing.Point(521, 171);
            this.lblValorNochesxPrecio.Name = "lblValorNochesxPrecio";
            this.lblValorNochesxPrecio.Size = new System.Drawing.Size(56, 21);
            this.lblValorNochesxPrecio.TabIndex = 7;
            this.lblValorNochesxPrecio.Text = "label8";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTotal.Location = new System.Drawing.Point(3, 221);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.lblValorTotal.Location = new System.Drawing.Point(509, 220);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(68, 28);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "label10";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            this.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarReserva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarReserva.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarReserva.Location = new System.Drawing.Point(460, 390);
            this.btnConfirmarReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(200, 38);
            this.btnConfirmarReserva.TabIndex = 3;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // FrmReservaPaso3_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(780, 510);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReservaPaso3_AR74";
            this.Text = "FrmReservaPaso3_AR74";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbHuesped;
        private System.Windows.Forms.Button btnRegistrarHuesped;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblValorFechas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblValorPersonas;
        private System.Windows.Forms.Label lblNochesxPrecio;
        private System.Windows.Forms.Label lblValorNochesxPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblValorHabitacion;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.PictureBox pbHabitacion;
        private System.Windows.Forms.PictureBox pbCalendario;
        private System.Windows.Forms.PictureBox pbNoches;
        private System.Windows.Forms.PictureBox pbPersonas;
        private System.Windows.Forms.Label lblHuesped;
    }
}
