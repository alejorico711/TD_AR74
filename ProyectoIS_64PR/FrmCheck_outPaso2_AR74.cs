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
    public partial class FrmCheck_outPaso2_AR74 : Form
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva;
        BLL_64PR.BLL_Reservas_AR74 bllReservas = new BLL_64PR.BLL_Reservas_AR74();
        public FrmCheck_outPaso2_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            CargarResumen();
        }
        private void CargarResumen()
        {
            lblHuespedNombre.Text = $"Huésped: {reserva.Huesped.Nombre} {reserva.Huesped.Apellido} (DNI: {reserva.Huesped.DNI})";

            lblHabitacion2.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if (reserva.Habitacion.Descripcion != null)
            {
                lblHabitacion2.Text += ", " + reserva.Habitacion.Descripcion;
            }
            lblFechas2.Text = $"{reserva.FechaInicio:dd/MM/yyyy} --> {reserva.FechaFin:dd/MM/yyyy}";
            lblPersonas2.Text = reserva.CantidadPersonas.ToString();

            int noches = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal precioPorNoche = reserva.Habitacion.Tipo.PrecioPorNoche;
            decimal total = noches * precioPorNoche;

            lblNochesxPrecio2.Text = $"{noches} noches x ${precioPorNoche:N0}";
            lblTotal2.Text = $"${total:N0}";
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            bllReservas.ConfirmarCheckOut(reserva.IdReserva);
            MessageBox.Show("Check-Out confirmado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPadre.AbrirFormularioHijo(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPadre.AbrirFormularioHijo(new FrmCheck_out_AR74(frmPadre));
        }
    }
}
