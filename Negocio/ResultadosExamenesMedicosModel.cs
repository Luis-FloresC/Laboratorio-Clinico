﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
