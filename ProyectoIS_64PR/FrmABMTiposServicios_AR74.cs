using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmABMTiposServicios_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        BLL_64PR.BLL_TiposServicio_AR74 gtipos = new BLL_64PR.BLL_TiposServicio_AR74();
        BE.TipoServicio t;
        Dictionary<string, string> textos;
        public FrmABMTiposServicios_AR74()
        {
            InitializeComponent();

            rbRequiereStaff.Enabled = true;

            nupPrecio.Minimum = 0;
            nupPrecio.Maximum = 1000000;
            nupPrecio.Increment = 100;

            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.BorderStyle = BorderStyle.None;
            dgvServicios.ReadOnly = true;
            dgvServicios.MultiSelect = false;

            CargaData();

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);
        }
        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }
        private void CargaData()
        {
            dgvServicios.DataSource = gtipos.ListarTiposServicio();
            dgvServicios.Columns["Activo"].Visible = false;
            dgvServicios.Columns["IdTipoServicio"].Visible = false;
        }

        private void LimpiarControles()
        {
            txtDescripcion.Text = string.Empty;
            nupPrecio.Value = 0;
            rbRequiereStaff.Checked = false;
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Completá descripcion antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoServicio tipo = new TipoServicio
            {
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = nupPrecio.Value,
                RequiereStaff = rbRequiereStaff.Checked
            };

            try
            {
                gtipos.AltaTipoServicio(tipo);
                CargaData();
                MessageBox.Show("Tipo registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            t = (TipoServicio)dgvServicios.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirmás dar de baja a {t.Descripcion}?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                gtipos.EliminarTipoServicio(t.IdTipoServicio);
                CargaData();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show("Seleccioná un tipo de la grilla antes de modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Completá descripcion antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoServicio tipo = new TipoServicio
            {
                IdTipoServicio = t.IdTipoServicio,
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = nupPrecio.Value,
                RequiereStaff = rbRequiereStaff.Checked
            };

            try
            {
                gtipos.ModificarTipoServicio(tipo);
                CargaData();
                t = null;
                MessageBox.Show("Tipo modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow == null) return;

            t = (TipoServicio)dgvServicios.CurrentRow.DataBoundItem;
            txtDescripcion.Text = t.Descripcion;
            nupPrecio.Value = t.Precio;
            rbRequiereStaff.Checked = t.RequiereStaff;
            rbRequiereStaff.Enabled = true;
        }
    }
}
