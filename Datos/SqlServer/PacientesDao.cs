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
    public class PacientesDao: Connection
    {

        /**
         * Funcion para cargar datos en el datagridview
         */
        public DataTable DataTablePacientes()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    p.RowN as '#',
                                    CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) as 'Nombre Completo',
                                    p.Dni_Paciente 'Dni',
                                    p.Telefono_Paciente as 'Telefono',
                                    p.Genero as 'Genero',
                                    p.Estatus_Us 'Activo',
                                    p.Id_Paciente 'Código'
                                    from (
	                                    Select 
	                                    ROW_NUMBER () over (Order by [Id_Paciente] desc) as 'RowN',
	                                    *
	                                    from Pacientes
                                    ) p
                                    order by Id_Paciente desc";

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


        /**
         * Funcion para buscar un pacientes
         */
        public bool BuscarPacienteId(int id)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Pacientes where Id_Paciente = @id";
                        command.Parameters.AddWithValue("@id", id);
                        
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Pacientes.IdPaciente = reader.GetInt32(0);
                                Cache_Pacientes.NombrePaciente = reader.GetString(1);
                                Cache_Pacientes.ApellidoPaciente = reader.GetString(2);
                                Cache_Pacientes.DniPaciente = reader.GetString(3);
                                Cache_Pacientes.FechaNacimientoPaciente = reader.GetDateTime(4);
                                Cache_Pacientes.DireccionPaciente = reader.GetString(5);
                                Cache_Pacientes.TelefonoPaciente = reader.GetString(6);
                                Cache_Pacientes.GeneroPaciente = reader.GetString(7);
                                Cache_Pacientes.EstadoPaciente = reader.GetBoolean(8);
                                Cache_Pacientes.FechaRegistroPaciente = reader.GetDateTime(9);
                                Cache_Pacientes.FechaActualizacionPaciente = reader.GetDateTime(10);
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

        public DataTable DataTablePacientes(int inicio = 1,int final= 10)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"[ListaPacientes]";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@inicio", inicio);
                    cmd.Parameters.AddWithValue("@fin", final);
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public int TotalPacientes()
        {
            int total=0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select coalesce(count(*),0)'Total' from Pacientes";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            total = reader.GetInt32(0);
                        }

                        return total;
                    }

                }

            }
            return total;
        }

        /*
         *
         * Id_Paciente int primary key identity(1,1),
	Nombre_Paciente nvarchar(50) not null,
	Apellido_Paciente nvarchar(50) not null,
	Dni_Paciente nvarchar(50) not null,
	Fecha_Nacimiento date not null,
	Direccion_Paciente nvarchar(250) null,
	Telefono_Paciente nvarchar(8) null,
	Genero nvarchar(50) check(Genero in ('Masculino','Femenino')) not null,
	Estatus_Us BIT,
         */
        public string NuevoPaciente(string nombre,string apellido,string dni,string genero,DateTime fechaNac, string direccion,string telefono)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Pacientes]
                                           ([Nombre_Paciente]
                                           ,[Apellido_Paciente]
                                           ,[Dni_Paciente]
                                           ,[Fecha_Nacimiento]
                                           ,[Direccion_Paciente]
                                           ,[Telefono_Paciente]
                                           ,[Genero]
                                           ,[Estatus_Us])
                                     VALUES
                                           (@nombre
                                           ,@apellido
                                           ,@dni
                                           ,@fechaNac
                                           ,@direccion
                                           ,@telefono
                                           ,@gen
                                           ,1)";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@apellido", apellido);
                        CMD.Parameters.AddWithValue("@dni", dni);
                        CMD.Parameters.AddWithValue("@fechaNac", fechaNac);
                        CMD.Parameters.AddWithValue("@direccion", direccion);
                        CMD.Parameters.AddWithValue("@telefono", telefono);
                        CMD.Parameters.AddWithValue("@gen", genero);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Paciente Registrado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string EditarPaciente(string nombre, string apellido, string dni, string genero, DateTime fechaNac, string direccion, string telefono,bool estado,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Pacientes]
                                           SET [Nombre_Paciente] = @nombre
                                              ,[Apellido_Paciente] = @apellido
                                              ,[Dni_Paciente] = @dni
                                              ,[Fecha_Nacimiento] = @fechaNac
                                              ,[Direccion_Paciente] = @direccion
                                              ,[Telefono_Paciente] = @telefono
                                              ,[Genero] = @gen
                                              ,[Estatus_Us] = @estado
                                              ,[Fecha_Actualizacion] = GETDATE()
                                         WHERE Id_Paciente = @id";
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
                        return "Paciente Actualizado con éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }


        public string EstadoPaciente(bool estado, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Pacientes]
                                           SET 
                                                [Estatus_Us] = @estado
                                         WHERE Id_Paciente = @id";
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "El estado del paciente ya se encuentra inactivo";
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
