using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
   public class AnalisisDao: Connection
    {

        public DataTable DataTableAnalisis()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT [Id_Analisis] 'Codigo'
                                  ,[Nombre_Analisis] 'Nombre'
	                              ,coalesce((Select count(*) from Examenes where Id_analisis = A.Id_Analisis),0) 'Cantidad de Examenes'
                                  ,[Estatus_Analisis] 'Activo'
                                  ,[Fecha_Registro] 'Registro'
                                  ,[Fecha_Actualizacion] 'Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Analisis] A";

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

        public DataTable DataTableAnalisisComboBox()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT  [Id_Analisis] 'Id',[Nombre_Analisis] 'Nombre' FROM [Laboratorio_clinico].[dbo].[Analisis] where Estatus_Analisis = 1";

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


        public string NuevaCategoria(string nombre)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Analisis] ([Nombre_Analisis],[Estatus_Analisis]) VALUES (@nombre,1)";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Categoria Registrado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string ActualizarCategoria(string nombre,int estado,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Analisis]
                                           SET [Nombre_Analisis] = @nombre
                                              ,[Estatus_Analisis] = @estado
                                              ,[Fecha_Actualizacion] = GETDATE()
                                         WHERE id_Analisis = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        Console.WriteLine("Estado {0}",estado);
                        CMD.ExecuteNonQuery();
                        return "Categoria Actualizada con éxito";
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
