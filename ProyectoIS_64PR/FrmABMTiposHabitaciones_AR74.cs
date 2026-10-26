using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmABMTiposHabitaciones_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        List<TipoHabitacion> lst = new List<TipoHabitacion>();
        BLL_64PR.BLL_TiposHabitacion_AR74 gtipos = new BLL_64PR.BLL_TiposHabitacion_AR74();
        BE.TipoHabitacion t;
        Dictionary<string, string> textos;
        public FrmABMTiposHabitaciones_AR74()
        {
            InitializeComponent();
            nupPrecio.Minimum = 0;
            nupPrecio.Maximum = 1000000;        
            nupPrecio.Increment = 100;          

            nupCapacidad.Minimum = 1;
            nupCapacidad.Maximum = 10;

            dgvTipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipos.RowHeadersVisible = false;
            dgvTipos.AllowUserToAddRows = false;
            dgvTipos.BackgroundColor = Color.White;
            dgvTipos.BorderStyle = BorderStyle.None;
            dgvTipos.ReadOnly = true;
            dgvTipos.MultiSelect = false;
            CargaData();

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            this.Resize += FrmABMTiposHabitaciones_AR74_Resize;
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

        private void FrmABMTiposHabitaciones_AR74_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }
        private void CargaData()
        {
            dgvTipos.DataSource = null;
            lst = gtipos.ListarTiposHabitacion();
            dgvTipos.DataSource = lst;
            LimpiarControles();
            dgvTipos.Columns["Activo"].Visible = false;
            dgvTipos.Columns["IdTipoHabitacion"].Visible = false;
        }
        private void LimpiarControles()
        {
            txtDescripcion.Text = string.Empty;
            nupPrecio.Value = 0;
            nupCapacidad.Value = 1;
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show(textos["msgCompletarDescripcion"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoHabitacion tipo = new TipoHabitacion
            {
                Descripcion = txtDescripcion.Text.Trim(),
                Capacidad = (int)nupCapacidad.Value,
                PrecioPorNoche = nupPrecio.Value
            };

            try
            {
                gtipos.RegistrarTipoHabitacion(tipo);
                CargaData();
                MessageBox.Show(textos["msgAltaTipo"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            t = (TipoHabitacion)dgvTipos.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(textos["msgBajaTH"] + t.Descripcion + "?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                gtipos.EliminarTipoHabitacion(t.IdTipoHabitacion);
                CargaData();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show(textos["msgNoTH"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show(textos["msgCompletarDescripcion"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoHabitacion tipo = new TipoHabitacion
            {
                IdTipoHabitacion = t.IdTipoHabitacion,
                Descripcion = txtDescripcion.Text.Trim(),
                Capacidad = (int)nupCapacidad.Value,
                PrecioPorNoche = nupPrecio.Value
            };

            try
            {
                gtipos.ModificarTipoHabitacion(tipo);
                CargaData();
                t = null;
                MessageBox.Show(textos["msgTHModificado"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void dgvTipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipos.CurrentRow == null) return;

            t = (TipoHabitacion)dgvTipos.CurrentRow.DataBoundItem;
            txtDescripcion.Text = t.Descripcion;
            nupCapacidad.Value = t.Capacidad;
            nupPrecio.Value = t.PrecioPorNoche;
        }
    }
}
