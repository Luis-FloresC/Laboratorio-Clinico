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
    public class PacientesModel
    {
        UserDao userDao = new UserDao();
        private PacientesDao pacientesDao = new PacientesDao();



        public DataTable ListaPacinetes()
        {
            return pacientesDao.DataTablePacientes();
        }

        public string EditarPaciente(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono, bool estado, int id)
        {
            return pacientesDao.EditarPaciente(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono,estado,id);
        }

        public bool BuscarPacienteId(int id)
        {
            return pacientesDao.BuscarPacienteId(id);
        }
        public int totalPacientes()
        {
            return pacientesDao.TotalPacientes();
        }

        public DataTable ListaPacinetes(int inicio,int final)
        {
            return pacientesDao.DataTablePacientes(inicio,final);
        }


        public string EstadoPaciente(bool estado, int id)
        {
            return pacientesDao.EstadoPaciente(estado, id);
        }
        public string NuevoPaciente(string nombre, string apellido, string dni, string genero, DateTime fechaNac,
            string direccion, string telefono)
        {
            return pacientesDao.NuevoPaciente(nombre, apellido, dni, genero, fechaNac,
                direccion, telefono);
        }
    }
}
