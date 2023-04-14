using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string DniEmpleado { get; set; }
        public DateTime FechaNacimientoEmpleado { get; set; }
        public string GeneroEmpleado { get; set; }
        public bool EstadoEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public DateTime FechaRegistroEmpleado { get; set; }
        public DateTime FechaActualizacionEmpleado { get; set; }
    }
}
