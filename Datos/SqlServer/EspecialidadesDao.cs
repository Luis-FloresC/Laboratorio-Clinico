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
   public class EspecialidadesDao:Connection
    {
        public DataTable DataTableEspecialidades()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT [Id_Especialidad] 'Codigo'
                                  ,[Nombre_Esp] 'Especialidad'
                                  ,[Estatus_Esp] 'Activo'
                                  ,[Fecha_Registro] 'Fecha de Registro'
                                  ,[Fecha_Actualizacion] 'Fecha de Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Especialidades]";

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



        public void AsignarEspecialidades(int idMedico, string especialidad, bool estado)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"[AsignarEspecialidades]";
                        CMD.Parameters.AddWithValue("@idMedico", idMedico);
                        CMD.Parameters.AddWithValue("@especialidad", especialidad);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.CommandType = CommandType.StoredProcedure;
                       
                        Console.WriteLine("Result: {0}",CMD.ExecuteNonQuery());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }

        }

        public void EspecialidadesPorMedico(int idMedico)
        {
            Cache_Medico.ListEspecialidadesMedico.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select 
                                        e.Id_Especialidad ,
                                        e.Nombre_Esp,
                                        coalesce((select 1 from Medicos_Especialidades where Id_Especialidad = e.Id_Especialidad and Id_Medico = @id),0) 'Estado'
                                        from Especialidades e";
                    command.Parameters.AddWithValue("@id", idMedico);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Medico.ListEspecialidadesMedico.Add(new Especialidades() { IdEspecialidad = reader.GetInt32(0), NombreEspecialidad = reader.GetString(1), EstadoEspecialidad = Convert.ToBoolean(reader.GetInt32(2)) });
                        }

                    }

                }
            }
        }

        public string NuevaEspecialidad(string nombre)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Especialidades]
                                           ([Nombre_Esp]
                                           ,[Estatus_Esp])
                                     VALUES
                                           (@nombre
                                           ,1)";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.CommandType = CommandType.Text;
                        
                        return CMD.ExecuteNonQuery() == 1 ?  "Especialidad Registrada con éxito" : "No se puso registrar la espcialidad";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

    
        public string EditarEspecialidad(string nombre, bool estado, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Especialidades]
                                           SET [Nombre_Esp] = @nombre
                                              ,[Estatus_Esp] = @estado
                                              ,[Fecha_Actualizacion] = GETDATE()
                                         WHERE Id_Especialidad = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        Console.WriteLine("Id: {0}", id);
                        return CMD.ExecuteNonQuery() == 1 ? "Especialidad Actualizada con éxito" : "No se pudo actualizar";
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
