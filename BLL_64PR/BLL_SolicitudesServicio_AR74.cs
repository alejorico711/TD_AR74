using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_SolicitudesServicio_AR74
    {
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        Mapper.MPP_SolicitudesServicio_AR74 mpp = new Mapper.MPP_SolicitudesServicio_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();

        public int RegistrarSolicitudServicio(SolicitudServicio solicitud)
        {
            // Regla cruzada: un pago inmediato exige método de pago
            if (solicitud.EstadoPago == EstadoPago.Pagado && string.IsNullOrWhiteSpace(solicitud.MetodoPago))
                throw new ArgumentException("Un servicio pagado requiere método de pago.");

            int aux = mpp.RegistrarSolicitudServicio(solicitud);
            recalculador.RecalcularTabla("SolicitudServicio");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Servicios).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.AltaSolicitudServicio).ToString(), 4);
            bita.RegistrarEvento(ev);
            return aux;
        }
        public List<SolicitudServicio> ListarServiciosPendientesStaff()
        {
            return mpp.ListarServiciosPendientesStaff();
        }

        public void FinalizarServicio(int idSolicitud)
        {
            mpp.FinalizarServicio(idSolicitud);
            recalculador.RecalcularTabla("SolicitudServicio");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Servicios).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.FinalizacionServicio).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
        public List<SolicitudServicio> ListarServiciosPendientesDePago(int idReserva)
        {
            return mpp.ListarServiciosPendientesDePago(idReserva);
        }
    }
}

