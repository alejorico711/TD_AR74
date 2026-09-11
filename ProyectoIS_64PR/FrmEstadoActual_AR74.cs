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
    public partial class FrmEstadoActual_AR74 : Form
    {
        BLL_64PR.BLL_Habitaciones_AR74 bllHabitaciones = new BLL_64PR.BLL_Habitaciones_AR74();
        public FrmEstadoActual_AR74()
        {
            InitializeComponent();
            flowLayoutPanelHabitaciones.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelHabitaciones.WrapContents = true;
            flowLayoutPanelHabitaciones.AutoScroll = true;
            MostrarReservas();
        }

        private void MostrarReservas()
        {
            flowLayoutPanelHabitaciones.Controls.Clear();
            List<BE.Habitacion> habitaciones = bllHabitaciones.ListarTodasHabitaciones();

            foreach (var habitacion in habitaciones)
            {
                UcCtrlTarjetaHabitacion_AR74 uc = new UcCtrlTarjetaHabitacion_AR74();
                uc.CargarDatos(habitacion);
                flowLayoutPanelHabitaciones.Controls.Add(uc);
            }
        }
    }
}
