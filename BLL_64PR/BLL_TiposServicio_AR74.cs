using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_TiposServicio_AR74
    {
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        Mapper.MPP_TiposServicio_AR74 mpp = new Mapper.MPP_TiposServicio_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();

        public void AltaTipoServicio(TipoServicio tipo)
        {
            mpp.AltaTipoServicio(tipo);
            recalculador.RecalcularTabla("TipoServicio");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Servicios).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.AltaTipoServicio).ToString(), 4);
            bita.RegistrarEvento(ev);
        }

        public void EliminarTipoServicio(int idTipoServicio)
        {
            mpp.EliminarTipoServicio(idTipoServicio);
            recalculador.RecalcularTabla("TipoServicio");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Servicios).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.BajaTipoServicio).ToString(), 3);
            bita.RegistrarEvento(ev);
        }
        public void ModificarTipoServicio(TipoServicio tipo)
        {
            mpp.ModificarTipoServicio(tipo);
            recalculador.RecalcularTabla("TipoServicio");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Servicios).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.ModificacionTipoServicio).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
        public List<TipoServicio> ListarTiposServicio()
        {
            return mpp.ListarTiposServicio();
        }
    }
}

