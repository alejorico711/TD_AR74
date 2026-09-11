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
    public partial class FrmCheck_in_AR74 : Form
    {
        FrmMenu frmPadre;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();

        public FrmCheck_in_AR74(FrmMenu frmPadre)
        {
            this.frmPadre = frmPadre;
            InitializeComponent();
            flowLayoutPanelHabitaciones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelHabitaciones.WrapContents = true;
            flowLayoutPanelHabitaciones.AutoScroll = true;
            MostrarReservas();
        }

        public void MostrarReservas()
        {
            List<BE.Reserva_AR74> reservasHoy = bllReservas.ListarReservasCheckInHoy();
            foreach (var reserva in reservasHoy)
            {
                UcCtrlTarjetaHabitacion_AR74 uc = new UcCtrlTarjetaHabitacion_AR74();
                uc.CargarDatos(reserva.Habitacion);
                uc.AplicarColor(Color.FromArgb(46, 184, 92)); //fuerzo el color verde
                uc.Tag = reserva;
                uc.Click += Tarjeta_Click;
                flowLayoutPanelHabitaciones.Controls.Add(uc);
            }
        }

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            UcCtrlTarjetaHabitacion_AR74 uc = (UcCtrlTarjetaHabitacion_AR74)sender;
            BE.Reserva_AR74 reserva = (BE.Reserva_AR74)uc.Tag;
            frmPadre.AbrirFormularioHijo(new FrmCheck_inPaso2_AR74(frmPadre, reserva));
        }
    }
}
