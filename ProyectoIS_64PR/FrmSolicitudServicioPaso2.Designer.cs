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
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cmbMetodoDePago = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTipos
            // 
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.ItemHeight = 16;
            this.lstTipos.Location = new System.Drawing.Point(12, 44);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(239, 388);
            this.lstTipos.TabIndex = 0;
            this.lstTipos.SelectedIndexChanged += new System.EventHandler(this.lstTipos_SelectedIndexChanged);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(12, 25);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(197, 16);
            this.lblServicios.TabIndex = 1;
            this.lblServicios.Text = "Seleccione el servicio deseado";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Location = new System.Drawing.Point(700, 322);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCuenta.TabIndex = 2;
            this.btnAgregarCuenta.Text = "button1";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(700, 351);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "button2";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cmbMetodoDePago
            // 
            this.cmbMetodoDePago.BackColor = System.Drawing.Color.White;
            this.cmbMetodoDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodoDePago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMetodoDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.cmbMetodoDePago.FormattingEnabled = true;
            this.cmbMetodoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta De Debito",
            "Tarjeta De Credito",
            "Transferencia"});
            this.cmbMetodoDePago.Location = new System.Drawing.Point(475, 409);
            this.cmbMetodoDePago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMetodoDePago.Name = "cmbMetodoDePago";
            this.cmbMetodoDePago.Size = new System.Drawing.Size(121, 28);
            this.cmbMetodoDePago.TabIndex = 24;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(602, 381);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 56);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmSolicitudServicioPaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMetodoDePago);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.lstTipos);
            this.Name = "FrmSolicitudServicioPaso2";
            this.Text = "FrmSolicitudServicioPaso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cmbMetodoDePago;
        private System.Windows.Forms.Button btnConfirmar;
    }
}