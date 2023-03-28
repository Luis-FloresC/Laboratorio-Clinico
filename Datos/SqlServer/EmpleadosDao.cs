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
    public class EmpleadosDao : Connection
    {
        /// <summary>
        /// Funcion para lista todos los empleados y mostrar en el datagridview
        /// </summary>
        /// <returns></returns>
        public DataTable DataTableEmpleados()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT [Id_Empleado] 'Código'
                                     ,CONCAT(Nombre_Empleado,' ',Apellido_Empleado) 'Nombre Completo'
                                      ,[Dni_Empleado] 'Identidad'
                                      ,[Fecha_Nacimiento] 'Fecha de Nacimiento'
                                      ,[Direccion_Empleado] 'Dirección'
                                      ,[Telefono_Empleado] 'Telefono'
                                      ,[Estatus_Us] 'Activo'
                                      ,[Genero] 'Genero'
                                      ,[Fecha_Registro] 'Registro'
                                      ,[Fecha_Actualizacion] 'Actualizacion de Datos'
                                  FROM [Laboratorio_clinico].[dbo].[Empleados]";

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

        /// <summary>
        /// Funcion para buscar un empleado por id
        /// </summary>
        /// <param name="id">Id del Empleado</param>
        /// <returns></returns>
        public bool BuscarEmpleadoId(int id)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Empleados where Id_Empleado = @id";
                        command.Parameters.AddWithValue("@id", id);

                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Empleado.IdEmpleado = reader.GetInt32(0);
                                Cache_Empleado.NombreEmpleado = reader.GetString(1);
                                Cache_Empleado.ApellidoEmpleado = reader.GetString(2);
                                Cache_Empleado.DniEmpleado = reader.GetString(3);
                                Cache_Empleado.FechaNacimientoEmpleado = reader.GetDateTime(4);
                                Cache_Empleado.DireccionEmpleado = reader.GetString(5);
                                Cache_Empleado.TelefonoEmpleado = reader.GetString(6);
                                Cache_Empleado.GeneroEmpleado = reader.GetString(8);
                                Cache_Empleado.EstadoEmpleado = reader.GetBoolean(7);
                                Cache_Empleado.FechaRegistroEmpleado = reader.GetDateTime(9);
                                Cache_Empleado.FechaActualizacionEmpleado = reader.GetDateTime(10);
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

        /// <summary>
        /// Función para registrar un nuevo Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public string NuevoEmpleado(string nombre, string apellido, string dni, string genero, DateTime fechaNac, string direccion, string telefono)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Empleados]
                                           ([Nombre_Empleado]
                                           ,[Apellido_Empleado]
                                           ,[Dni_Empleado]
                                           ,[Fecha_Nacimiento]
                                           ,[Direccion_Empleado]
                                           ,[Telefono_Empleado]
                                           ,[Estatus_Us]
                                           ,[Genero])
                                     VALUES
                                           (@nombre
                                           ,@apellido
                                           ,@dni
                                           ,@fechaNac
                                           ,@direccion
                                           ,@telefono
                                           ,1
                                           ,@gen)";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@apellido", apellido);
                        CMD.Parameters.AddWithValue("@dni", dni);
                        CMD.Parameters.AddWithValue("@fechaNac", fechaNac);
                        CMD.Parameters.AddWithValue("@direccion", direccion);
                        CMD.Parameters.AddWithValue("@telefono", telefono);
                        CMD.Parameters.AddWithValue("@gen", genero);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Empleado Registrado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        /// <summary>
        /// Funcion para editar un Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="estado"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string EditarEmpleado(string nombre, string apellido, string dni, string genero, DateTime fechaNac, string direccion, string telefono, bool estado, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Empleados]
                                       SET [Nombre_Empleado] = @nombre
                                          ,[Apellido_Empleado] = @apellido
                                          ,[Dni_Empleado] = @dni
                                          ,[Fecha_Nacimiento] = @fechaNac
                                          ,[Direccion_Empleado] = @direccion
                                          ,[Telefono_Empleado] = @telefono
                                          ,[Estatus_Us] = @estado
                                          ,[Genero] = @gen
                                          ,[Fecha_Actualizacion] = GETDATE()
                                     WHERE Id_Empleado = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@apellido", apellido);
                        CMD.Parameters.AddWithValue("@dni", dni);
                        CMD.Parameters.AddWithValue("@fechaNac", fechaNac);
                        CMD.Parameters.AddWithValue("@direccion", direccion);
                        CMD.Parameters.AddWithValue("@telefono", telefono);
                        CMD.Parameters.AddWithValue("@gen", genero);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Empleado Actualizado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }


        /// <summary>
        /// Funcion para cambiar el estado de un empleado
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string EstadoEmpleado(bool estado, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Empleados]
                                           SET 
                                                [Estatus_Us] = @estado
                                         WHERE Id_Empleado = @id";
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "El estado del Empleado ya se encuentra inactivo";
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
