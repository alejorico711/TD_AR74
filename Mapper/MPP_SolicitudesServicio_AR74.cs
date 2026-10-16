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
        public List<SolicitudServicio> ListarServiciosPendientesStaff()
        {
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarServiciosPendientesStaff", null);
            List<SolicitudServicio> lista = new List<SolicitudServicio>();

            foreach (DataRow dr in tabla.Rows)
            {
                lista.Add(new SolicitudServicio
                {
                    IdSolicitud = (int)dr["IdSolicitud"],
                    FechaHoraSolicitud = (DateTime)dr["FechaHoraSolicitud"],
                    Servicio = new TipoServicio
                    {
                        IdTipoServicio = (int)dr["IdTipoServicio"],
                        Descripcion = (string)dr["DescripcionServicio"]
                    },
                    Reserva = new Reserva_AR74
                    {
                        IdReserva = (int)dr["IdReserva"],
                        Habitacion = new Habitacion
                        {
                            IdHabitacion = (int)dr["IdHabitacion"],
                            Numero = (int)dr["Numero"]
                        }
                    }
                });
            }
            return lista;
        }

        public void FinalizarServicio(int idSolicitud)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdSolicitud", idSolicitud);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_FinalizarServicio", p);
        }
        public List<SolicitudServicio> ListarServiciosPendientesDePago(int idReserva)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdReserva", idReserva);

            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarServiciosPendientesDePago", p);
            List<SolicitudServicio> lista = new List<SolicitudServicio>();

            foreach (DataRow dr in tabla.Rows)
            {
                lista.Add(new SolicitudServicio
                {
                    IdSolicitud = (int)dr["IdSolicitud"],
                    FechaHoraSolicitud = (DateTime)dr["FechaHoraSolicitud"],
                    Precio = (decimal)dr["Precio"],
                    Servicio = new TipoServicio
                    {
                        IdTipoServicio = (int)dr["IdTipoServicio"],
                        Descripcion = (string)dr["DescripcionServicio"]
                    }
                });
            }
            return lista;
        }
    }
}
