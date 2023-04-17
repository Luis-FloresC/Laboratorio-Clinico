using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Datos.SqlServer;

namespace Negocio
{
   public class ResultadosExamenesMedicosModel
   {
       private ResultadosExamenesMedicosDao resultadosExamenes = new ResultadosExamenesMedicosDao();
        public DataTable DataTableResultados()
        {
            return resultadosExamenes.DataTableResultados();
        }

        public string NuevoResultadoExamenMedico(string nombreArchivo, int idUser, byte[] archivo, int idTipoExamen,
            string extension)
        {
            return resultadosExamenes.NuevoResultadoExamenMedico(nombreArchivo, idUser, archivo, idTipoExamen,
                extension);
        }

        public List<ResultadosExamenes> filtrarDocumentos(int id)
        {
            var tabla = resultadosExamenes.DataTableBuscarArchivoPorId(id);
            var infoList = new List<ResultadosExamenes>();

            foreach (DataRow item in tabla.Rows)
            {
                infoList.Add(new ResultadosExamenes()
                {
                    IdResultadoExamen = Convert.ToInt32(item[0]),
                    NombreArchivo = item[1].ToString(),
                    Archivo = (byte[])item[2],
                    ExtensionArchivo = item[3].ToString()
                });
            }

            return infoList;
        }
    }
}
