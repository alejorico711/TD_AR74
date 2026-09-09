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
            this.cmbHuesped = new System.Windows.Forms.ComboBox();
            this.btnRegistrarHuesped = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbHuesped
            // 
            this.cmbHuesped.FormattingEnabled = true;
            this.cmbHuesped.Location = new System.Drawing.Point(12, 12);
            this.cmbHuesped.Name = "cmbHuesped";
            this.cmbHuesped.Size = new System.Drawing.Size(215, 24);
            this.cmbHuesped.TabIndex = 0;
            // 
            // btnRegistrarHuesped
            // 
            this.btnRegistrarHuesped.Location = new System.Drawing.Point(233, 12);
            this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
            this.btnRegistrarHuesped.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarHuesped.TabIndex = 1;
            this.btnRegistrarHuesped.Text = "button1";
            this.btnRegistrarHuesped.UseVisualStyleBackColor = true;
            this.btnRegistrarHuesped.Click += new System.EventHandler(this.btnRegistrarHuesped_Click);
            // 
            // FrmReservaPaso3_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarHuesped);
            this.Controls.Add(this.cmbHuesped);
            this.Name = "FrmReservaPaso3_AR74";
            this.Text = "FrmReservaPaso3_AR74";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHuesped;
        private System.Windows.Forms.Button btnRegistrarHuesped;
    }
}