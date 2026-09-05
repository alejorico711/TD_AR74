using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    public static class Traductor_64PR
    {
        public static void Traducir(Form form, Dictionary<string, string> textos)
        {
            var clavesFaltantes = new List<string>();

            foreach (var control in form.Controls)
            {
                if (control is Button btn)
                {
                    if (textos.ContainsKey(form.Name + "." + btn.Name))
                    {
                        btn.Text = textos[form.Name + "." + btn.Name];
                    }
                    else
                    {
                        btn.Text = "FALTA TRADUCCION";
                        clavesFaltantes.Add(form.Name + "." + btn.Name);
                    }
                }

                if (control is Label lbl)
                {
                    if (textos.ContainsKey(form.Name + "." + lbl.Name))
                    {
                        lbl.Text = textos[form.Name + "." + lbl.Name];
                    }
                    else
                    {
                        lbl.Text = "FALTA TRADUCCION";
                        clavesFaltantes.Add(form.Name + "." + lbl.Name);
                    }
                }

                if (control is MenuStrip menu)
                {
                    foreach (ToolStripMenuItem item in menu.Items)
                    {
                        if (textos.ContainsKey(form.Name + "." + item.Name))
                        {
                            item.Text = textos[form.Name + "." + item.Name];
                        }
                        else
                        {
                            // item.Text = "FALTA TRADUCCION";
                            clavesFaltantes.Add(form.Name + "." + item.Name);
                        }
                    }

                    foreach (ToolStripMenuItem item in menu.Items)
                    {
                        foreach (ToolStripMenuItem subItem in item.DropDownItems)
                        {
                            if (textos.ContainsKey(form.Name + "." + subItem.Name))
                            {
                                subItem.Text = textos[form.Name + "." + subItem.Name];
                            }
                            else
                            {
                                //subItem.Text = "FALTA TRADUCCION";
                                clavesFaltantes.Add(form.Name + "." + subItem.Name);
                            }
                        }
                    }
                }
            }
            if (clavesFaltantes.Count > 0)
                Idioma.GestorIdioma_64PR.GetInstance.RegistrarClavesFaltantes(clavesFaltantes);
        }
    }
}
