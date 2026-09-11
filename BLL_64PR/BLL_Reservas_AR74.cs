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

        public List<Reserva_AR74> ListarReservasCheckInHoy()
        {
            return mpp.ListarReservasCheckInHoy();
        }

        public void ConfirmarCheckIn(int idReserva)
        {
            mpp.ConfirmarCheckIn(idReserva);
        }

        public List<Reserva_AR74> ListarReservasCheckOutHoy()
        {
            return mpp.ListarReservasCheckOutHoy();
        }

        public void ConfirmarCheckOut(int idReserva)
        {
            mpp.ConfirmarCheckout(idReserva);
        }
    }
}
