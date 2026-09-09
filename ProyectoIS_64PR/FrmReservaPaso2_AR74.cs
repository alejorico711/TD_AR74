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
    public partial class FrmReservaPaso2_AR74 : Form
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        BLL_64PR.BLL_Habitaciones_AR74 bllHabitaciones = new BLL_64PR.BLL_Habitaciones_AR74();

        public FrmReservaPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            flowLayoutPanelHabitaciones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelHabitaciones.WrapContents = true;
            flowLayoutPanelHabitaciones.AutoScroll = true;

            MostrarHabitaciones();
        }

        public void MostrarHabitaciones()
        {
            List<BE.Habitacion> habitacionesDisponibles = bllHabitaciones.ListarHabitaciones(reserva.FechaInicio, reserva.FechaFin, reserva.CantidadPersonas);
            foreach (var habitacion in habitacionesDisponibles)
            {
                UcCtrlTarjetaHabitacion_AR74 uc = new UcCtrlTarjetaHabitacion_AR74();
                uc.CargarDatos(habitacion);
                uc.Click += Tarjeta_Click;
                flowLayoutPanelHabitaciones.Controls.Add(uc);
            }
        }
        private void Tarjeta_Click(object sender, EventArgs e)
        {
            UcCtrlTarjetaHabitacion_AR74 uc = (UcCtrlTarjetaHabitacion_AR74)sender;
            reserva.Habitacion = uc.HabitacionAsociada;
            frmPadre.AbrirFormularioHijo(new FrmReservaPaso3_AR74(frmPadre, reserva));
        }
    }
}
