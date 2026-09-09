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
        public FrmReservaPaso3_AR74(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            cmbHuesped.DropDownStyle = ComboBoxStyle.DropDown; // permite escribir, no solo elegir de la lista
            cmbHuesped.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbHuesped.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbHuesped.DataSource = bllHuesped.ListarHuespedes();
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            frmPadre.AbrirFormularioHijo(new FrmRegistrarHuespedEnReserva(frmPadre, reserva));
        }
    }
}
