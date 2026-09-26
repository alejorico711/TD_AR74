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
    public partial class FrmRegistrarHuespedEnReserva : Form,Idioma.IObservadorIdioma_64PR
    {
        BLL_64PR.BLL_Huespedes_AR74 bllHuesped = new BLL_64PR.BLL_Huespedes_AR74();
        public BE.Huesped HuespedRegistrado { get; private set; }
        Dictionary<string, string> textos;
        public FrmRegistrarHuespedEnReserva()
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
