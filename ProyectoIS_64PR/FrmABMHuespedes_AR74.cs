using BE;
using Sesion;
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
    public partial class FrmABMHuespedes_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        List<Huesped> lst = new List<Huesped>();
        BLL_64PR.BLL_Huespedes_AR74 ghuepedes = new BLL_64PR.BLL_Huespedes_AR74();
        BE.Huesped h;
        Dictionary<string, string> textos;
        public FrmABMHuespedes_AR74()
        {
            InitializeComponent();
            dgvHuepedes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHuepedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHuepedes.BackgroundColor = SystemColors.Menu;
            dgvHuepedes.BorderStyle = BorderStyle.None;
            dgvHuepedes.ReadOnly = true;
            dgvHuepedes.MultiSelect = false;
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
            dgvHuepedes.DataSource = null;
            lst = ghuepedes.ListarHuespedes();
            dgvHuepedes.DataSource = lst;
            LimpiarControles();
        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (h == null)
            {
                MessageBox.Show("Seleccioná un huésped de la grilla antes de modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Completá DNI, Nombre y Apellido antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Huesped huespedModificado = new Huesped
            {
                IdHuesped = h.IdHuesped,
                DNI = txtDni.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
            };

            try
            {
                ghuepedes.ModificarHuesped(huespedModificado);
                CargaData();
                h = null;
                MessageBox.Show("Huésped modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe otro huésped registrado con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            h = (Huesped)dgvHuepedes.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirmás dar de baja a {h.Nombre} {h.Apellido}?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                ghuepedes.EliminarHuesped(h.IdHuesped);
                CargaData();
            }
        }

        private void dgvHuepedes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHuepedes.CurrentRow == null) return;

            h = (Huesped)dgvHuepedes.CurrentRow.DataBoundItem;
            txtDni.Text = h.DNI;
            txtNombre.Text = h.Nombre;
            txtApellido.Text = h.Apellido;
            dtpFechaNacimiento.Value = h.FechaNacimiento;
            txtEmail.Text = h.Email;
            txtTelefono.Text = h.Telefono;
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Completá DNI, Nombre y Apellido antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Huesped nuevoHuesped = new Huesped
            {
                DNI = txtDni.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
            };

            try
            {
                ghuepedes.RegistrarHuesped(nuevoHuesped);
                CargaData();
                MessageBox.Show("Huésped registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe un huésped registrado con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarControles()
        {
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Today;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
