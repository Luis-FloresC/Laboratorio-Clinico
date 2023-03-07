using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class UserModel
    {

        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public void ObtenerCargos()
        {
            userDao.obtenerCargos();
        }
    }
}
