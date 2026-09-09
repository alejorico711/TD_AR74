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
    }
}
