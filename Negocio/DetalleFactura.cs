using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class DetalleFactura
    {
        public int idFactura { get; set; }
        public int idExamenMed { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
    }
}
