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

        public List<Reserva_AR74> ListarReservasCheckInHoy()
        {
            List<Reserva_AR74> lista = new List<Reserva_AR74>();
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarReservasCheckInHoy", null);

            foreach (DataRow dr in tabla.Rows)
            {
                Reserva_AR74 r = new Reserva_AR74();
                r.IdReserva = (int)dr["IdReserva"];
                r.FechaInicio = (DateTime)dr["FechaCheckIn"];
                r.FechaFin = (DateTime)dr["FechaCheckOut"];
                r.CantidadPersonas = (int)dr["CantidadPersonas"];

                BE.TipoHabitacion tipo = new BE.TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["DescTipoHabitacion"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"]
                };

                r.Habitacion = new BE.Habitacion
                {
                    IdHabitacion = (int)dr["IdHabitacion"],
                    Numero = (int)dr["Numero"],
                    Descripcion = dr["DescHabitacion"] == DBNull.Value ? null : (string)dr["DescHabitacion"],
                    Estado = (string)dr["EstadoHabitacion"],
                    Tipo = tipo
                };

                r.Huesped = new BE.Huesped
                {
                    IdHuesped = (int)dr["IdHuesped"],
                    DNI = (string)dr["Dni"],
                    Nombre = (string)dr["Nombre"],
                    Apellido = (string)dr["Apellido"],
                    FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                    Email = dr["CorreoElectronico"] == DBNull.Value ? null : (string)dr["CorreoElectronico"],
                    Telefono = dr["Telefono"] == DBNull.Value ? null : (string)dr["Telefono"]
                };

                lista.Add(r);
            }
            return lista;
        }

        public void ConfirmarCheckIn(int idReserva)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdReserva", idReserva);
            DAL_64PR.Acceso.Instancia.escribirSP("sp_ConfirmarCheckIn", p);
        }
        public void ConfirmarCheckout(int idReserva)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdReserva", idReserva);
            DAL_64PR.Acceso.Instancia.escribirSP("sp_ConfirmarCheckout", p);
        }

        public List<Reserva_AR74> ListarReservasCheckOutHoy()
        {
            List<Reserva_AR74> lista = new List<Reserva_AR74>();
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarReservasParaCheckout", null);

            foreach (DataRow dr in tabla.Rows)
            {
                Reserva_AR74 r = new Reserva_AR74();
                r.IdReserva = (int)dr["IdReserva"];
                r.FechaInicio = (DateTime)dr["FechaCheckIn"];
                r.FechaFin = (DateTime)dr["FechaCheckOut"];
                r.CantidadPersonas = (int)dr["CantidadPersonas"];

                BE.TipoHabitacion tipo = new BE.TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["DescTipoHabitacion"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"]
                };

                r.Habitacion = new BE.Habitacion
                {
                    IdHabitacion = (int)dr["IdHabitacion"],
                    Numero = (int)dr["Numero"],
                    Descripcion = dr["DescHabitacion"] == DBNull.Value ? null : (string)dr["DescHabitacion"],
                    Estado = (string)dr["EstadoHabitacion"],
                    Tipo = tipo
                };

                r.Huesped = new BE.Huesped
                {
                    IdHuesped = (int)dr["IdHuesped"],
                    DNI = (string)dr["Dni"],
                    Nombre = (string)dr["Nombre"],
                    Apellido = (string)dr["Apellido"],
                    FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                    Email = dr["CorreoElectronico"] == DBNull.Value ? null : (string)dr["CorreoElectronico"],
                    Telefono = dr["Telefono"] == DBNull.Value ? null : (string)dr["Telefono"]
                };

                lista.Add(r);
            }
            return lista;
        }
    }
}
