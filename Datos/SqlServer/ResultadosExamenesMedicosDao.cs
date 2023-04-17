using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;

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


        public DataTable DataTableBuscarArchivoPorId(int id)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT 
                                [Id_Resultado]
                            ,[Nombre_Archivo]
                        ,[Archivo]
                        ,[Extension_Archivo]
                        FROM[Laboratorio_clinico].[dbo].[Resultados_Examenes_Detalles]
                        where Id_Resultado = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
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

        public string NuevoResultadoExamenMedico(string nombreArchivo, int idUser, byte[] archivo, int idTipoExamen, string extension)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"declare @idPaciente  int = (select Id_Paciente from Examenes_Medicos where Id_Examen_Med = @idExamen)

                                            insert into Resultados_Examenes (Fecha_Resultado,[Estatus_Resultado],[Id_Paciente],[Id_usuario])
                                            values (getDate(),1,@idPaciente,@idUser)

                                            declare @idResultado int = (select max(Id_Resultado) from Resultados_Examenes)
                                            declare @idExamenMedDetalle int = (select Id_Examen_Med_Detalle from Examenes_Medicos_Detalles where Id_Examen_Med = @idExamen)

                                            insert into Resultados_Examenes_Detalles(Id_Resultado,Nombre_Archivo,Id_Examen_Med_Detalle,Archivo,Extension_Archivo)
                                            values (@idResultado,@nombreArchivo,@idExamenMedDetalle,@archivo,@extension)

                                            update Examenes_Medicos set Estatus_Examen = 'Finalizado',Fecha_Actualizacion = getdate() where Id_Examen_Med = @idExamen";
                        CMD.Parameters.AddWithValue("@nombreArchivo", nombreArchivo);
                        CMD.Parameters.AddWithValue("@idUser", idUser);
                        CMD.Parameters.AddWithValue("@archivo", archivo);
                        CMD.Parameters.AddWithValue("@idExamen", idTipoExamen);
                        CMD.Parameters.AddWithValue("@extension", extension);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Resultado registrado con éxito";
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
