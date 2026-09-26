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
    public partial class FrmReservaPaso1_AR74 : Form, Idioma.IObservadorIdioma_64PR
    {
        FrmMenu frmPadre;
        Reserva_AR74 reserva = new Reserva_AR74();
        Dictionary<string, string> textos;
        public FrmReservaPaso1_AR74(FrmMenu frmPadre)
        {
            InitializeComponent();
            this.frmPadre = frmPadre;
            dtpInicio.MinDate = DateTime.Today + TimeSpan.FromDays(1);
            dtpFin.MinDate = DateTime.Today + TimeSpan.FromDays(2);
            nupCantidad.Minimum = 1;
            nupCantidad.Maximum = 6;
            nupCantidad.Value = 1;
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            reserva.FechaInicio = dtpInicio.Value;
            reserva.FechaFin = dtpFin.Value;
            reserva.CantidadPersonas= (int)nupCantidad.Value;
            frmPadre.AbrirFormularioHijo(new FrmReservaPaso2_AR74(frmPadre, reserva));
        }
    }
}
