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
    public class MPP_TiposServicio_AR74
    {
        public int AltaTipoServicio(TipoServicio tipo)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@Descripcion", tipo.Descripcion);
            p[1] = new SqlParameter("@Precio", tipo.Precio);
            p[2] = new SqlParameter("@RequiereStaff", tipo.RequiereStaff);

            p[3] = new SqlParameter("@IdTipoServicioGenerado", SqlDbType.Int);
            p[3].Direction = ParameterDirection.Output;

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarTipoServicio", p);

            return (int)p[3].Value;
        }

        public void EliminarTipoServicio(int idTipoServicio)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@IdTipoServicio", idTipoServicio);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_EliminarTipoServicio", p);
        }

        public List<TipoServicio> ListarTiposServicio()
        {
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarTiposServicio", null);
            List<TipoServicio> lista = new List<TipoServicio>();

            foreach (DataRow dr in tabla.Rows)
            {
                lista.Add(new TipoServicio
                {
                    IdTipoServicio = (int)dr["IdTipoServicio"],
                    Descripcion = (string)dr["Descripcion"],
                    Precio = (decimal)dr["Precio"],
                    RequiereStaff = (bool)dr["RequiereStaff"],
                    Activo = (bool)dr["Activo"]
                });
            }
            return lista;
        }

        public void ModificarTipoServicio(TipoServicio tipo)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@IdTipoServicio", tipo.IdTipoServicio);
            p[1] = new SqlParameter("@Descripcion", tipo.Descripcion);
            p[2] = new SqlParameter("@Precio", tipo.Precio);
            p[3] = new SqlParameter("@RequiereStaff", tipo.RequiereStaff);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_ModificarTipoServicio", p);
        }
    }
}
