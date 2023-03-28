using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
    public class AnalisisModel
    {
        private AnalisisDao analisis = new AnalisisDao();
        public DataTable DataTableAnalisis()
        {
            return analisis.DataTableAnalisis();
        }

        public DataTable DataTableAnalisisComboBox()
        {
            return analisis.DataTableAnalisisComboBox();
        }

        public string NuevaCategoria(string nombre)
        {
            return analisis.NuevaCategoria(nombre);
        }

        public string ActualizarCategoria(string nombre, int estado,int id)
        {
            return analisis.ActualizarCategoria(nombre, estado,id);
        }
    }
}
