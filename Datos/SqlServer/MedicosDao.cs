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
    public class MedicosDao:Connection
    {
        public DataTable DataTableMedicos()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT  [Id_Medico] 'Código'
                                  ,concat([Nombres],' ',[Apellidos]) 'Nombre'
                                  ,[Dni] 'Identidad'
                                  ,[Fecha_Nacimiento] 'Fecha de Nacimiento'
                                  ,[Direccion] 'Dirección'
                                  ,[Telefono] 'Telefono'
	                              ,(select coalesce(count(*),0) from Medicos_Especialidades where Id_Medico = m.Id_Medico) 'Cantidad de Especialidades'
                                  ,[Estatus_us] 'Estado'
                                  ,[Genero] 'Genero'
                                  ,[Fecha_Registro] 'Fecha de Registro'
                                   ,[Fecha_Actualizacion] 'Fecha de Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Medicos] m";

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
        /// Funcion para buscar un medico por id
        /// </summary>
        /// <param name="id">Id del Medico</param>
        /// <returns></returns>
        public bool BuscarMedicoId(int id)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Medicos where Id_Medico = @id";
                        command.Parameters.AddWithValue("@id", id);

                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Medico.IdMedico = reader.GetInt32(0);
                                Cache_Medico.NombreMedico = reader.GetString(1);
                                Cache_Medico.ApellidoMedico = reader.GetString(2);
                                Cache_Medico.DniMedico = reader.GetString(3);
                                Cache_Medico.FechaNacimientoMedico = reader.GetDateTime(4);
                                Cache_Medico.DireccionMedico = reader.GetString(5);
                                Cache_Medico.TelefonoMedico = reader.GetString(6);
                                Cache_Medico.GeneroMedico = reader.GetString(8);
                                Cache_Medico.EstadoMedico = reader.GetBoolean(7);
                                Cache_Medico.FechaRegistroMedico = reader.GetDateTime(9);
                                Cache_Medico.FechaActualizacionMedico = reader.GetDateTime(10);
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
        /// Función para registrar un nuevo Medico
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="genero"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public string NuevoMedico(string nombre, string apellido, string dni, string genero, DateTime fechaNac, string direccion, string telefono)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Medicos]
                                                   ([Nombres]
                                                   ,[Apellidos]
                                                   ,[Dni]
                                                   ,[Fecha_Nacimiento]
                                                   ,[Direccion]
                                                   ,[Telefono]
                                                   ,[Estatus_us]
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
                        return "Medico Registrado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        /// <summary>
        /// Funcion para editar un Medico
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
        public string EditarMedico(string nombre, string apellido, string dni, string genero, DateTime fechaNac, string direccion, string telefono, bool estado, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Medicos]
                                       SET [Nombres] = @nombre
                                          ,[Apellidos] = @apellido
                                          ,[Dni] = @dni
                                          ,[Fecha_Nacimiento] = @fechaNac
                                          ,[Direccion] = @direccion
                                          ,[Telefono] = @telefono
                                          ,[Estatus_us] = @estado
                                          ,[Genero] = @gen
                                          ,[Fecha_Actualizacion] = GETDATE()
                                     WHERE Id_Medico = @id";
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
                        Console.WriteLine("Id: {0}",id);
                        return CMD.ExecuteNonQuery() == 1? "Medico Actualizado con éxito" : "No se pudo actualizar";
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
