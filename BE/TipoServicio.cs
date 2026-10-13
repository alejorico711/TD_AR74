using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TipoServicio
    {
        public int IdTipoServicio { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool RequiereStaff { get; set; }
        public bool Activo { get; set; }
        public override string ToString()
        {
            return Descripcion + " | " +Precio.ToString();
        }
    }
}
