using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
   public class ExamenesMedicosModel
   {
       private ExamenesMedicosDao examenesMedicosDao = new ExamenesMedicosDao();

       public DataTable DataTableExamenes()
       {
           return examenesMedicosDao.DataTableExamenes(); 
       }

       public string NuevoExamenMedico(string indcaciones, int idUser, int idPaciente, int idTipoExamen, int idAnalisis)
       {
           return examenesMedicosDao.NuevoExamenMedico(indcaciones, idUser, idPaciente, idTipoExamen, idAnalisis);
       }
   }
}
