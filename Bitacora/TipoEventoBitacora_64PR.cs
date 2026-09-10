using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora
{
    public enum TipoEventoBitacora_64PR
    {
        LoginExitoso = 1,
        CambioClave = 2,
        LoginFallido = 3,
        UsuarioBloqueado = 4,
        Logout = 5,
        AltaUsuario = 6,
        ModificacionUsuario = 7,
        CreacionRol = 9,
        EliminacionRol = 10,
        ModificacionRol = 11,
        CreacionFamilia = 12,
        EliminacionFamilia = 13,
        ModificacionFamilia = 14,
        Backup = 15,
        Restore = 16
    }
}
