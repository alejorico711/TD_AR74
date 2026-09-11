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
    public partial class UcCtrlTarjetaHabitacion_AR74 : UserControl
    {
        public BE.Habitacion HabitacionAsociada { get; private set; }
        public UcCtrlTarjetaHabitacion_AR74()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.Click += (s, e) => this.OnClick(EventArgs.Empty);
            }
        }

        public void CargarDatos(BE.Habitacion habitacion)
        {
            HabitacionAsociada = habitacion;
            lblCantidad.Text = habitacion.Tipo.Capacidad.ToString();
            lblNumero.Text = habitacion.Numero.ToString(); 
            lblTipo.Text = habitacion.Tipo.Descripcion; 

            Color colorFondo = ObtenerColorPorEstado(habitacion.Estado);
            AplicarColor(colorFondo);
        }
        private Color ObtenerColorPorEstado(string estado)
        {
            switch (estado)
            {
                case "Disponible": return Color.FromArgb(46, 184, 92);     // verde
                case "Ocupada": return Color.FromArgb(230, 90, 60);        // rojo/naranja
                case "Mantenimiento": return Color.FromArgb(150, 150, 150); // gris
                default: return Color.Gray;
            }
        }

        public void AplicarColor(Color color)
        {
            this.BackColor = color;
            foreach (Control control in this.Controls)
            {
                control.BackColor = color;
            }
        }
    }
}
