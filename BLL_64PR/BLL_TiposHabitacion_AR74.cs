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
        Mapper.MPP_TiposHabitacion_AR74 mpp = new Mapper.MPP_TiposHabitacion_AR74();

        public List<TipoHabitacion> ListarTiposHabitacion()
        {
            return mpp.ListarTiposHabitacion();
        }

        public int RegistrarTipoHabitacion(TipoHabitacion tipo)
        {
            return mpp.RegistrarTipoHabitacion(tipo);
        }

        public void ModificarTipoHabitacion(TipoHabitacion tipo)
        {
            mpp.ModificarTipoHabitacion(tipo);
        }

        public void EliminarTipoHabitacion(int idTipoHabitacion)
        {
            mpp.EliminarTipoHabitacion(idTipoHabitacion);
        }
    }
}
