using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPP_Huespedes_AR74
    {
        public List<Huesped> ListarHuespedes()
        {
            DataTable tabla = DAL_64PR.Acceso.Instancia.leerSP("sp_ListarHuespedes", null);
            List<BE.Huesped> lista = new List<BE.Huesped>();
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Huesped huesped = new BE.Huesped
                {
                    IdHuesped = (int)dr["IdHuesped"],
                    DNI = (string)dr["Dni"],
                    Nombre = (string)dr["Nombre"],
                    Apellido = (string)dr["Apellido"],
                    FechaNacimiento = (DateTime)dr["FechaNacimiento"],
                    Email = dr["CorreoElectronico"] == DBNull.Value ? null : (string)dr["CorreoElectronico"],
                    Telefono = dr["Telefono"] == DBNull.Value ? null : (string)dr["Telefono"]
                };

                lista.Add(huesped);
            }
            return lista;
        }
    }
}
