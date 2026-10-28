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
    public partial class FrmVerReservas_AR74 : Form,Idioma.IObservadorIdioma_64PR
    {
        BLL_64PR.BLL_Reservas_AR74 greservas = new BLL_64PR.BLL_Reservas_AR74();
        Dictionary<string, string> textos;
        public FrmVerReservas_AR74()
        {
            InitializeComponent();
            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this);

            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.RowHeadersVisible = false;
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.ReadOnly = true;
            dgvReservas.BackgroundColor = Color.White;
            dgvReservas.BorderStyle = BorderStyle.None;
            dgvReservas.MultiSelect = false;

            CargaData();

            var textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            this.Resize += FrmVerReservas_AR74_Resize;
            CentrarPanel();
        }

        private void FrmVerReservas_AR74_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        public void ActualizarIdioma(Dictionary<string, string> textoss)
        {
            textos = textoss;
            Traductor_64PR.Traducir(this, textos);
        }

        private void CargaData()
        {
            List<Reserva_AR74> aux = greservas.ListarReservas();
            dgvReservas.DataSource = aux.OrderBy(r=>r.FechaInicio).ToList();
        }
    }
}
