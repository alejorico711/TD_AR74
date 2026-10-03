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
    public partial class FrmTareasPendientes_AR74 : Form
    {
        List<TareaPendiente> lst = new List<TareaPendiente>();
        BLL_64PR.BLL_TareasStaff_AR74 bllTareas = new BLL_64PR.BLL_TareasStaff_AR74();
        TareaPendiente tareaSeleccionada;
        public FrmTareasPendientes_AR74()
        {
            InitializeComponent();
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTareas.ReadOnly = true;
            dgvTareas.MultiSelect = false;
            CargaData();
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
                MessageBox.Show("Seleccioná una tarea de la grilla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
