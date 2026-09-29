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
        Restore = 16,
        AltaHabitacion = 17,
        ModificacionHabitacion = 18,
        EliminacionHabitacion = 19,
        AltaHuesped = 20,
        BajaHuesped = 21,
        ModificacionHuesped=22,
        AltaTipoHabitacion=23,
        ModificarTipoHabitacion=24,
        EliminacionTipoHabitacion = 25,
        RegistrarReserva=26,
        RegistrarCheckIn = 27,
        RegistrarCheckOut=28
    }
}
