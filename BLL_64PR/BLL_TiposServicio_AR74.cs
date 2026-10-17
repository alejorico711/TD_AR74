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
        Mapper.MPP_TiposServicio_AR74 mpp = new Mapper.MPP_TiposServicio_AR74();
        private static readonly DV.DV_64PR recalculador = new DV.DV_64PR();

        public void AltaTipoServicio(TipoServicio tipo)
        {
            mpp.AltaTipoServicio(tipo);
            recalculador.RecalcularTabla("TipoServicio");
        }

        public void EliminarTipoServicio(int idTipoServicio)
        {
            mpp.EliminarTipoServicio(idTipoServicio);
            recalculador.RecalcularTabla("TipoServicio");
        }
        public void ModificarTipoServicio(TipoServicio tipo)
        {
            mpp.ModificarTipoServicio(tipo);
            recalculador.RecalcularTabla("TipoServicio");
        }
        public List<TipoServicio> ListarTiposServicio()
        {
            return mpp.ListarTiposServicio();
        }
    }
}
