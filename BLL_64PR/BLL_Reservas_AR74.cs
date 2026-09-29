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
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        Mapper.MPP_Reservas_AR74 mpp = new Mapper.MPP_Reservas_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();
        public void RegistrarReserva(Reserva_AR74 reserva)
        {
            mpp.RegistrarReserva(reserva);
            recalculador.RecalcularTabla("Reserva");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Reserva).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.RegistrarReserva).ToString(), 4);
            bita.RegistrarEvento(ev);
        }

        public List<Reserva_AR74> ListarReservasCheckInHoy()
        {
            return mpp.ListarReservasCheckInHoy();
        }

        public void ConfirmarCheckIn(int idReserva)
        {
            mpp.ConfirmarCheckIn(idReserva);
            recalculador.RecalcularTabla("Reserva");
            recalculador.RecalcularTabla("Habitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.CheckIn).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.RegistrarCheckIn).ToString(), 4);
            bita.RegistrarEvento(ev);
        }

        public List<Reserva_AR74> ListarReservasCheckOutHoy()
        {
            return mpp.ListarReservasCheckOutHoy();
        }

        public void ConfirmarCheckOut(int idReserva)
        {
            mpp.ConfirmarCheckout(idReserva);
            recalculador.RecalcularTabla("Reserva");
            recalculador.RecalcularTabla("Habitacion");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.CheckOut).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.RegistrarCheckOut).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
    }
}
