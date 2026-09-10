using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_Reservas_AR74
    {
        Mapper.MPP_Reservas_AR74 mpp = new Mapper.MPP_Reservas_AR74();
        public void RegistrarReserva(Reserva_AR74 reserva)
        {
            mpp.RegistrarReserva(reserva);
        }
    }
}
