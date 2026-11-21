using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public partial class FrmContenedor_64PR : Form
    {
        public static FrmContenedor_64PR Instancia { get; private set; }

        public FrmContenedor_64PR()
        {
            InitializeComponent();
            string rutaIcono = Path.Combine(Application.StartupPath, "Imagenes", "solo-logo.ico");
            this.Icon = new Icon(rutaIcono);
            Instancia = this;
            this.WindowState = FormWindowState.Normal;
            MostrarHijo(new FrmLogin_64PR());
            this.Text = "RoomIn";
            this.MinimumSize = new Size(1024, 650);
        }
        public void MostrarHijo(Form hijo)
        {
            /// Cierra el hijo anterior
            foreach (Control c in pnlContenido.Controls)
            {
                if (c is Form f) f.Close();
            }
            pnlContenido.Controls.Clear();

            /// Embebe el nuevo form como control dentro del panel
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(hijo);
            hijo.Show();
        }

        private void FrmContenedor_64PR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Sesion.SessionManager.GetInstance.Usuario != null)
            {
                string loginActual = Sesion.SessionManager.GetInstance.Usuario.Login;
                string idiomaActual = Idioma.GestorIdioma_64PR.GetInstance.IdiomaActual;
                new Sesion.BLL_Usuario().GuardarIdioma(loginActual, idiomaActual);

                Bitacora.Bitacora_64PR bita2 = new Bitacora.Bitacora_64PR();
                Bitacora.Evento_64PR ev2 = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Login).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.Logout).ToString(), 5);
                bita2.RegistrarEvento(ev2);

                Sesion.SessionManager.GetInstance.Logout();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                AbrirAyudaActual();
                return true; // Indicamos que la tecla fue procesada
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AbrirAyudaActual()
        {
            foreach (Control c in pnlContenido.Controls)
            {
                if (c is FrmMenu menu)
                {
                    // Si hay un formulario hijo abierto en el menú (Habitaciones, Huéspedes, etc.)
                    if (menu.formularioactual != null)
                    {
                        PdfAyuda.Abrir(menu.formularioactual.Name);
                    }
                    else
                    {
                        // Si está en el menú principal sin nada abierto
                        PdfAyuda.Abrir(menu.Name);
                    }
                    return;
                }
                else if (c is Form f)
                {
                    // Por ejemplo cuando está en la pantalla de FrmLogin_64PR
                    PdfAyuda.Abrir(f.Name);
                    return;
                }
            }
        }
    }
}
