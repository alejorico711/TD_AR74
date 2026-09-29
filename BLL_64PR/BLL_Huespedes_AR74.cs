using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class BLL_Huespedes_AR74
    {
        Mapper.MPP_Huespedes_AR74 mpp = new Mapper.MPP_Huespedes_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();
        Bitacora.Bitacora_64PR bita = new Bitacora.Bitacora_64PR();
        public List<BE.Huesped> ListarHuespedes()
        {
            return mpp.ListarHuespedes();
        }

        public int RegistrarHuesped(Huesped huesped)
        {
            int aux = mpp.RegistrarHuesped(huesped);
            recalculador.RecalcularTabla("Huesped");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.AltaHuesped).ToString(), 4);
            bita.RegistrarEvento(ev);
            return aux;

        }
        public void EliminarHuesped(int idHuesped)
        {
            mpp.EliminarHuesped(idHuesped);
            recalculador.RecalcularTabla("Huesped");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.BajaHuesped).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
        public void ModificarHuesped(Huesped huesped)
        {
            mpp.ModificarHuesped(huesped);
            recalculador.RecalcularTabla("Huesped");
            Bitacora.Evento_64PR ev = new Bitacora.Evento_64PR(Sesion.SessionManager.GetInstance.Usuario.Login, ((int)Bitacora.ModuloBitacora_64PR.Maestros).ToString(), ((int)Bitacora.TipoEventoBitacora_64PR.ModificacionHuesped).ToString(), 4);
            bita.RegistrarEvento(ev);
        }
    }
}
