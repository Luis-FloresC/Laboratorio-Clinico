using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;
using Soporte.Cache;

namespace Negocio
{
  public  class EspecialidadesModel
  {
        private EspecialidadesDao especialidades = new EspecialidadesDao();
        public DataTable DataTableEspecialidades()
        {
            return especialidades.DataTableEspecialidades();
        }

        public string NuevaEspecialidad(string nombre)
        {
            return especialidades.NuevaEspecialidad(nombre);
        }

        public string EditarEspecialidad(string nombre, bool estado, int id)
        {
            return especialidades.EditarEspecialidad(nombre, estado, id);
        }

        public void EspecialidadesPorMedico(int idMedico)
        {
            especialidades.EspecialidadesPorMedico(idMedico);
        }

        public bool AsignarEspecialidades()
        {
            try
            {
                foreach (var especialidadesList in Cache_Medico.ListEspecialidadesMedicoAct)
                {
                    this.especialidades.AsignarEspecialidades(especialidadesList.IdMedico, especialidadesList.NombreEspecialidad, especialidadesList.EstadoEspecialidad);
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
