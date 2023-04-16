using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ResultadosExamenes
    {
        public int IdResultadoExamen { get; set; }
        public int IdPaciente { get; set; }
        public int IdExamen { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public string ExtensionArchivo { get; set; }



    }
}
