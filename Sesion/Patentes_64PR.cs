using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    public enum Patentes_64PR
    {
        ///esta clase contiene unicamente los "identificadores" para las patentes (se utilizo el nombre patente y no permiso, para diferenciarlas aunque sean sinonimos)
        ///se hace con el objetivo de no usar strings en crudo, y si en la base de datos se modifica una patente, esa
        ///patente se cambie una sola vez aqui. Cabe resaltar que el valor de la constante debe coincidir EXACTAMENTE con la BD

         CrearUsuario = 1,
         DesbloquearUsuario = 2,
         ModificarUsuario = 3,
         ActivarDesactivarUsuarios = 4,
         Bitacora = 5,
         CrearRoles = 6,
         ModificarRoles = 7,
         EliminarRoles = 8,
         CrearFamilias = 9,
         ModificarFamilias = 10,
         EliminarFamilias = 11,
         RepararIntegridadDV = 12,
         CambiarContra = 13,
         CambiarIdioma = 14,
         Respaldos = 16,
         Restauraciones = 17,
         Reserva = 18,
         CheckIn = 19,
         CheckOut = 20,
         ABMHuespedes = 22,
         ABMHabitaciones = 23,
         ABMTipoHabitaciones = 24,
         EstadoActual = 25,
         TareasPendientes = 26,
         RegistrarServiciosAdicionales = 27,
        BitacoraDeCambios = 28,
        ABMTipoServicios = 29
    }
}
