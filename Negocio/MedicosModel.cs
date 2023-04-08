using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
    public class MedicosModel
    {
        private MedicosDao medicosDao = new MedicosDao();

        public DataTable DataTableMedicos()
        {
            return medicosDao.DataTableMedicos();
        }

        public string EditarMedico(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono, bool estado, int id)
        {
            return medicosDao.EditarMedico(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono, estado, id);
        }

        public bool BuscarMedicoId(int id)
        {
            return medicosDao.BuscarMedicoId(id);
        }

        public string NuevoMedico(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono)
        {
            return medicosDao.NuevoMedico(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono);
        }
    }
}
