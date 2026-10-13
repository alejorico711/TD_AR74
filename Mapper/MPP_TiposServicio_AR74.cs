using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPP_TiposServicio_AR74
    {
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
    }
}
