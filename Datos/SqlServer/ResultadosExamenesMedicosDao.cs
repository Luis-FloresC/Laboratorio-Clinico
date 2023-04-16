using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
   public class ResultadosExamenesMedicosDao:Connection
    {

        public DataTable DataTableResultados()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    re.Id_Resultado 'Codigo'
                                    ,red.Nombre_Archivo 'Nombre del Archivo'
                                    ,CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Nombre del Paciente'
                                    ,e.Nombre_Exm 'Nombre del Examen',
                                    re.Estatus_Resultado 'Estado'
                                    ,re.Fecha_Resultado 'Fecha de Resultado'
                                    from Resultados_Examenes re
                                    join Resultados_Examenes_Detalles red on re.Id_Resultado = red.Id_Resultado
                                    join Pacientes p on p.Id_Paciente = re.Id_Paciente
                                    join Examenes_Medicos_Detalles emd on red.Id_Examen_Med_Detalle = emd.Id_Examen_Med_Detalle
                                    join Examenes_Medicos em on em.Id_Examen_Med = emd.Id_Examen_Med_Detalle
                                    join Examenes e on e.Id_Examen = emd.Id_Examen";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
