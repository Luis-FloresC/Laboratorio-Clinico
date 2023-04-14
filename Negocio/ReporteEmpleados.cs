using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class ReportesEmpleados
    {

        public DateTime reportDate { get;  private set; }

        public int totalEmpleados { get; private set; }

        private EmpleadosModel empleados = new EmpleadosModel();

        public List<Empleado> LisaEmpleados = new List<Empleado>();


        public void ReporteListaDeEmpleados()
        {
            reportDate = DateTime.Now;
            var result = empleados.ListaPacinetes();

            LisaEmpleados = new List<Empleado>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newEmpleado = new Empleado()
                {
                    IdEmpleado = Convert.ToInt32(row[0]),
                    NombreEmpleado = row[1].ToString(),
                    DniEmpleado = row[2].ToString(),
                    FechaNacimientoEmpleado = Convert.ToDateTime(row[3]),
                    DireccionEmpleado = row[4].ToString(),
                    TelefonoEmpleado = row[5].ToString(),
                    EstadoEmpleado = Convert.ToBoolean(row[6]),
                    GeneroEmpleado = row[7].ToString(),
                    FechaRegistroEmpleado = Convert.ToDateTime(row[8]),
                    FechaActualizacionEmpleado = Convert.ToDateTime(row[9])
                } ;

                LisaEmpleados.Add(newEmpleado);
                totalEmpleados++;
            }
        }
    }

   
}
