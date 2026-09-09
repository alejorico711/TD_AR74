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
    public partial class FrmRegistrarHuespedEnReserva : Form
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        public FrmRegistrarHuespedEnReserva(FrmMenu frmPadre, Reserva_AR74 reserva)
        {
            this.frmPadre = frmPadre;
            this.reserva = reserva;
            InitializeComponent();
        }
    }
}
