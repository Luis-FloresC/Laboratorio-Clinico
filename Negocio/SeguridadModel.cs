using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.SqlServer;
using Soporte.Cache;

namespace Negocio
{
    public class SeguridadModel
    {
        private SeguridadDao seguridadDao = new SeguridadDao();


        public DataTable DataTablePermisos()
        {
            return seguridadDao.DataTablePermisos();
        }


        public DataTable DataTableCalendario(DateTime fecha)
        {
            return seguridadDao.DataTableCalendario(fecha);
        }
        public string EdiatrRol(string nombre, bool estado, int id)
        {
            return seguridadDao.EdiatrRol(nombre, estado, id);
        }

        public DataTable DataTableRoles()
        {
            return seguridadDao.DataTableRoles();
        }

        public string NuevoRol(string nombre, bool estado)
        {
            return seguridadDao.NuevoRol(nombre, estado);
        }

        public void obtenerTodosLosPermisos()
        {
            seguridadDao.obtenerTodosLosPermisos();
        }

        public void PermisosPorRol(int idRol)
        {
            seguridadDao.PermisosPorRol(idRol);
        }

        public bool AsignarPermisos()
        {
            try
            {
                foreach (var rolesAsignados in Cache_Cargos.ListaAsignarRoles)
                {
                    seguridadDao.AsignarPermisos(rolesAsignados.IdRol, rolesAsignados.descripcion, rolesAsignados.EstadoRol);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
    }
}
