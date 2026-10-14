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

        public void AltaTipoServicio(TipoServicio tipo)
        {
            mpp.AltaTipoServicio(tipo);
        }

        public void EliminarTipoServicio(int idTipoServicio)
        {
            mpp.EliminarTipoServicio(idTipoServicio);
        }
        public void ModificarTipoServicio(TipoServicio tipo)
        {
            mpp.ModificarTipoServicio(tipo);
        }
        public List<TipoServicio> ListarTiposServicio()
        {
            return mpp.ListarTiposServicio();
        }
    }
}
