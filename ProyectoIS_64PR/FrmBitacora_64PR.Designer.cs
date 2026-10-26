namespace ProyectoIS_64PR
{
    partial class FrmBitacora_64PR
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.cbLogin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLogins = new System.Windows.Forms.ComboBox();
            this.cbModulo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModulos = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.cbCriticidad = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.cbInicio = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbFin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvEventos);
            this.panel1.Controls.Add(this.cbLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbLogins);
            this.panel1.Controls.Add(this.cbModulo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbModulos);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbTipos);
            this.panel1.Controls.Add(this.cbCriticidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbCriticidad);
            this.panel1.Controls.Add(this.cbInicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.cbFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 500);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitacora de eventos";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.EnableHeadersVisualStyles = false;
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dgvEventos.Location = new System.Drawing.Point(15, 42);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(748, 275);
            this.dgvEventos.TabIndex = 1;
            // 
            // cbLogin
            // 
            this.cbLogin.AutoSize = true;
            this.cbLogin.Location = new System.Drawing.Point(15, 335);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(18, 17);
            this.cbLogin.TabIndex = 2;
            this.cbLogin.UseVisualStyleBackColor = true;
            this.cbLogin.CheckedChanged += new System.EventHandler(this.cbLogin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(38, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // cmbLogins
            // 
            this.cmbLogins.BackColor = System.Drawing.Color.White;
            this.cmbLogins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLogins.FormattingEnabled = true;
            this.cmbLogins.Location = new System.Drawing.Point(95, 330);
            this.cmbLogins.Name = "cmbLogins";
            this.cmbLogins.Size = new System.Drawing.Size(130, 28);
            this.cmbLogins.TabIndex = 4;
            // 
            // cbModulo
            // 
            this.cbModulo.AutoSize = true;
            this.cbModulo.Location = new System.Drawing.Point(245, 335);
            this.cbModulo.Name = "cbModulo";
            this.cbModulo.Size = new System.Drawing.Size(18, 17);
            this.cbModulo.TabIndex = 5;
            this.cbModulo.UseVisualStyleBackColor = true;
            this.cbModulo.CheckedChanged += new System.EventHandler(this.cbModulo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(268, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modulo:";
            // 
            // cmbModulos
            // 
            this.cmbModulos.BackColor = System.Drawing.Color.White;
            this.cmbModulos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbModulos.FormattingEnabled = true;
            this.cmbModulos.Location = new System.Drawing.Point(335, 330);
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.Size = new System.Drawing.Size(130, 28);
            this.cmbModulos.TabIndex = 7;
            // 
            // cbTipo
            // 
            this.cbTipo.AutoSize = true;
            this.cbTipo.Location = new System.Drawing.Point(485, 335);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(18, 17);
            this.cbTipo.TabIndex = 8;
            this.cbTipo.UseVisualStyleBackColor = true;
            this.cbTipo.CheckedChanged += new System.EventHandler(this.cbTipo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label6.Location = new System.Drawing.Point(508, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Evento:";
            // 
            // cmbTipos
            // 
            this.cmbTipos.BackColor = System.Drawing.Color.White;
            this.cmbTipos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(575, 330);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(188, 28);
            this.cmbTipos.TabIndex = 10;
            // 
            // cbCriticidad
            // 
            this.cbCriticidad.AutoSize = true;
            this.cbCriticidad.Location = new System.Drawing.Point(15, 380);
            this.cbCriticidad.Name = "cbCriticidad";
            this.cbCriticidad.Size = new System.Drawing.Size(18, 17);
            this.cbCriticidad.TabIndex = 11;
            this.cbCriticidad.UseVisualStyleBackColor = true;
            this.cbCriticidad.CheckedChanged += new System.EventHandler(this.cbCriticidad_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label7.Location = new System.Drawing.Point(38, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Criticidad:";
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.BackColor = System.Drawing.Color.White;
            this.cmbCriticidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCriticidad.Location = new System.Drawing.Point(115, 375);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(110, 28);
            this.cmbCriticidad.TabIndex = 13;
            // 
            // cbInicio
            // 
            this.cbInicio.AutoSize = true;
            this.cbInicio.Location = new System.Drawing.Point(245, 380);
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(18, 17);
            this.cbInicio.TabIndex = 14;
            this.cbInicio.UseVisualStyleBackColor = true;
            this.cbInicio.CheckedChanged += new System.EventHandler(this.cbInicio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(268, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(360, 375);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(105, 27);
            this.dtpInicio.TabIndex = 16;
            // 
            // cbFin
            // 
            this.cbFin.AutoSize = true;
            this.cbFin.Location = new System.Drawing.Point(485, 380);
            this.cbFin.Name = "cbFin";
            this.cbFin.Size = new System.Drawing.Size(18, 17);
            this.cbFin.TabIndex = 17;
            this.cbFin.UseVisualStyleBackColor = true;
            this.cbFin.CheckedChanged += new System.EventHandler(this.cbFin_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(508, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(585, 375);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(178, 27);
            this.dtpFin.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnLimpiar.Location = new System.Drawing.Point(375, 435);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(505, 435);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(115, 32);
            this.btnAplicar.TabIndex = 21;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(635, 435);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 32);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmBitacora_64PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBitacora_64PR";
            this.Text = "FrmBitacora_64PR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBitacora_64PR_FormClosed);
            this.Resize += new System.EventHandler(this.FrmBitacora_64PR_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cmbLogins;
        private System.Windows.Forms.ComboBox cmbModulos;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.CheckBox cbTipo;
        private System.Windows.Forms.CheckBox cbCriticidad;
        private System.Windows.Forms.CheckBox cbFin;
        private System.Windows.Forms.CheckBox cbInicio;
        private System.Windows.Forms.CheckBox cbModulo;
        private System.Windows.Forms.CheckBox cbLogin;
    }
}
