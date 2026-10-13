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
        Mapper.MPP_SolicitudesServicio_AR74 mpp = new Mapper.MPP_SolicitudesServicio_AR74();

        public int RegistrarSolicitudServicio(SolicitudServicio solicitud)
        {
            // Regla cruzada: un pago inmediato exige método de pago
            if (solicitud.EstadoPago == EstadoPago.Pagado && string.IsNullOrWhiteSpace(solicitud.MetodoPago))
                throw new ArgumentException("Un servicio pagado requiere método de pago.");

            return mpp.RegistrarSolicitudServicio(solicitud);
        }
    }
}
