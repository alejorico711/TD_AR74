using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_Pagos_AR74
    {
        Mapper.MPP_Pagos_AR74 mpp = new Mapper.MPP_Pagos_AR74();
        public void RegistrarPago(int idReserva, decimal total, string v)
        {
            mpp.RegistrarPago(idReserva, total, v);
        }
    }
}
