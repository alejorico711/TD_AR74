using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora
{
    public class Bitacora_64PR
    {
        Bitacora.mpp_bitacora mpp = new Bitacora.mpp_bitacora();
        public List<Bitacora.Evento_64PR> ListarEventos()
        {
            return mpp.ListarEventos();
        }

        public List<string> ListarLogins()
        {
            return mpp.ListarLogins();
        }

        public List<string> ListarModulos()
        {
            return mpp.ListarModulos();
        }

        public List<string> ListarTipos()
        {
            return mpp.ListarTipos();
        }

        public void RegistrarEvento(Bitacora.Evento_64PR e)
        {
            mpp.RegistrarEvento(e);
        }
    }
}
