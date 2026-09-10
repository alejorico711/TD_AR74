using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPP_Reservas_AR74
    {
        public int RegistrarReserva(Reserva_AR74 reserva)
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@FechaCheckIn", reserva.FechaInicio);
            p[1] = new SqlParameter("@FechaCheckOut", reserva.FechaFin);
            p[2] = new SqlParameter("@CantidadPersonas", reserva.CantidadPersonas);
            p[3] = new SqlParameter("@IdHabitacion", reserva.Habitacion.IdHabitacion);
            p[4] = new SqlParameter("@IdHuesped", reserva.Huesped.IdHuesped);

            p[5] = new SqlParameter("@IdReservaGenerada", SqlDbType.Int);
            p[5].Direction = ParameterDirection.Output;

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarReserva", p);

            int idGenerado = (int)p[5].Value;
            return idGenerado;
        }
    }
}
