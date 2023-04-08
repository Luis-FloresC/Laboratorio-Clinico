using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
   public static class Cache_Medico
    {
        public static int IdMedico { get; set; }
     
        public static string NombreMedico { get; set; }
        public static string ApellidoMedico { get; set; }
        public static string DniMedico { get; set; }
        public static DateTime FechaNacimientoMedico { get; set; }
        public static string GeneroMedico { get; set; }
        public static bool EstadoMedico { get; set; }
        public static string TelefonoMedico { get; set; }
        public static string DireccionMedico { get; set; }
        public static DateTime FechaRegistroMedico { get; set; }
        public static DateTime FechaActualizacionMedico { get; set; }

        public static List<Especialidades> ListEspecialidadesMedico = new List<Especialidades>();
        public static List<Especialidades> ListEspecialidadesMedicoAct = new List<Especialidades>();
    }
}
