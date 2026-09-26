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
    public partial class FrmOpcionesComprobante : Form, Idioma.IObservadorIdioma_64PR
    {
        Dictionary<string, string> textos;
        public FrmOpcionesComprobante()
        {
            InitializeComponent();
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

        public enum OpcionElegida { Imprimir, DescargarPdf, Ninguna }
        public OpcionElegida Opcion { get; private set; } = OpcionElegida.Ninguna;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Opcion = OpcionElegida.Imprimir;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            Opcion = OpcionElegida.DescargarPdf;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
