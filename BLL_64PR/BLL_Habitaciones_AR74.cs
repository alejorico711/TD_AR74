using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_Habitaciones_AR74
    {
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();
        Mapper.MPP_Habitaciones_AR74 mpp = new Mapper.MPP_Habitaciones_AR74();
        public List<BE.Habitacion> ListarHabitaciones(DateTime fechaInicio, DateTime fechaFin, int capacidad)
        {
            return mpp.ListarHabitaciones(fechaInicio, fechaFin, capacidad);
        }

        public List<Habitacion> ListarTodasHabitaciones()
        {
            return mpp.ListarTodasHabitaciones();
        }
        public int RegistrarHabitacion(Habitacion habitacion)
        {
            int aux = mpp.RegistrarHabitacion(habitacion);
            recalculador.RecalcularTabla("Habitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.AltaHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
            return aux;
        }

        public void ModificarHabitacion(Habitacion habitacion)
        {
            mpp.ModificarHabitacion(habitacion);
            recalculador.RecalcularTabla("Habitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.ModificacionHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
        }

        public void EliminarHabitacion(int idHabitacion)
        {
            mpp.EliminarHabitacion(idHabitacion);
            recalculador.RecalcularTabla("Habitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.EliminacionHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
    }
}
