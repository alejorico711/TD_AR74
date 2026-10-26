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
    public partial class FrmABMHabitaciones_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        List<Habitacion> lst = new List<Habitacion>();
        BLL_64PR.BLL_Habitaciones_AR74 ghabitaciones = new BLL_64PR.BLL_Habitaciones_AR74();
        BLL_64PR.BLL_TiposHabitacion_AR74 gtipos = new BLL_64PR.BLL_TiposHabitacion_AR74();
        BE.Habitacion hab;


        Dictionary<string, string> textos;
        public FrmABMHabitaciones_AR74()
        {
            InitializeComponent();
            nupNumero.Minimum = 1;
            nupNumero.Maximum = 9999;
            txtDescripcion.MaxLength = 100;

            dgvHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabitaciones.RowHeadersVisible = false;
            dgvHabitaciones.AllowUserToAddRows = false;
            dgvHabitaciones.BackgroundColor = Color.White;
            dgvHabitaciones.BorderStyle = BorderStyle.None;
            dgvHabitaciones.ReadOnly = true;
            dgvHabitaciones.MultiSelect = false;

            CargarTipos();
            CargaData();

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            this.Resize += FrmABMHabitaciones_AR74_Resize;
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

        private void FrmABMHabitaciones_AR74_Resize(object sender, EventArgs e)
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
            dgvHabitaciones.DataSource = null;
            lst = ghabitaciones.ListarTodasHabitaciones();
            dgvHabitaciones.DataSource = lst;

            dgvHabitaciones.Columns["Activo"].Visible = false;
            dgvHabitaciones.Columns["IdHabitacion"].Visible = false;

            LimpiarControles();
        }
        private void CargarTipos()
        {
            cmbTipoHabitacion.DataSource = gtipos.ListarTiposHabitacion();
            cmbTipoHabitacion.DisplayMember = "Descripcion";
            cmbTipoHabitacion.ValueMember = "IdTipoHabitacion";
        }
        private void LimpiarControles()
        {
            nupNumero.Value = 1;
            txtDescripcion.Text = string.Empty;
            if (cmbTipoHabitacion.Items.Count > 0)
                cmbTipoHabitacion.SelectedIndex = -1;
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            if (cmbTipoHabitacion.SelectedValue == null)
            {
                MessageBox.Show(textos["msgNoTipoHabitacion"],"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Habitacion nuevaHabitacion = new Habitacion
            {
                Numero = (int)nupNumero.Value,
                Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim(),
                Tipo = (TipoHabitacion)cmbTipoHabitacion.SelectedItem
            };

            try
            {
                ghabitaciones.RegistrarHabitacion(nuevaHabitacion);
                CargaData();
                MessageBox.Show(textos["msgHabitacionRegistrada"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(textos["msgNumeroRepetido"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            hab = (Habitacion)dgvHabitaciones.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(textos["msgBajaHabitacion"] + hab.Numero.ToString() + "?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                ghabitaciones.EliminarHabitacion(hab.IdHabitacion);
                CargaData();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (hab == null)
            {
                MessageBox.Show(textos["msgHabitacionAModificar"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipoHabitacion.SelectedValue == null)
            {
                MessageBox.Show(textos["msgNoTipoHabitacion"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Habitacion habitacionModificada = new Habitacion
            {
                IdHabitacion = hab.IdHabitacion,
                Numero = (int)nupNumero.Value,
                Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim(),
                Tipo = (TipoHabitacion)cmbTipoHabitacion.SelectedItem
            };

            try
            {
                ghabitaciones.ModificarHabitacion(habitacionModificada);
                CargaData();
                hab = null;
                MessageBox.Show(textos["msgHabitacionModificada"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(textos["msgNumeroRepetido"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow == null) return;

            hab = (Habitacion)dgvHabitaciones.CurrentRow.DataBoundItem;
            nupNumero.Value = hab.Numero;
            txtDescripcion.Text = hab.Descripcion;
            cmbTipoHabitacion.SelectedValue = hab.Tipo.IdTipoHabitacion;
        }
    }
}
