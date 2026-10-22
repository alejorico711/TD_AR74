namespace ProyectoIS_64PR
{
    partial class FrmBitacoraCambios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdTipoHabitacion = new System.Windows.Forms.TextBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblIdTipoHabitacion = new System.Windows.Forms.Label();
            this.lblBitacoraCambios = new System.Windows.Forms.Label();
            this.lblTipoHabitacion_C = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtIdTipoHabitacion
            // 
            this.txtIdTipoHabitacion.Location = new System.Drawing.Point(135, 324);
            this.txtIdTipoHabitacion.Name = "txtIdTipoHabitacion";
            this.txtIdTipoHabitacion.Size = new System.Drawing.Size(100, 22);
            this.txtIdTipoHabitacion.TabIndex = 1;
            this.txtIdTipoHabitacion.TextChanged += new System.EventHandler(this.txtIdTipoHabitacion_TextChanged_1);
            this.txtIdTipoHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTipoHabitacion_KeyPress);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(237, 317);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click_1);
            // 
            // lblIdTipoHabitacion
            // 
            this.lblIdTipoHabitacion.AutoSize = true;
            this.lblIdTipoHabitacion.Location = new System.Drawing.Point(9, 324);
            this.lblIdTipoHabitacion.Name = "lblIdTipoHabitacion";
            this.lblIdTipoHabitacion.Size = new System.Drawing.Size(120, 16);
            this.lblIdTipoHabitacion.TabIndex = 3;
            this.lblIdTipoHabitacion.Text = "Id Tipo Habitacion:";
            // 
            // lblBitacoraCambios
            // 
            this.lblBitacoraCambios.AutoSize = true;
            this.lblBitacoraCambios.Location = new System.Drawing.Point(12, 26);
            this.lblBitacoraCambios.Name = "lblBitacoraCambios";
            this.lblBitacoraCambios.Size = new System.Drawing.Size(131, 16);
            this.lblBitacoraCambios.TabIndex = 4;
            this.lblBitacoraCambios.Text = "Bitacora de cambios";
            // 
            // lblTipoHabitacion_C
            // 
            this.lblTipoHabitacion_C.AutoSize = true;
            this.lblTipoHabitacion_C.Location = new System.Drawing.Point(624, 26);
            this.lblTipoHabitacion_C.Name = "lblTipoHabitacion_C";
            this.lblTipoHabitacion_C.Size = new System.Drawing.Size(116, 16);
            this.lblTipoHabitacion_C.TabIndex = 5;
            this.lblTipoHabitacion_C.Text = "TipoHabitacion_C";
            // 
            // FrmBitacoraCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoHabitacion_C);
            this.Controls.Add(this.lblBitacoraCambios);
            this.Controls.Add(this.lblIdTipoHabitacion);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.txtIdTipoHabitacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBitacoraCambios";
            this.Text = "FrmBitacoraCambios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdTipoHabitacion;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label lblIdTipoHabitacion;
        private System.Windows.Forms.Label lblBitacoraCambios;
        private System.Windows.Forms.Label lblTipoHabitacion_C;
    }
}