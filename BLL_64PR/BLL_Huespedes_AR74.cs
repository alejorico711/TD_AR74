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
        public List<BE.Huesped> ListarHuespedes()
        {
            return mpp.ListarHuespedes();
        }

        public int RegistrarHuesped(Huesped huesped)
        {
            return mpp.RegistrarHuesped(huesped);
        }
    }
}
