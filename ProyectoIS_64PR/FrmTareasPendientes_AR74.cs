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
    public partial class FrmTareasPendientes_AR74 : Form,Idioma.IObservadorIdioma_64PR
    {
        List<TareaPendiente> lst = new List<TareaPendiente>();
        BLL_64PR.BLL_TareasStaff_AR74 bllTareas = new BLL_64PR.BLL_TareasStaff_AR74();
        TareaPendiente tareaSeleccionada;
        Dictionary<string, string> textos;
        public FrmTareasPendientes_AR74()
        {
            InitializeComponent();
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.BackgroundColor = Color.White;
            dgvTareas.BorderStyle = BorderStyle.None;
            dgvTareas.ReadOnly = true;
            dgvTareas.MultiSelect = false;
            CargaData();
            Idioma.GestorIdioma_64PR.GetInstance.Suscribir(this); ///observer del cambio de idioma
                                                                  ///Aplico el idioma que ya está cargado
            textos = Idioma.GestorIdioma_64PR.GetInstance.ObtenerTextos();
            if (textos.Count > 0)
                ActualizarIdioma(textos);

            this.Resize += FrmTareasPendientes_AR74_Resize;
            CentrarPanel();
        }

        private void FrmTareasPendientes_AR74_Resize(object sender, EventArgs e)
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
            dgvTareas.DataSource = null;
            lst = bllTareas.ListarTareasPendientes();
            dgvTareas.DataSource = lst;

            dgvTareas.Columns["IdReferencia"].Visible = false;

            tareaSeleccionada = null;
        }
        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show(textos["msgSeleccionarTarea"], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bllTareas.FinalizarTarea(tareaSeleccionada);
            CargaData();
        }

        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTareas.CurrentRow == null) return;
            tareaSeleccionada = (TareaPendiente)dgvTareas.CurrentRow.DataBoundItem;
        }
    }
}
