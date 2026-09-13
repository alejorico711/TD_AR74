using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPP_Pagos_AR74
    {
        public void RegistrarPago(int idReserva, decimal total, string v)
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@IdReserva", idReserva);
            p[1] = new SqlParameter("@MetodoPago", v);
            p[2] = new SqlParameter("@Monto", total);

            DAL_64PR.Acceso.Instancia.escribirSP("sp_RegistrarPago", p);
        }
    }
}
