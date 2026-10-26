using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmBitacoraCambios : Form, Idioma.IObservadorIdioma_64PR
    {
        private BLL_64PR.BLL_TiposHabitacion_AR74 gtipos = new BLL_64PR.BLL_TiposHabitacion_AR74();
        Dictionary<string, string> textos;

        public FrmBitacoraCambios()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarBitacora();
            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            this.Resize += FrmBitacoraCambios_Resize;
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void FrmBitacoraCambios_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }

        // ── Configuración inicial ────────────────────────────────────────────

        private void ConfigurarGrilla()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
        }

        // ── Carga / Recarga ──────────────────────────────────────────────────

        private void CargarBitacora()
        {
            try
            {
                DataTable dt = gtipos.ListarBitacoraCambios(txtIdTipoHabitacion.Text);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(textos["msgSeleccioneRegistro"],
                                "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;

            int id = Convert.ToInt32(drv["IdTipoHabitacion"]);
            DateTime fecha = Convert.ToDateTime(drv["Fecha"]);
            TimeSpan hora = (TimeSpan)drv["Hora"];

            bool yaEsActual = Convert.ToBoolean(drv["Actual"]);
            if (yaEsActual)
            {
                MessageBox.Show(textos["msgRegistroActivo"],
                                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //
            DialogResult confirmacion = MessageBox.Show(
                textos["msgConfirmacion1"] + " " + fecha.ToString("dd/MM/yyyy") + " " +hora.ToString() + " " + textos["msgConfirmacion2"] + " " + id + " ? ",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                gtipos.ActivarRegistroBitacora(id, fecha, hora);
                CargarBitacora();
                MessageBox.Show(textos["msgRegistroActivado"],
                                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al activar el registro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdTipoHabitacion_TextChanged_1(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void txtIdTipoHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si NO es un número y NO es la tecla de borrar (BackSpace)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento
            }
        }
    }
}
