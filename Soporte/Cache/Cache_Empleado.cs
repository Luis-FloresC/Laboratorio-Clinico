using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
   public static class Cache_Empleado
    {
        public static int IdEmpleado { get; set; }
        public static string NombreEmpleado { get; set; }
        public static string ApellidoEmpleado { get; set; }
        public static string DniEmpleado { get; set; }
        public static DateTime FechaNacimientoEmpleado { get; set; }
        public static string GeneroEmpleado { get; set; }
        public static bool EstadoEmpleado { get; set; }
        public static string TelefonoEmpleado { get; set; }
        public static string DireccionEmpleado { get; set; }
        public static DateTime FechaRegistroEmpleado { get; set; }
        public static DateTime FechaActualizacionEmpleado { get; set; }
    }
}
