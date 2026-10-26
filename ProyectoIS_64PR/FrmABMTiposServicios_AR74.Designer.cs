namespace ProyectoIS_64PR
{
    partial class FrmABMTiposServicios_AR74
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblRequiereStaff = new System.Windows.Forms.Label();
            this.rbRequiereStaff = new System.Windows.Forms.CheckBox();
            this.bttnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvServicios);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.nupPrecio);
            this.panel1.Controls.Add(this.lblRequiereStaff);
            this.panel1.Controls.Add(this.rbRequiereStaff);
            this.panel1.Controls.Add(this.bttnAlta);
            this.panel1.Controls.Add(this.btnBaja);
            this.panel1.Controls.Add(this.btnModificacion);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 500);
            this.panel1.TabIndex = 0;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicios.EnableHeadersVisualStyles = false;
            this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dgvServicios.Location = new System.Drawing.Point(15, 15);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.Size = new System.Drawing.Size(728, 280);
            this.dgvServicios.TabIndex = 0;
            this.dgvServicios.SelectionChanged += new System.EventHandler(this.dgvServicios_SelectionChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblDescripcion.Location = new System.Drawing.Point(25, 315);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.txtDescripcion.Location = new System.Drawing.Point(160, 312);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 27);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblPrecio.Location = new System.Drawing.Point(25, 355);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // nupPrecio
            // 
            this.nupPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupPrecio.Location = new System.Drawing.Point(160, 352);
            this.nupPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(180, 27);
            this.nupPrecio.TabIndex = 4;
            // 
            // lblRequiereStaff
            // 
            this.lblRequiereStaff.AutoSize = true;
            this.lblRequiereStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRequiereStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblRequiereStaff.Location = new System.Drawing.Point(25, 395);
            this.lblRequiereStaff.Name = "lblRequiereStaff";
            this.lblRequiereStaff.Size = new System.Drawing.Size(103, 20);
            this.lblRequiereStaff.TabIndex = 5;
            this.lblRequiereStaff.Text = "Requiere staff:";
            // 
            // rbRequiereStaff
            // 
            this.rbRequiereStaff.AutoSize = true;
            this.rbRequiereStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbRequiereStaff.Location = new System.Drawing.Point(160, 395);
            this.rbRequiereStaff.Name = "rbRequiereStaff";
            this.rbRequiereStaff.Size = new System.Drawing.Size(18, 17);
            this.rbRequiereStaff.TabIndex = 6;
            this.rbRequiereStaff.UseVisualStyleBackColor = true;
            // 
            // bttnAlta
            // 
            this.bttnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.bttnAlta.FlatAppearance.BorderSize = 0;
            this.bttnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bttnAlta.ForeColor = System.Drawing.Color.White;
            this.bttnAlta.Location = new System.Drawing.Point(480, 312);
            this.bttnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttnAlta.Name = "bttnAlta";
            this.bttnAlta.Size = new System.Drawing.Size(110, 32);
            this.bttnAlta.TabIndex = 7;
            this.bttnAlta.Text = "button1";
            this.bttnAlta.UseVisualStyleBackColor = false;
            this.bttnAlta.Click += new System.EventHandler(this.bttnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(610, 312);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(110, 32);
            this.btnBaja.TabIndex = 8;
            this.btnBaja.Text = "button2";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnModificacion.FlatAppearance.BorderSize = 0;
            this.btnModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificacion.ForeColor = System.Drawing.Color.White;
            this.btnModificacion.Location = new System.Drawing.Point(480, 362);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(110, 32);
            this.btnModificacion.TabIndex = 9;
            this.btnModificacion.Text = "button3";
            this.btnModificacion.UseVisualStyleBackColor = false;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnLimpiar.Location = new System.Drawing.Point(610, 362);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "button3";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmABMTiposServicios_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmABMTiposServicios_AR74";
            this.Text = "FrmABMTiposServicios_AR74";
            this.Resize += new System.EventHandler(this.FrmABMTiposServicios_AR74_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblRequiereStaff;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button bttnAlta;
        private System.Windows.Forms.CheckBox rbRequiereStaff;
    }
}
