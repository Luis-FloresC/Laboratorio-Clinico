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
    public class ExamenesDao:Connection
    {
        public DataTable DataTableExamenes()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT TOP (1000) [Id_Examen] 'Codigo'
                                  ,E.[Nombre_Exm] 'Nombre del Examen'
                                  ,E.[Estatus_Exm] 'Activo'
	                              ,A.Nombre_Analisis 'Área'
                                  ,E.[Costo_Examen] 'Precio'
                                  ,E.[Fecha_Registro] 'Fecha de Registro'
                                  ,E.[Fecha_Actualizacion] 'Fecha de Actualizacion'
                              FROM [Laboratorio_clinico].[dbo].[Examenes] E
                              join Analisis A on A.Id_Analisis = E.Id_analisis";

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


        public string NuevoExamen(string nombre,int idAnalisis ,decimal precio)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Examenes]
                                           ([Nombre_Exm]
                                           ,[Estatus_Exm]
                                           ,[Id_analisis]
                                           ,[Costo_Examen])
                                     VALUES
                                           (@nombre
                                           ,1
                                           ,@idAnalisis
                                           ,@costo)";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@idAnalisis", idAnalisis);
                        CMD.Parameters.AddWithValue("@costo", precio);
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


        public string EditarExamen(string nombre, int idAnalisis, decimal precio,int estado,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Examenes]
                                           SET [Nombre_Exm] = @nombre
                                              ,[Estatus_Exm] = @estado
                                              ,[Id_analisis] = @idAnalisis
                                              ,[Costo_Examen] = @costo
                                              ,[Fecha_Actualizacion] = GETDATE()
                                         WHERE Id_Examen = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@idAnalisis", idAnalisis);
                        CMD.Parameters.AddWithValue("@costo", precio);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Examen Actualizado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public bool BuscarExamenePorId(int id)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT [Id_Examen]
                                                      ,[Nombre_Exm]
                                                      ,[Estatus_Exm]
                                                      ,[Id_analisis]
                                                      ,[Costo_Examen]
                                                      ,[Fecha_Registro]
                                                      ,[Fecha_Actualizacion]
                                                  FROM [Laboratorio_clinico].[dbo].[Examenes] where Estatus_Exm = 1 and Id_Examen = @id";
                        command.Parameters.AddWithValue("@id", id);

                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Examenes.Id = reader.GetInt32(0);
                                Cache_Examenes.Nombre = reader.GetString(1);
                                Cache_Examenes.Estado = reader.GetBoolean(2);
                                Cache_Examenes.IdAnalisis = reader.GetInt32(3);
                                Cache_Examenes.Precio = reader.GetDecimal(4);
                                Cache_Examenes.FechaRegistro = reader.GetDateTime(5);
                                Cache_Examenes.FechaActualizacion = reader.GetDateTime(6);
                            }
                            return true;
                        }
                        else
                            return false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }


    }
}
