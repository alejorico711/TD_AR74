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
    public partial class FrmReservaPaso2_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        BLL_64PR.BLL_Habitaciones_AR74 bllHabitaciones = new BLL_64PR.BLL_Habitaciones_AR74();
        Dictionary<string, string> textos;

        public FrmReservaPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            flowLayoutPanelHabitaciones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelHabitaciones.WrapContents = true;
            flowLayoutPanelHabitaciones.AutoScroll = true;

            MostrarHabitaciones();
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

        public void MostrarHabitaciones()
        {
            flowLayoutPanelHabitaciones.Controls.Clear();
            List<BE.Habitacion> habitacionesDisponibles = bllHabitaciones.ListarHabitaciones(reserva.FechaInicio, reserva.FechaFin, reserva.CantidadPersonas);

            if (habitacionesDisponibles.Count == 0)
            {
                Label lblSinResultados = new Label();
                lblSinResultados.ForeColor = Color.Red;
                lblSinResultados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                lblSinResultados.AutoSize = false;
                lblSinResultados.Dock = DockStyle.Fill;
                lblSinResultados.TextAlign = ContentAlignment.MiddleCenter;
                lblSinResultados.Name = "lblSinResultados";


                this.Controls.Add(lblSinResultados);
                lblSinResultados.BringToFront();
                flowLayoutPanelHabitaciones.Visible = false;
                return;
            }

            flowLayoutPanelHabitaciones.Visible = true;

            foreach (var habitacion in habitacionesDisponibles)
            {
                UcCtrlTarjetaHabitacion_AR74 uc = new UcCtrlTarjetaHabitacion_AR74();
                uc.CargarDatos(habitacion);
                uc.Click += Tarjeta_Click;
                uc.AplicarColor(Color.FromArgb(46, 184, 92)); //forzamos el verde, sin importar el estado actual
                flowLayoutPanelHabitaciones.Controls.Add(uc);
            }
        }
        private void Tarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                UcCtrlTarjetaHabitacion_AR74 uc = (UcCtrlTarjetaHabitacion_AR74)sender;
                reserva.Habitacion = uc.HabitacionAsociada;
                frmPadre.AbrirFormularioHijo(new FrmReservaPaso3_AR74(frmPadre, reserva));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
