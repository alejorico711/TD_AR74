using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SolicitudServicio
    {
        public int IdSolicitud { get; set; }
        public Reserva_AR74 Reserva { get; set; }
        public TipoServicio Servicio { get; set; }
        public DateTime FechaHoraSolicitud { get; set; }
        public decimal Precio { get; set; }
        public EstadoServicio EstadoServicio { get; set; }
        public EstadoPago EstadoPago { get; set; }
        public string MetodoPago { get; set; }

        public override string ToString()
        {
            return Servicio.Descripcion + " | " + Precio.ToString();
        }
    }
}
