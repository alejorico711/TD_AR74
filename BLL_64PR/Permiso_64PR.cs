using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_64PR
{
    public class Permiso_64PR
    {
        Mapper.mpp_roles mpp = new Mapper.mpp_roles();
        private static readonly DV_64PR recalculador = new DV_64PR();
        public List<Sesion.Rol_64PR> ObtenerTodosLosNodos()
        {
            return mpp.ObtenerTodosLosNodos();
        }
    }
}
