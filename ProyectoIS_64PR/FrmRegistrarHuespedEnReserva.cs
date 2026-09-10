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
        BLL_64PR.BLL_Huespedes_AR74 bllHuesped = new BLL_64PR.BLL_Huespedes_AR74();
        public BE.Huesped HuespedRegistrado { get; private set; }
        public FrmRegistrarHuespedEnReserva()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BE.Huesped huesped = new BE.Huesped
            {
                DNI = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text
            };

            int idGenerado = bllHuesped.RegistrarHuesped(huesped);
            huesped.IdHuesped = idGenerado;
            HuespedRegistrado = huesped;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
