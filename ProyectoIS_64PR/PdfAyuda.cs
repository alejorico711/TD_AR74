using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ProyectoIS_64PR
{
    /// <summary>
    /// Clase helper para abrir el manual de ayuda en PDF en la sección correspondiente a cada formulario.
    /// Agrega una entrada en el diccionario <see cref="_secciones"/> por cada formulario que tenga botón de ayuda.
    /// </summary>
    //internal static class PdfAyuda
    //{
    //    private const string NombreArchivo = "Manual_Ayuda_RoomIn_editado.pdf";
    //    private const string CarpetaAyuda  = "Ayuda";

    //    /// Mapeo nombre-de-formulario → marcador (bookmark) interno del PDF.
    //    /// El marcador debe coincidir exactamente con el que tiene el PDF (sin espacios al inicio/fin).
    //    private static readonly Dictionary<string, string> _secciones =
    //        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    //    {
    //        { "FrmLogin_64PR",              "inicio-de-sesion"       },
    //        { "FrmMenu",                    "menu-principal"         },
    //        { "FrmABMHabitaciones_AR74",    "gestion-habitaciones"   },
    //        { "FrmABMHuespedes_AR74",       "gestion-huespedes"      },
    //        { "FrmABMTiposHabitaciones_AR74","tipos-de-habitaciones" },
    //        { "FrmABMTiposServicios_AR74",  "tipos-de-servicios"     },
    //        { "FrmVerReservas_AR74",        "ver-reservas"           },
    //        { "FrmReservaPaso1_AR74",       "nueva-reserva"          },
    //        { "FrmReservaPaso2_AR74",       "nueva-reserva"          },
    //        { "FrmReservaPaso3_AR74",       "nueva-reserva"          },
    //        { "FrmCheck-in_AR74",           "check-in"               },
    //        { "FrmCheck_inPaso2_AR74",      "check-in"               },
    //        { "FrmCheck-out_AR74",          "check-out"              },
    //        { "FrmCheck_outPaso2_AR74",     "check-out"              },
    //        { "FrmEstadoActual_AR74",       "estado-actual"          },
    //        { "FrmSolicitudServicioPaso1",  "solicitud-de-servicios" },
    //        { "FrmSolicitudServicioPaso2",  "solicitud-de-servicios" },
    //        { "FrmGestionarUsuarios_64PR",  "gestion-de-usuarios"    },
    //        { "FrmGestionarRoles_64PR",     "gestion-de-roles"       },
    //        { "FrmGestionFamilias_64PR",    "gestion-de-familias"    },
    //        { "FrmCambiarClave_64PR",       "cambio-de-contrasena"   },
    //        { "FrmBitacora_64PR",           "bitacora"               },
    //        { "FrmTareasPendientes_AR74",   "tareas-pendientes"      },
    //        { "FrmBitacoraCambios",         "bitacora-cambios"       },
    //        { "FrmRegistrarHuespedEnReserva","registrar-huesped-reserva"      },
    //        { "FrmReparacionDV_64PR",         "reparacion-dv"       },
    //    };

    //    /// Abre el manual de ayuda en la sección correspondiente al formulario indicado.
    //    /// Si el formulario no tiene sección mapeada, abre el PDF en la primera página.
    //    /// <param name="nombreFormulario">Valor de <c>this.Name</c> del formulario.</param>
    //    public static void Abrir(string nombreFormulario)
    //    {
    //        string rutaPdf = Path.Combine(
    //            AppDomain.CurrentDomain.BaseDirectory,
    //            CarpetaAyuda,
    //            NombreArchivo);

    //        if (!File.Exists(rutaPdf))
    //        {
    //            MessageBox.Show(
    //                "No se encontró el archivo de ayuda:\n" + rutaPdf,
    //                "Ayuda",
    //                MessageBoxButtons.OK,
    //                MessageBoxIcon.Warning);
    //            return;
    //        }

    //        string marcador = _secciones.TryGetValue(nombreFormulario, out string sec) ? sec : string.Empty;

    //        // Construimos la URL tipo file:/// con el fragmento del bookmark
    //        string url = "file:///" + rutaPdf.Replace('\\', '/');
    //        if (!string.IsNullOrEmpty(marcador))
    //            url += "#" + marcador;

    //        try
    //        {
    //            Process.Start(new ProcessStartInfo
    //            {
    //                FileName        = url,
    //                UseShellExecute = true   // deja que Windows elija el visor/navegador predeterminado
    //            });
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(
    //                "No se pudo abrir el manual de ayuda.\n" + ex.Message,
    //                "Ayuda",
    //                MessageBoxButtons.OK,
    //                MessageBoxIcon.Error);
    //        }
    //    }
    //}

    internal static class PdfAyuda
    {
        private const string NombreArchivo = "Manual_Ayuda_RoomIn_editado.pdf";
        private const string CarpetaAyuda = "Ayuda";

        /// Mapeo nombre-de-formulario → número de página exacto del PDF.
        private static readonly Dictionary<string, int> _paginas =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
        { "FrmLogin_64PR",               3  },
        { "FrmCambiarClave_64PR",        4  },
        { "FrmMenu",                     5  },
        { "FrmEstadoActual_AR74",        5  },
        { "FrmReservaPaso1_AR74",        6  },
        { "FrmReservaPaso2_AR74",        6  },
        { "FrmReservaPaso3_AR74",        7  },
        { "FrmVerReservas_AR74",         7  },
        { "FrmCheck-in_AR74",            8  },
        { "FrmCheck_inPaso2_AR74",       8  },
        { "FrmCheck-out_AR74",           10 },
        { "FrmCheck_outPaso2_AR74",      10 },
        { "FrmSolicitudServicioPaso1",   12 },
        { "FrmSolicitudServicioPaso2",   12 },
        { "FrmTareasPendientes_AR74",    13 },
        { "FrmABMHuespedes_AR74",        14 },
        { "FrmABMHabitaciones_AR74",     16 },
        { "FrmABMTiposHabitaciones_AR74",16 },
        { "FrmABMTiposServicios_AR74",   17 },
        { "FrmGestionarUsuarios_64PR",   19 },
        { "FrmGestionarRoles_64PR",      20 },
        { "FrmGestionFamilias_64PR",     21 },
        { "FrmBitacora_64PR",            23 },
        { "FrmBitacoraCambios",          17 },
        { "FrmRegistrarHuespedEnReserva",7  },
        { "FrmReparacionDV_64PR",        25 },
        };

        public static void Abrir(string nombreFormulario)
        {
            string rutaPdf = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                CarpetaAyuda,
                NombreArchivo);

            if (!File.Exists(rutaPdf))
            {
                MessageBox.Show(
                    "No se encontró el archivo de ayuda:\n" + rutaPdf,
                    "Ayuda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int pagina = _paginas.TryGetValue(nombreFormulario, out int pag) ? pag : 1;
            string url = new Uri(rutaPdf).AbsoluteUri + "#page=" + pagina;

            try
            {
                // Forzamos a Edge a abrir la URL
                Process.Start(new ProcessStartInfo
                {
                    FileName = "msedge.exe",
                    Arguments = $"\"{url}\"",
                    UseShellExecute = true
                });
            }
            catch
            {
                // Fallback por si el usuario no tiene Edge
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
    }
}
