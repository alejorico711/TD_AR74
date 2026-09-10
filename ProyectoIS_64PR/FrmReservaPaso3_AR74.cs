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
    public partial class FrmReservaPaso3_AR74 : Form
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        BLL_64PR.BLL_Huespedes_AR74 bllHuesped = new BLL_64PR.BLL_Huespedes_AR74();
        BLL_64PR.BLL_Reservas_AR74 bllReserva = new BLL_64PR.BLL_Reservas_AR74();
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
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            FrmRegistrarHuespedEnReserva frmAlta = new FrmRegistrarHuespedEnReserva();
            DialogResult resultado = frmAlta.ShowDialog();

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
            lblHabitacion2.Text = $"Nro {reserva.Habitacion.Numero} - {reserva.Habitacion.Tipo.Descripcion}";
            if(reserva.Habitacion.Descripcion != null)
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

        private void cmbHuesped_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            bllReserva.RegistrarReserva(reserva);
        }
    }
}
