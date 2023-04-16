using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class Cache_Pacientes
    {
        public static int IdPaciente { get; set; }
       
        public static string NombrePaciente { get; set; }
        public static string ApellidoPaciente { get; set; }
        public static string DniPaciente { get; set; }
        public static DateTime FechaNacimientoPaciente { get; set; }
        public static string GeneroPaciente { get; set; }
        public static string TelefonoPaciente { get; set; }
        public static string DireccionPaciente { get; set; }
        public static DateTime FechaRegistroPaciente { get; set; }
        public static DateTime FechaActualizacionPaciente { get; set; }

        public static bool EstadoPaciente { get; set; }


        public static string NombreCompletoPaciente { get; set; }
        public static int IdPacienteSelected { get; set; }
        public static string DniPacienteSelected { get; set; }
    }
}
