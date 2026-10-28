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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBitacoraCambios = new System.Windows.Forms.Label();
            this.lblTipoHabitacion_C = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIdTipoHabitacion = new System.Windows.Forms.Label();
            this.txtIdTipoHabitacion = new System.Windows.Forms.TextBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBitacoraCambios);
            this.panel1.Controls.Add(this.lblTipoHabitacion_C);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblIdTipoHabitacion);
            this.panel1.Controls.Add(this.txtIdTipoHabitacion);
            this.panel1.Controls.Add(this.btnActivar);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 480);
            this.panel1.TabIndex = 0;
            // 
            // lblBitacoraCambios
            // 
            this.lblBitacoraCambios.AutoSize = true;
            this.lblBitacoraCambios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBitacoraCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblBitacoraCambios.Location = new System.Drawing.Point(15, 12);
            this.lblBitacoraCambios.Name = "lblBitacoraCambios";
            this.lblBitacoraCambios.Size = new System.Drawing.Size(204, 28);
            this.lblBitacoraCambios.TabIndex = 0;
            this.lblBitacoraCambios.Text = "Bitacora de cambios";
            // 
            // lblTipoHabitacion_C
            // 
            this.lblTipoHabitacion_C.AutoSize = true;
            this.lblTipoHabitacion_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTipoHabitacion_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            this.lblTipoHabitacion_C.Location = new System.Drawing.Point(619, 12);
            this.lblTipoHabitacion_C.Name = "lblTipoHabitacion_C";
            this.lblTipoHabitacion_C.Size = new System.Drawing.Size(124, 20);
            this.lblTipoHabitacion_C.TabIndex = 1;
            this.lblTipoHabitacion_C.Text = "TipoHabitacion_C";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(168)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.dataGridView1.Location = new System.Drawing.Point(15, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblIdTipoHabitacion
            // 
            this.lblIdTipoHabitacion.AutoSize = true;
            this.lblIdTipoHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblIdTipoHabitacion.Location = new System.Drawing.Point(20, 420);
            this.lblIdTipoHabitacion.Name = "lblIdTipoHabitacion";
            this.lblIdTipoHabitacion.Size = new System.Drawing.Size(136, 20);
            this.lblIdTipoHabitacion.TabIndex = 3;
            this.lblIdTipoHabitacion.Text = "Id Tipo Habitacion:";
            // 
            // txtIdTipoHabitacion
            // 
            this.txtIdTipoHabitacion.BackColor = System.Drawing.Color.White;
            this.txtIdTipoHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdTipoHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.txtIdTipoHabitacion.Location = new System.Drawing.Point(165, 417);
            this.txtIdTipoHabitacion.Name = "txtIdTipoHabitacion";
            this.txtIdTipoHabitacion.Size = new System.Drawing.Size(130, 27);
            this.txtIdTipoHabitacion.TabIndex = 4;
            this.txtIdTipoHabitacion.TextChanged += new System.EventHandler(this.txtIdTipoHabitacion_TextChanged_1);
            this.txtIdTipoHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTipoHabitacion_KeyPress);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(110)))), ((int)(((byte)(78)))));
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.Location = new System.Drawing.Point(552, 415);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(191, 32);
            this.btnActivar.TabIndex = 5;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click_1);
            // 
            // FrmBitacoraCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmBitacoraCambios";
            this.Text = "FrmBitacoraCambios";
            this.Resize += new System.EventHandler(this.FrmBitacoraCambios_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdTipoHabitacion;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label lblIdTipoHabitacion;
        private System.Windows.Forms.Label lblBitacoraCambios;
        private System.Windows.Forms.Label lblTipoHabitacion_C;
    }
}
