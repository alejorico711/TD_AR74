using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_TiposHabitacion_AR74
    {
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        Mapper.MPP_TiposHabitacion_AR74 mpp = new Mapper.MPP_TiposHabitacion_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();

        public List<TipoHabitacion> ListarTiposHabitacion()
        {
            return mpp.ListarTiposHabitacion();
        }

        public int RegistrarTipoHabitacion(TipoHabitacion tipo)
        {
            int aux = mpp.RegistrarTipoHabitacion(tipo);
            recalculador.RecalcularTabla("TipoHabitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.AltaTipoHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
            return aux;
        }

        public void ModificarTipoHabitacion(TipoHabitacion tipo)
        {
            mpp.ModificarTipoHabitacion(tipo);
            recalculador.RecalcularTabla("TipoHabitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.ModificarTipoHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
        }

        public void EliminarTipoHabitacion(int idTipoHabitacion)
        {
            mpp.EliminarTipoHabitacion(idTipoHabitacion);
            recalculador.RecalcularTabla("TipoHabitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.EliminacionTipoHabitacion).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
    }
}
