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
    public partial class FrmCheck_inPaso2_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;

        public FrmCheck_inPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;

            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);
            CargarResumen();
        }
        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }
        private void CargarResumen()
        {
            lblHuespedNombre.Text = $"Huésped: {reserva.Huesped.Nombre} {reserva.Huesped.Apellido} (DNI: {reserva.Huesped.DNI})";

            lblValorHabitacion.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if (reserva.Habitacion.Descripcion != null)
            {
                lblValorHabitacion.Text += ", " + reserva.Habitacion.Descripcion;
            }
            lblValorFechas.Text = $"{reserva.FechaInicio:dd/MM/yyyy} --> {reserva.FechaFin:dd/MM/yyyy}";
            lblValorPersonas.Text = reserva.CantidadPersonas.ToString();

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;

            lblValorNochesxPrecio.Text = $"{noches} x ${precioPorNoche:N0}";
            lblValorTotal.Text = $"${total:N0}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                bllReservas.ConfirmarCheckIn(reserva.IdReserva);
                MessageBox.Show("Check-In confirmado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPadre.AbrirFormularioHijo(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPadre.AbrirFormularioHijo(new FrmCheck_in_AR74(frmPadre));
        }
    }
}
