namespace ProyectoIS_64PR
{
    partial class FrmEstadoActual_AR74
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHabitaciones
            // 
            this.flowLayoutPanelHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelHabitaciones.Name = "flowLayoutPanelHabitaciones";
            this.flowLayoutPanelHabitaciones.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelHabitaciones.TabIndex = 1;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAyuda.FlatAppearance.BorderSize = 1;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnAyuda.Location = new System.Drawing.Point(670, 10);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(110, 28);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "? Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FrmEstadoActual_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.flowLayoutPanelHabitaciones);
            this.Name = "FrmEstadoActual_AR74";
            this.Text = "FrmEstadoActual_AR74";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHabitaciones;
        private System.Windows.Forms.Button btnAyuda;
    }
}