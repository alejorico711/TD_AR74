using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_TareasStaff_AR74
    {
        BLL_Habitaciones_AR74 bllHabitaciones = new BLL_Habitaciones_AR74();
        BLL_64PR.BLL_SolicitudesServicio_AR74 bllServicios = new BLL_64PR.BLL_SolicitudesServicio_AR74();

        public List<TareaPendiente> ListarTareasPendientes()
        {
            List<TareaPendiente> tareas = new List<TareaPendiente>();

            List<Habitacion> habitacionesLimpieza = bllHabitaciones.ListarHabitacionesParaLimpieza();
            foreach (var hab in habitacionesLimpieza)
            {
                tareas.Add(new TareaPendiente
                {
                    TipoTarea = "Limpieza",
                    IdReferencia = hab.IdHabitacion,
                    NumeroHabitacion = hab.Numero,
                    Descripcion = "Limpieza de habitación"
                });
            }

            List<SolicitudServicio> serviciosPendientes = bllServicios.ListarServiciosPendientesStaff();
            foreach (var s in serviciosPendientes)
            {
                tareas.Add(new TareaPendiente
                {
                    TipoTarea = "ServicioAdicional",
                    IdReferencia = s.IdSolicitud,
                    NumeroHabitacion = s.Reserva.Habitacion.Numero,
                    Descripcion = s.Servicio.Descripcion
                });
            }

            return tareas.OrderBy(t => t.NumeroHabitacion).ToList();
        }

        public void FinalizarTarea(TareaPendiente tarea)
        {
            switch (tarea.TipoTarea)
            {
                case "Limpieza":
                    bllHabitaciones.FinalizarLimpieza(tarea.IdReferencia);
                    break;
                case "ServicioAdicional":
                    bllServicios.FinalizarServicio(tarea.IdReferencia);
                    break;
            }
        }
    }
}
