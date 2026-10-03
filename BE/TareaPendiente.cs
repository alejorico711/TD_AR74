using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TareaPendiente
    {
        public string TipoTarea { get; set; }      // "Limpieza" por ahora; "ServicioAdicional" a futuro
        public int IdReferencia { get; set; }        // IdHabitacion o, a futuro, IdSolicitudServicio
        public int NumeroHabitacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaHora { get; set; }      // null para limpieza, usado a futuro por servicios
        public int Cantidad { get; set; }             // 0 para limpieza
    }
}
