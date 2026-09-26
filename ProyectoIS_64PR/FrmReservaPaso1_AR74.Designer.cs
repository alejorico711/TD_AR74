namespace ProyectoIS_64PR
{
    partial class FrmReservaPaso1_AR74
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(143, 74);
            this.dtpInicio.MinDate = new System.DateTime(2026, 9, 9, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(143, 102);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFin.TabIndex = 1;
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(143, 130);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(120, 22);
            this.nupCantidad.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(143, 158);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(34, 80);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(44, 16);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "label1";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(34, 107);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(44, 16);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "label2";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(34, 136);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(44, 16);
            this.lblCantidadPersonas.TabIndex = 6;
            this.lblCantidadPersonas.Text = "label3";
            // 
            // FrmReservaPaso1_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidadPersonas);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Name = "FrmReservaPaso1_AR74";
            this.Text = "FrmFecha_AR74";
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblCantidadPersonas;
    }
}