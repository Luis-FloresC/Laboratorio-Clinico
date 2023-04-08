using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public class Seguridad
    {
        public int IdPermiso { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int idPos { get; set; }
        public string NombrePermiso { get; set; }
        public string descripcion { get; set; }

        public string NombreRol { get; set; }
        public int IdRol { get; set; }

        public int EstadoRol { get; set; }
    }
}
