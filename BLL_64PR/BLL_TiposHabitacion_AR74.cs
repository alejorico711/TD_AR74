using BE;
using System;
using System.Collections.Generic;
using System.Data;
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

        // ── Bitacora de Cambios ──────────────────────────────────────────────

        /// <summary>
        /// Retorna el historial de TipoHabitacion_C, filtrado opcionalmente
        /// por el texto ingresado en el cuadro de búsqueda.
        /// </summary>
        public DataTable ListarBitacoraCambios(string idFiltro)
        {
            return mpp.ListarBitacoraCambios(idFiltro);
        }

        /// <summary>
        /// Activa el registro histórico indicado en TipoHabitacion_C
        /// y sincroniza TipoHabitacion con sus datos.
        /// </summary>
        public void ActivarRegistroBitacora(int idTipoHabitacion, DateTime fecha, TimeSpan hora)
        {
            mpp.ActivarRegistroBitacora(idTipoHabitacion, fecha, hora);
            recalculador.RecalcularTabla("TipoHabitacion");
        }
    }
}
