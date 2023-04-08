using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Soporte.Cache;

namespace Negocio
{
    public class UserModel
    {

        UserDao userDao = new UserDao();

        public DataTable DataTableUsuarios()
        {
            return userDao.DataTableUsuarios();
        }

        public bool BuscarUsuarioPorId(int id)
        {
            return userDao.BuscarUsuarioPorId(id);
        }
        public DataTable BuscarPersonal(string filtro = "All")
        {
            return userDao.BuscarPersonal(filtro);
        }

        public string NuevoUsuario(string Contraseña, string dni, string correo, string user, int id_rol)
        {
            return userDao.NuevoUsuario(Contraseña, dni, correo, user, id_rol);
        }

        public DataTable ComboBoxCargo()
        {
            return userDao.ComboBoxCargo();
        }
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string EditarDatosMedico(string nombre, string apellido, DateTime fechaNac, string direccion,
            string telefono, string genero, int id)
        {
            return userDao.EditarDatosMedico(nombre, apellido, fechaNac, direccion, telefono, genero, id);
        }

        public string EditarDatosEmpleado(string nombre, string apellido, DateTime fechaNac, string direccion,
            string telefono, string genero, int id)
        {
            return userDao.EditarDatosEmpleado(nombre, apellido, fechaNac, direccion, telefono, genero, id);
        }

        public string EditarUsuario(string Contraseña, string dni, string correo, string user,int id_Rol)
        {
            return userDao.EditarUsuario(Contraseña, dni, correo, user,id_Rol);
        }

        public bool buscarUsuarioPorPin(string pin)
        {
            return userDao.buscarUsuarioPorPin(pin);
        }

        public string cambiarContraseña(string password, int id)
        {
            return userDao.CambiarContraseña(password, id);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public bool securityLogin()
        {
            if (Cache_Usuario.IdUsuario >= 1)
            {
                if (userDao.existsUser(Cache_Usuario.IdUsuario, Cache_Usuario.NombreUsuario, Cache_Usuario.ContraseniaUsuario) == true)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public void ObtenerCargos()
        {
            userDao.obtenerCargos();
        }

     

        public void ObtenerPermisosRol(int idRol)
        {
            userDao.obtenerPermisosUsuario(idRol);
        }
    }
}
