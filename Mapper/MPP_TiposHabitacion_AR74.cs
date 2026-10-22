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
    public class MPP_TiposHabitacion_AR74
    {
        public List<TipoHabitacion> ListarTiposHabitacion()
        {
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarTipoHabitacion", null);
            List<TipoHabitacion> lista = new List<TipoHabitacion>();

            foreach (DataRow dr in tabla.Rows)
            {
                TipoHabitacion tipo = new TipoHabitacion
                {
                    IdTipoHabitacion = (int)dr["IdTipoHabitacion"],
                    Descripcion = (string)dr["Descripcion"],
                    Capacidad = (int)dr["Capacidad"],
                    PrecioPorNoche = (decimal)dr["PrecioPorNoche"],
                    Activo = (bool)dr["Activo"]
                };
                lista.Add(tipo);
            }
            return lista;
        }

        public int RegistrarTipoHabitacion(TipoHabitacion tipo)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@Descripcion", tipo.Descripcion);
            p[1] = new SqlParameter("@Capacidad", tipo.Capacidad);
            p[2] = new SqlParameter("@PrecioPorNoche", tipo.PrecioPorNoche);

            p[3] = new SqlParameter("@IdTipoHabitacionGenerado", SqlDbType.Int);
            p[3].Direction = ParameterDirection.Output;

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarTipoHabitacion", p);

            return (int)p[3].Value;
        }

        public void ModificarTipoHabitacion(TipoHabitacion tipo)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@IdTipoHabitacion", tipo.IdTipoHabitacion);
            p[1] = new SqlParameter("@Descripcion", tipo.Descripcion);
            p[2] = new SqlParameter("@Capacidad", tipo.Capacidad);
            p[3] = new SqlParameter("@PrecioPorNoche", tipo.PrecioPorNoche);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_ModificarTipoHabitacion", p);
        }

        public void EliminarTipoHabitacion(int idTipoHabitacion)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdTipoHabitacion", idTipoHabitacion);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_EliminarTipoHabitacion", p);
        }

        // ── Bitacora de Cambios ──────────────────────────────────────────────

        /// <summary>
        /// Devuelve el historial de TipoHabitacion_C.
        /// Si idFiltro es null o vacío, trae todos los registros.
        /// </summary>
        public DataTable ListarBitacoraCambios(string idFiltro)
        {
            SqlParameter[] p = new SqlParameter[1];

            if (!string.IsNullOrWhiteSpace(idFiltro) && int.TryParse(idFiltro.Trim(), out int id))
                p[0] = new SqlParameter("@IdTipoHabitacion", id);
            else
                p[0] = new SqlParameter("@IdTipoHabitacion", DBNull.Value);

            return DAL_64PR.Acceso.Instancia.leerSP("sp_ListarBitacoraTipoHabitacion", p);
        }

        /// <summary>
        /// Activa el registro histórico indicado (por Id + Fecha + Hora)
        /// y desactiva los demás del mismo tipo de habitación.
        /// También sincroniza TipoHabitacion con los datos de ese registro.
        /// </summary>
        public void ActivarRegistroBitacora(int idTipoHabitacion, DateTime fecha, TimeSpan hora)
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@IdTipoHabitacion", idTipoHabitacion);
            p[1] = new SqlParameter("@Fecha", fecha.Date);
            p[2] = new SqlParameter("@Hora", hora);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_ActivarRegistroBitacora", p);
        }
    }
}
