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
    public class MPP_SolicitudesServicio_AR74
    {
        public int RegistrarSolicitudServicio(SolicitudServicio solicitud)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@IdReserva", solicitud.Reserva.IdReserva);
            p[1] = new SqlParameter("@IdTipoServicio", solicitud.Servicio.IdTipoServicio);
            p[2] = new SqlParameter("@EstadoPago", solicitud.EstadoPago.ToString());
            p[3] = new SqlParameter("@MetodoPago", (object)solicitud.MetodoPago ?? DBNull.Value);

            p[4] = new SqlParameter("@IdSolicitudGenerada", SqlDbType.Int);
            p[4].Direction = ParameterDirection.Output;

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarSolicitudServicio", p);

            return (int)p[4].Value;
        }
    }
}
