using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_Pagos_AR74
    {
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        Mapper.MPP_Pagos_AR74 mpp = new Mapper.MPP_Pagos_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();
        public void RegistrarPago(int idReserva, decimal total, string v)
        {
            mpp.RegistrarPago(idReserva, total, v);
            recalculador.RecalcularTabla("Pago");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Reserva).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.RegistrarPago).ToString(), 2);
            bita.RegistrarEvento(ev);
        }
    }
}

