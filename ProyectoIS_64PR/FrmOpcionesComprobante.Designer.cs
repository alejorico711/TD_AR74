namespace ProyectoIS_64PR
{
    partial class FrmOpcionesComprobante
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
            this.lblComrpobanteCheckout = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnDescargarPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComrpobanteCheckout
            // 
            this.lblComrpobanteCheckout.AutoSize = true;
            this.lblComrpobanteCheckout.Location = new System.Drawing.Point(9, 9);
            this.lblComrpobanteCheckout.Name = "lblComrpobanteCheckout";
            this.lblComrpobanteCheckout.Size = new System.Drawing.Size(383, 16);
            this.lblComrpobanteCheckout.TabIndex = 0;
            this.lblComrpobanteCheckout.Text = "Check-out confirmado, ¿Que desea hacer con el comprobante?";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(12, 59);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnDescargarPdf
            // 
            this.btnDescargarPdf.Location = new System.Drawing.Point(317, 59);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarPdf.TabIndex = 2;
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.UseVisualStyleBackColor = true;
            this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);
            // 
            // FrmOpcionesComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 94);
            this.Controls.Add(this.btnDescargarPdf);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblComrpobanteCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpcionesComprobante";
            this.Text = "FrmOpcionesComprobante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComrpobanteCheckout;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDescargarPdf;
    }
}