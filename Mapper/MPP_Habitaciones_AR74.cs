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
    public class MPP_Habitaciones_AR74
    {
        public List<Habitacion> ListarHabitaciones(DateTime fechaInicio, DateTime fechaFin, int capacidad)
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@fechaInicio", fechaInicio);
            p[1] = new SqlParameter("@fechaFin", fechaFin);
            p[2] = new SqlParameter("@capacidad", capacidad);
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarHabitacionesParaReserva", p);
            List<BE.Habitacion> lista = new List<BE.Habitacion>();
            foreach (DataRow dr in tabla.Rows)
            {
                BE.TipoHabitacion tipo = new BE.TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["DescripcionTipo"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"]
                };

                BE.Habitacion habitacion = new BE.Habitacion
                {
                    IdHabitacion = (int)dr["IdHabitacion"],
                    Numero = (int)dr["Numero"],
                    Descripcion = dr["Descripcion"] == DBNull.Value ? null : (string)dr["Descripcion"],
                    Estado = (string)dr["Estado"],
                    Tipo = tipo
                };

                lista.Add(habitacion);
            }
            return lista;
        }
        public List<BE.Habitacion> ListarTodasHabitaciones()
        {
            List<BE.Habitacion> lista = new List<BE.Habitacion>();
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarTodasHabitaciones", null);

            foreach (DataRow dr in tabla.Rows)
            {
                BE.TipoHabitacion tipo = new BE.TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["DescripcionTipo"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"]
                };

                BE.Habitacion habitacion = new BE.Habitacion
                {
                    IdHabitacion = (int)dr["IdHabitacion"],
                    Numero = (int)dr["Numero"],
                    Descripcion = dr["Descripcion"] == DBNull.Value ? null : (string)dr["Descripcion"],
                    Estado = (string)dr["Estado"],
                    Activo = (bool)dr["Activo"],
                    Tipo = tipo
                };

                lista.Add(habitacion);
            }
            return lista;
        }
        public int RegistrarHabitacion(Habitacion habitacion)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@Numero", habitacion.Numero);
            p[1] = new SqlParameter("@Descripcion", (object)habitacion.Descripcion ?? DBNull.Value);
            p[2] = new SqlParameter("@IdTipoHabitacion", habitacion.Tipo.IdTipoHabitacion);

            p[3] = new SqlParameter("@IdHabitacionGenerada", SqlDbType.Int);
            p[3].Direction = ParameterDirection.Output;

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarHabitacion", p);

            return (int)p[3].Value;
        }

        public void ModificarHabitacion(Habitacion habitacion)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@IdHabitacion", habitacion.IdHabitacion);
            p[1] = new SqlParameter("@Numero", habitacion.Numero);
            p[2] = new SqlParameter("@Descripcion", (object)habitacion.Descripcion ?? DBNull.Value);
            p[3] = new SqlParameter("@IdTipoHabitacion", habitacion.Tipo.IdTipoHabitacion);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_ModificarHabitacion", p);
        }

        public void EliminarHabitacion(int idHabitacion)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdHabitacion", idHabitacion);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_EliminarHabitacion", p);
        }
        public List<Habitacion> ListarHabitacionesParaLimpieza()
        {
            List<Habitacion> lista = new List<Habitacion>();
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarHabitacionesParaLimpieza", null);

            foreach (DataRow dr in tabla.Rows)
            {
                BE.TipoHabitacion tipo = new BE.TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["DescripcionTipo"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"]
                };

                Habitacion habitacion = new Habitacion
                {
                    IdHabitacion = (int)dr["IdHabitacion"],
                    Numero = (int)dr["Numero"],
                    Descripcion = dr["Descripcion"] == DBNull.Value ? null : (string)dr["Descripcion"],
                    Estado = (string)dr["Estado"],
                    Tipo = tipo
                };

                lista.Add(habitacion);
            }
            return lista;
        }

        public void FinalizarLimpieza(int idHabitacion)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdHabitacion", idHabitacion);
            DAL_64PR.Acceso.Instancia.escribirSP("sp_FinalizarLimpieza", p);
        }
    }
}
