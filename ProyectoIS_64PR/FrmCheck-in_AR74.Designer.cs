namespace ProyectoIS_64PR
{
    partial class FrmCheck_in_AR74
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
            this.flowLayoutPanelHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscarPorDNI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHabitaciones
            // 
            this.flowLayoutPanelHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelHabitaciones.Name = "flowLayoutPanelHabitaciones";
            this.flowLayoutPanelHabitaciones.Size = new System.Drawing.Size(799, 504);
            this.flowLayoutPanelHabitaciones.TabIndex = 0;
            // 
            // lblBuscarPorDNI
            // 
            this.lblBuscarPorDNI.AutoSize = true;
            this.lblBuscarPorDNI.Location = new System.Drawing.Point(12, 15);
            this.lblBuscarPorDNI.Name = "lblBuscarPorDNI";
            this.lblBuscarPorDNI.Size = new System.Drawing.Size(50, 20);
            this.lblBuscarPorDNI.TabIndex = 0;
            this.lblBuscarPorDNI.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanelHabitaciones);
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 504);
            this.panel1.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(157, 12);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(111, 27);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // FrmCheck_in_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBuscarPorDNI);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCheck_in_AR74";
            this.Text = "Check In - Reservas de Hoy";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHabitaciones;
        private System.Windows.Forms.Label lblBuscarPorDNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDNI;
    }
}