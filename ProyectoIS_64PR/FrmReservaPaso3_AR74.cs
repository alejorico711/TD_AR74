using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmReservaPaso3_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        BLL_64PR.BLL_Huespedes_AR74 bllHuesped = new BLL_64PR.BLL_Huespedes_AR74();
        BLL_64PR.BLL_Reservas_AR74 bllReserva = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;
        public FrmReservaPaso3_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            cmbHuesped.DropDownStyle = ComboBoxStyle.DropDown; // permite escribir, no solo elegir de la lista
            cmbHuesped.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbHuesped.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbHuesped.DataSource = bllHuesped.ListarHuespedes();
            cmbHuesped.SelectedIndex = -1;

            string rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "doorway.png");
            pbHabitacion.BackgroundImageLayout = ImageLayout.Zoom;
            pbHabitacion.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "calendar.png");
            pbCalendario.BackgroundImageLayout = ImageLayout.Zoom;
            pbCalendario.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "people.png");
            pbPersonas.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonas.BackgroundImage = Image.FromFile(rutaLogo);

            rutaLogo = Path.Combine(Application.StartupPath, "Imagenes", "crescent-moon.png");
            pbNoches.BackgroundImageLayout = ImageLayout.Zoom;
            pbNoches.BackgroundImage = Image.FromFile(rutaLogo);

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            ActualizarResumen(reserva);
        }
        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            FrmRegistrarHuespedEnReserva frmAlta = new FrmRegistrarHuespedEnReserva();

            // Lo posicionamos y dimensionamos exactamente igual que este formulario para "taparlo"
            // Como este form es un hijo MDI, this.Location es relativo al contenedor MDI.
            // Hay que convertirlo a coordenadas de pantalla para que el diálogo quede bien posicionado.
            frmAlta.StartPosition = FormStartPosition.Manual;
            frmAlta.Size = this.Size;
            frmAlta.Location = this.Parent.PointToScreen(this.Location);

            DialogResult resultado = frmAlta.ShowDialog(this);

            if (resultado == DialogResult.OK)
            {
                BE.Huesped nuevoHuesped = frmAlta.HuespedRegistrado;

                // Recargo el combo para que aparezca el nuevo huésped
                List<BE.Huesped> lst = bllHuesped.ListarHuespedes();
                cmbHuesped.DataSource = lst;

                // Lo dejo ya seleccionado, para no hacer que el recepcionista lo busque de nuevo
                cmbHuesped.SelectedItem = lst.FirstOrDefault(h => h.IdHuesped == nuevoHuesped.IdHuesped);
            }
        }

        private void cmbHuesped_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHuesped.SelectedIndex == -1) return; // evita el disparo "vacío" inicial

            Huesped huespedSeleccionado = (Huesped)cmbHuesped.SelectedItem;
            reserva.Huesped = huespedSeleccionado;
            ActualizarResumen(reserva);
        }

        private void ActualizarResumen(Reserva_AR74 reserva)
        {
            tableLayoutPanel1.Visible = true;
            lblValorHabitacion.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if(reserva.Habitacion.Descripcion != null)
            {
                lblValorHabitacion.Text += ", " + reserva.Habitacion.Descripcion;
            }
            lblValorFechas.Text = $"{reserva.FechaInicio:dd/MM/yyyy} --> {reserva.FechaFin:dd/MM/yyyy}";
            lblValorPersonas.Text = reserva.CantidadPersonas.ToString();

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;

            lblValorNochesxPrecio.Text = $"{noches} noches x ${precioPorNoche:N0}";
            lblValorTotal.Text = $"${total:N0}";
        }

        private void cmbHuesped_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbHuesped.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un huesped");
                    return;
                }
                bllReserva.RegistrarReserva(reserva);
                MessageBox.Show("Reserva registrada con exito");
                frmPadre.AbrirFormularioHijo(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
