using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.SqlServer;

namespace Negocio
{
     public class EmpleadosModel
    {
        UserDao userDao = new UserDao();
        private EmpleadosDao empleadosDao = new EmpleadosDao();

        public DataTable ListaPacinetes()
        {
            return empleadosDao.DataTableEmpleados();
        }

        public string EditarEmpleado(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono, bool estado, int id)
        {
            return empleadosDao.EditarEmpleado(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono, estado, id);
        }

        public bool BuscarPacienteId(int id)
        {
            return empleadosDao.BuscarEmpleadoId(id);
        }

        public string NuevoEmpleado(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono)
        {
            return empleadosDao.NuevoEmpleado(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono);
        }

        public string EstadoPaciente(bool estado, int id)
        {
            return empleadosDao.EstadoPaciente(estado, id);
        }
    }
}
