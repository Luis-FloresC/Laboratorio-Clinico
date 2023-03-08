using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class Cache_Usuario
    {
        public static int IdEmpleado { get; set; }
        public static string NombreEmpleado { get; set; }
        public static string ApellidoEmpleado { get; set; }
        public static string DniEmpleado { get; set; }
        public static DateTime FechaNacimientoEmpleado { get; set; }
        public static string GeneroEmpleado { get; set; }
        public static string TelefonoEmpleado { get; set; }
        public static string DireccionEmpleado { get; set; }
        public static DateTime FechaRegistroEmpleado { get; set; }
        public static DateTime FechaActualizacionEmpleado { get; set; }

        public static string NombreUsuario { get; set; }
        public static string DniUsuario { get; set; }
        public static bool EstadoUsuario { get; set; }
        public static string CorreoElectronicoUsuario { get; set; }
        public static string ContraseniaUsuario { get; set; }
        public static DateTime FechaRegistroUsuario { get; set; }
        public static DateTime FechaActualizacionUsuario { get; set; }


        public static int IdRol { get; set; }
        public static string Cargo { get; set; }
    }
}
