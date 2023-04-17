using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
   public static class Cache_Resultado_Examen
    {
        public  static  int IdResultadoExamen { get; set; }

        public  static  string NombreArchivo { get; set; }
        public   static byte[] Archivo { get; set; }
        public  static  string ExtensionArchivo { get; set; }
    }
}
