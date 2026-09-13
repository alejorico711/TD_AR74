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
    public partial class FrmOpcionesComprobante : Form
    {
        public FrmOpcionesComprobante()
        {
            InitializeComponent();
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
