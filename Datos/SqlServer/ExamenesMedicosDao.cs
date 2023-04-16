using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
   public class ExamenesMedicosDao:Connection
    {
        public DataTable DataTableExamenes()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select
                                    em.Id_Examen_Med 'Codigo'
                                    ,e.Nombre_Exm 'Nombre del Examen'
                                    ,CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente'
                                    ,em.Fecha_Registro 'Fecha'
                                    ,em.Estatus_Examen 'Estado'
                                    ,a.Nombre_Analisis 'Tipo de Área'
                                    from Examenes_Medicos em
                                    join Pacientes p on p.Id_Paciente = em.Id_Paciente 
                                    join Examenes_Medicos_Detalles emd on emd.Id_Examen_Med = em.Id_Examen_Med
                                    join Analisis a on a.Id_Analisis = emd.Id_Analisis
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

        public string NuevoExamenMedico(string indcaciones,int idUser,int idPaciente,int idTipoExamen,int idAnalisis)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"insert into Examenes_Medicos([Indicaciones_Examen],[Fecha_Examen],[Estatus_Examen],[Id_Usuario],[Id_Paciente])
                                            values(@indicaciones,GETDATE(),'En Proceso',@idUser,@Idpaciente)

                                            declare @idExamen int = (select MAX(Id_Examen_Med) from Examenes_Medicos)

                                            insert into Examenes_Medicos_Detalles (Id_Examen_Med,Id_Examen,Id_Analisis)
                                            values(@idExamen,@idTipoExam,@idArea)";
                        CMD.Parameters.AddWithValue("@indicaciones", indcaciones);
                        CMD.Parameters.AddWithValue("@idUser", idUser);
                        CMD.Parameters.AddWithValue("@Idpaciente", idPaciente);
                        CMD.Parameters.AddWithValue("@idTipoExam", idTipoExamen);
                        CMD.Parameters.AddWithValue("@idArea", idAnalisis);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Examen Registrado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }
    }
}
