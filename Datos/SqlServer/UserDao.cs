using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Soporte.Cache;


namespace Datos
{
    public class UserDao:Connection
    {
        public int Id { get; set; }
        
        public string Cargo { get; set; }


        public DataTable ComboBoxCargo()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT  [Id_Rol],[Nombre_Rol] FROM [Laboratorio_clinico].[dbo].[Roles]";

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


        


        public DataTable DataTableUsuarios()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT u.[id_usuario] 'Código'
                                  ,u.[Nombre_Us] 'Nombre de Usuario'
                                  ,u.[Dni_Us] 'Identidad'
                                  ,u.[Estatus_Us] 'Activo'
                                  ,u.[Correo_Us] 'Correo Electrónico'
                                  ,r.Nombre_Rol 'Cargo'
                                  ,u.[Fecha_Registro] 'Registro'
                                  ,u.[Fecha_Actualizacion] 'Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Usuarios] u
                              join Roles r on u.Id_Rol = r.Id_Rol;";

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

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "RecoverPassword";
                    command.Parameters.AddWithValue("@Nombre_user", userRequesting);
                    
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(0);
                        string userMail = reader.GetString(1);
                        string accountPassword = reader.GetString(2);

                       
                        
                        
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Laboratorio Clínico de Oriente: Recuperar Contraseña",
                            body: "Hola, " + userName + "\nUsted solicitó recuperar su contraseña.\n" +
                                  "Tu pin de recuperación es: " + accountPassword +
                                  "\nUtilice este pin para restablecer su contraseña.",
                            recipientMail: new List<string> { userMail }
                        );
                        return "Hola, " + userName + "\nUsted solicitó recuperar su contraseña.\n" +
                               "Por favor revise su correo electrónico: " + userMail ;
                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con  ese nombre de usuario o número de identidad";
                }
            }
        }


        public bool Login(string usuario, string contrasenia)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Login_Lab";
                        command.Parameters.AddWithValue("@user", usuario);
                        command.Parameters.AddWithValue("@contrasenia", contrasenia);
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Usuario.IdEmpleado = reader.GetInt32(0);
                                Cache_Usuario.NombreEmpleado = reader.GetString(1);
                                Cache_Usuario.ApellidoEmpleado = reader.GetString(2);
                                Cache_Usuario.DniEmpleado = reader.GetString(3);
                                Cache_Usuario.FechaNacimientoEmpleado = reader.GetDateTime(4);
                                Cache_Usuario.GeneroEmpleado = reader.GetString(5);
                                Cache_Usuario.TelefonoEmpleado = reader.GetString(6);
                                Cache_Usuario.DireccionEmpleado = reader.GetString(7);
                                Cache_Usuario.FechaRegistroEmpleado = reader.GetDateTime(8);
                                Cache_Usuario.FechaActualizacionEmpleado = reader.GetDateTime(9);
                                Cache_Usuario.NombreUsuario = reader.GetString(10);
                                Cache_Usuario.DniUsuario = reader.GetString(11);
                                Cache_Usuario.ContraseniaUsuario = reader.GetString(12);
                                Cache_Usuario.EstadoUsuario = reader.GetBoolean(13);
                                Cache_Usuario.FechaRegistroUsuario = reader.GetDateTime(14);
                                Cache_Usuario.FechaActualizacionUsuario = reader.GetDateTime(15);
                                Cache_Usuario.CorreoElectronicoUsuario = reader.GetString(16);
                                Cache_Usuario.IdRol = reader.GetInt32(17);
                                Cache_Usuario.Cargo = reader.GetString(18);
                                Cache_Usuario.IdUsuario = reader.GetInt32(19);

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

        public void obtenerCargos()
        {
            Cache_Cargos.ListaCargos.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Roles";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Cargos.ListaCargos.Add(reader.GetString(1));
                        }
                     
                    }
                   
                }
            }
        }

        public void obtenerPermisos()
        {
            Cache_Cargos.Permisos.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Permisos";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Cargos.Permisos.Add(reader.GetString(1));
                        }

                    }

                }
            }
        }

        public bool buscarUsuarioPorPin(string pin)
        {
           
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id_usuario,Pin_Recuperacion,Fecha_Gen_Pin from Usuarios where Pin_Recuperacion = @pin";
                    command.Parameters.AddWithValue("@pin", pin);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Recuperar_Contraseña.pin = reader.GetString(1);
                            Recuperar_Contraseña.fecha_gen_pin = reader.GetDateTime(2);
                            Recuperar_Contraseña.IdUsuario = reader.GetInt32(0);
                        }

                        return true;

                    }

                    return false;
                }
            }
        }


        public string CambiarContraseña(string Contraseña,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = "CambiarPassword";
                        CMD.Parameters.AddWithValue("@password", Contraseña);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.Parameters.Add("@mensaje", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                        CMD.CommandType = CommandType.StoredProcedure;
                        CMD.ExecuteNonQuery();
                        return CMD.Parameters["@mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string NuevoUsuario(string Contraseña, string dni, string correo, string user,int id_rol)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = "[Registrar_Usuario]";
                        CMD.Parameters.AddWithValue("@Contrasenia_Us", Contraseña);
                        CMD.Parameters.AddWithValue("@Nombre_us", user);
                        CMD.Parameters.AddWithValue("@Dni_Us", dni);
                        CMD.Parameters.AddWithValue("@Id_Rol", id_rol);
                        CMD.Parameters.AddWithValue("@Correo_Us", correo);
                        CMD.Parameters.Add("@mensaje", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                        CMD.CommandType = CommandType.StoredProcedure;
                        CMD.ExecuteNonQuery();
                        return CMD.Parameters["@mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string EditarUsuario(string Contraseña, string dni ,string correo,string user)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = "Editar_Usuario";
                        CMD.Parameters.AddWithValue("@Contrasenia_Us", Contraseña);
                        CMD.Parameters.AddWithValue("@Nombre_us", user);
                        CMD.Parameters.AddWithValue("@Dni_Us", dni);

                        CMD.Parameters.AddWithValue("@Correo_Us", correo);
                        CMD.Parameters.Add("@mensaje", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                        CMD.CommandType = CommandType.StoredProcedure;
                        CMD.ExecuteNonQuery();
                        return CMD.Parameters["@mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string EditarDatosEmpleado(string nombre, string apellido, DateTime fechaNac, string direccion, string telefono, string genero,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"Update Empleados 
                                            set Nombre_Empleado = @nombre,
                                            Apellido_Empleado = @apellido,
                                            Genero = @gen,
                                            Fecha_Nacimiento = @fecha,
                                            Direccion_Empleado = @direccion,
                                            Telefono_Empleado = @tel,
                                            Fecha_Actualizacion = GETDATE()
                                            where Id_Empleado = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@apellido", apellido);
                        CMD.Parameters.AddWithValue("@fecha", fechaNac);
                        CMD.Parameters.AddWithValue("@direccion", direccion);
                        CMD.Parameters.AddWithValue("@tel", telefono);
                        CMD.Parameters.AddWithValue("@gen", genero);
                        CMD.Parameters.AddWithValue("@id", id);


                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Datos del Empleado Actualizados";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }


        public string EditarDatosMedico(string nombre, string apellido, DateTime fechaNac, string direccion, string telefono, string genero, int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"Update Medicos 
                                            set Nombres = @nombre,
                                            Apellidos = @apellido,
                                            Genero = @gen,
                                            Fecha_Nacimiento = @fecha,
                                            Direccion = @direccion,
                                            Telefono = @tel,
                                            Fecha_Actualizacion = GETDATE()
                                            where Id_Medico = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@apellido", apellido);
                        CMD.Parameters.AddWithValue("@fecha", fechaNac);
                        CMD.Parameters.AddWithValue("@direccion", direccion);
                        CMD.Parameters.AddWithValue("@tel", telefono);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.Parameters.AddWithValue("@gen", genero);


                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Datos del Medico Actualizados";
                    }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }



        public void obtenerPermisosUsuario(int idRol)
        {
            Cache_Usuario.Permisos.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"Select p.Permiso from Roles r
                    join Roles_Permisos Rp on r.Id_Rol = Rp.Id_Rol
                    join Permisos P on Rp.Id_Permiso = P.Id_Permiso
                    where R.Id_Rol = @id";
                    command.Parameters.AddWithValue("@id", idRol);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Usuario.Permisos.Add(reader.GetString(0));
                        }

                    }

                }
            }
        }

        public bool existsUser(int id, string loginName, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "[Verificar_Usuario]";
                    command.Parameters.AddWithValue("@Id_Usuario", id);
                    command.Parameters.AddWithValue("@user", loginName);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
