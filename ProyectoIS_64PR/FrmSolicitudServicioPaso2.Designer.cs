namespace ProyectoIS_64PR
{
    partial class FrmSolicitudServicioPaso2
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
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cmbMetodoDePago = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbMetodoDePago);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.btnAgregarCuenta);
            this.panel1.Controls.Add(this.lblServicios);
            this.panel1.Controls.Add(this.lstTipos);
            this.panel1.Location = new System.Drawing.Point(40, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 440);
            this.panel1.TabIndex = 0;
            // 
            // lstTipos
            // 
            this.lstTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTipos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.ItemHeight = 21;
            this.lstTipos.Location = new System.Drawing.Point(25, 50);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(270, 360);
            this.lstTipos.TabIndex = 0;
            this.lstTipos.SelectedIndexChanged += new System.EventHandler(this.lstTipos_SelectedIndexChanged);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblServicios.Location = new System.Drawing.Point(25, 20);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(248, 23);
            this.lblServicios.TabIndex = 1;
            this.lblServicios.Text = "Seleccione el servicio deseado";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAgregarCuenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(325, 60);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(260, 38);
            this.btnAgregarCuenta.TabIndex = 2;
            this.btnAgregarCuenta.Text = "Agregar a la cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = false;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(325, 115);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(260, 38);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar ahora";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cmbMetodoDePago
            // 
            this.cmbMetodoDePago.BackColor = System.Drawing.Color.White;
            this.cmbMetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoDePago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbMetodoDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.cmbMetodoDePago.FormattingEnabled = true;
            this.cmbMetodoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta De Debito",
            "Tarjeta De Credito",
            "Transferencia"});
            this.cmbMetodoDePago.Location = new System.Drawing.Point(325, 175);
            this.cmbMetodoDePago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMetodoDePago.Name = "cmbMetodoDePago";
            this.cmbMetodoDePago.Size = new System.Drawing.Size(260, 29);
            this.cmbMetodoDePago.TabIndex = 24;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(325, 225);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(260, 42);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmSolicitudServicioPaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSolicitudServicioPaso2";
            this.Text = "FrmSolicitudServicioPaso2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cmbMetodoDePago;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
