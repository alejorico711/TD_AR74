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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

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

            txtDni.MaxLength = 8;
            txtNombre.MaxLength = 50;
            txtApellido.MaxLength = 50;

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
            dgvHuepedes.Columns["Activo"].Visible = false;
            dgvHuepedes.Columns["IdHuesped"].Visible = false;
        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (h == null)
            {
                MessageBox.Show(textos["msgNoHuesped"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool banderaEmail= false;
            if (Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") || string.IsNullOrEmpty(txtEmail.Text))
            {
                banderaEmail = true;
            }
            bool banderaTelefono = false;
            if (Regex.IsMatch(txtTelefono.Text, @"^([0-9]{10}|[0-9]{8})$") || string.IsNullOrEmpty(txtTelefono.Text))
            {
                banderaTelefono = true;
            }

            if (txtDni.Text.Length < 7 || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || !banderaEmail || !banderaTelefono)
            {
                MessageBox.Show(textos["msgCompletarCampos"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(textos["msgHuespedModificado"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(textos["msgDNIRepetido"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            h = (Huesped)dgvHuepedes.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(textos["msgBajaHuesped"] + h.Nombre + h.Apellido + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                ghuepedes.EliminarHuesped(h.IdHuesped);
                CargaData();
            }
        }

        private void dgvHuepedes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHuepedes.CurrentRow == null || !(dgvHuepedes.CurrentRow.DataBoundItem is Huesped huespedSeleccionado)) return;

            h = huespedSeleccionado;
            txtDni.Text = h.DNI;
            txtNombre.Text = h.Nombre;
            txtApellido.Text = h.Apellido;
            if (h.FechaNacimiento >= dtpFechaNacimiento.MinDate && h.FechaNacimiento <= dtpFechaNacimiento.MaxDate)
            {
                dtpFechaNacimiento.Value = h.FechaNacimiento;
            }
            else
            {
                dtpFechaNacimiento.Value = DateTime.Today;
            }
            txtEmail.Text = h.Email;
            txtTelefono.Text = h.Telefono;
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length < 7 || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") && string.IsNullOrEmpty(txtEmail.Text)) || (!Regex.IsMatch(txtTelefono.Text, @"^([0-9]{10}|[0-9]{8})$") && string.IsNullOrEmpty(txtTelefono.Text)))
            {
                MessageBox.Show(textos["msgCompletarCampos"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(textos["msgAltaHuesped"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(textos["msgDNIRepetido"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si NO es un número y NO es la tecla de borrar (BackSpace)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si NO es una letra y NO es la tecla de borrar (BackSpace)
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento (el carácter no se escribe)
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si NO es una letra y NO es la tecla de borrar (BackSpace)
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento (el carácter no se escribe)
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si NO es un número y NO es la tecla de borrar (BackSpace)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento
            }
        }
        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            List<Huesped> listaHuespedes = dgvHuepedes.DataSource as List<Huesped>;
            if (listaHuespedes == null && dgvHuepedes.DataSource is IEnumerable<Huesped> enumerable)
            {
                listaHuespedes = enumerable.ToList();
            }

            if (listaHuespedes == null || listaHuespedes.Count == 0)
            {
                MessageBox.Show(textos["NoHuespedes"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.DefaultExt = "xml";
                sfd.AddExtension = true;
                sfd.FileName = "Huespedes.xml";
                sfd.Title = "Guardar huéspedes en formato XML";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Huesped>));
                        using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            serializer.Serialize(writer, listaHuespedes);
                        }

                        MessageBox.Show(textos["XMLOK"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al serializar los datos: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.DefaultExt = "xml";
                ofd.Title = "Seleccionar archivo XML de huéspedes";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Huesped>));
                        List<Huesped> listaDeserializada;
                        using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.UTF8))
                        {
                            listaDeserializada = (List<Huesped>)serializer.Deserialize(reader);
                        }

                        if (listaDeserializada != null)
                        {
                            lst = listaDeserializada;
                            dgvHuepedes.DataSource = null;
                            dgvHuepedes.DataSource = lst;
                            LimpiarControles();

                            if (dgvHuepedes.Columns["Activo"] != null)
                                dgvHuepedes.Columns["Activo"].Visible = false;
                            if (dgvHuepedes.Columns["IdHuesped"] != null)
                                dgvHuepedes.Columns["IdHuesped"].Visible = false;

                            if (textos != null && textos.Count > 0)
                            {
                                ActualizarIdioma(textos);
                            }

                            MessageBox.Show(textos["DESXMLOK"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
