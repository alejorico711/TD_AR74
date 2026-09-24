namespace ProyectoIS_64PR
{
    partial class FrmABMHabitaciones_AR74
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTipoHabitacin = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.bttnAlta = new System.Windows.Forms.Button();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.nupNumero = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(445, 404);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "button3";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTipoHabitacin
            // 
            this.lblTipoHabitacin.AutoSize = true;
            this.lblTipoHabitacin.Location = new System.Drawing.Point(24, 326);
            this.lblTipoHabitacin.Name = "lblTipoHabitacin";
            this.lblTipoHabitacin.Size = new System.Drawing.Size(60, 16);
            this.lblTipoHabitacin.TabIndex = 39;
            this.lblTipoHabitacin.Text = "Apellido:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(24, 298);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Numero:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 270);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 270);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 31;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(445, 377);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificacion.TabIndex = 30;
            this.btnModificacion.Text = "button3";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(445, 348);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 29;
            this.btnBaja.Text = "button2";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // bttnAlta
            // 
            this.bttnAlta.Location = new System.Drawing.Point(445, 319);
            this.bttnAlta.Name = "bttnAlta";
            this.bttnAlta.Size = new System.Drawing.Size(75, 23);
            this.bttnAlta.TabIndex = 28;
            this.bttnAlta.Text = "button1";
            this.bttnAlta.UseVisualStyleBackColor = true;
            this.bttnAlta.Click += new System.EventHandler(this.bttnAlta_Click);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(12, 23);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.RowTemplate.Height = 24;
            this.dgvHabitaciones.Size = new System.Drawing.Size(776, 235);
            this.dgvHabitaciones.TabIndex = 27;
            this.dgvHabitaciones.SelectionChanged += new System.EventHandler(this.dgvHabitaciones_SelectionChanged);
            // 
            // nupNumero
            // 
            this.nupNumero.Location = new System.Drawing.Point(129, 298);
            this.nupNumero.Name = "nupNumero";
            this.nupNumero.Size = new System.Drawing.Size(120, 22);
            this.nupNumero.TabIndex = 44;
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(129, 326);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoHabitacion.TabIndex = 45;
            // 
            // FrmABMHabitaciones_AR74
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.nupNumero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTipoHabitacin);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.bttnAlta);
            this.Controls.Add(this.dgvHabitaciones);
            this.Name = "FrmABMHabitaciones_AR74";
            this.Text = "FrmABMHabitaciones_AR74";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTipoHabitacin;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button bttnAlta;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.NumericUpDown nupNumero;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
    }
}