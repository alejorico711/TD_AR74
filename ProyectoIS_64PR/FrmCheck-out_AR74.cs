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
    public partial class FrmCheck_out_AR74 : Form,Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;
        public FrmCheck_out_AR74(FrmMenu frmPadre)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            flowLayoutPanelHabitaciones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelHabitaciones.WrapContents = true;
            flowLayoutPanelHabitaciones.AutoScroll = true;
            MostrarReservas();
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
        public void MostrarReservas()
        {
            flowLayoutPanelHabitaciones.Controls.Clear();
            List<BE.Reserva_AR74> reservasHoy = bllReservas.ListarReservasCheckOutHoy();

            if (reservasHoy.Count == 0)
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

            foreach (var reserva in reservasHoy)
            {
                UcCtrlTarjetaHabitacion_AR74 uc = new UcCtrlTarjetaHabitacion_AR74();
                uc.CargarDatos(reserva.Habitacion);
                uc.AplicarColor(Color.FromArgb(230, 90, 60)); //fuerzo el color rojo/naranja
                uc.Tag = reserva;
                uc.Click += Tarjeta_Click;
                flowLayoutPanelHabitaciones.Controls.Add(uc);
            }
        }
        private void Tarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                UcCtrlTarjetaHabitacion_AR74 uc = (UcCtrlTarjetaHabitacion_AR74)sender;
                BE.Reserva_AR74 reserva = (BE.Reserva_AR74)uc.Tag;
                frmPadre.AbrirFormularioHijo(new FrmCheck_outPaso2_AR74(frmPadre, reserva));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
