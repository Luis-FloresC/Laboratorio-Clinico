using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class Cache_Examenes
    {
        public static int Id { get; set; }
        public static int IdAnalisis { get; set; }
        public static string Nombre { get; set; }
        public static decimal Precio { get; set; }
        public static bool Estado { get; set; }
        public static DateTime FechaRegistro { get; set; }
        public static DateTime FechaActualizacion { get; set; }


        /// <summary>
        /// Examenes Medicos
        /// </summary>
        public static int IdExamenMedico { get; set; }
        public static string NombrePaciente { get; set; }
        public static string NombreExamen { get; set; }

    }
}
