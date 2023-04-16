using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
    public class ExamenesModel
    {
        private ExamenesDao examenesDao = new ExamenesDao();

        public DataTable DataTableExamenes()
        {
            return examenesDao.DataTableExamenes();
        }

        public DataTable DataTableExamenesPorId(int idArea)
        {
            return examenesDao.DataTableExamenesPorId(idArea);
        }

        public string NuevoExamen(string nombre, int idAnalisis, decimal precio)
        {
            return examenesDao.NuevoExamen(nombre, idAnalisis, precio);
        }

        public string EditarExamen(string nombre, int idAnalisis, decimal precio, int estado, int id)
        {
            return examenesDao.EditarExamen(nombre, idAnalisis, precio, estado, id);
        }

        public bool BuscarExamenePorId(int id)
        {
            return examenesDao.BuscarExamenePorId(id);
        }
    }
}
