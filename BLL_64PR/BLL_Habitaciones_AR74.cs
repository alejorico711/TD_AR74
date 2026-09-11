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
        Mapper.MPP_Habitaciones_AR74 mpp = new Mapper.MPP_Habitaciones_AR74();
        public List<BE.Habitacion> ListarHabitaciones(DateTime fechaInicio, DateTime fechaFin, int capacidad)
        {
            return mpp.ListarHabitaciones(fechaInicio, fechaFin, capacidad);
        }

        public List<Habitacion> ListarTodasHabitaciones()
        {
            return mpp.ListarTodasHabitaciones();
        }
    }
}
