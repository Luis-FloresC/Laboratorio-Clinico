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
 

         /// <summary>
         /// Funcion para obtener los roles y cargarlos a un combobox
         /// </summary>
         /// <returns>Lista de Roles</returns>
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


        /// <summary>
        /// Función para obtener una lista de usuarios
        /// </summary>
        /// <returns>Lista de todos los Usuarios</returns>
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


        /// <summary>
        /// Funcion para listar todos los empleados y medicos
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public DataTable BuscarPersonal(string filtro = "All")
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"[BuscarPersonal]";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@filtro", filtro);
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

        /// <summary>
        /// Funcion para cuando el usuario olvide su contraseña lo cual se enviara un pin a su correo electronico que tiene registrado
        /// en nuestra base de datos
        /// </summary>
        /// <param name="userRequesting">Nombre de Usuario o Identidad</param>
        /// <returns>Mensaje de confirmación de envio de Correo</returns>
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

        /// <summary>
        /// Funcion para iniciar sesión en el sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcion para buscar un usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool BuscarUsuarioPorId(int id)
        {
            try{
            
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT [id_usuario]
                                                  ,[Nombre_Us]
                                                  ,[Dni_Us]
                                                  ,CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', Contrasenia_Us)) 'Contrasenia'
                                                  ,[Estatus_Us]
                                                  ,[Correo_Us]
                                                  ,[Intentos_Us]
                                                  ,[Pin_Recuperacion]
                                                  ,[Fecha_Gen_Pin]
                                                  ,[Id_Rol]
                                                  ,[Fecha_Bloqueo]
                                                  ,[Motivo_Bloqueo]
                                                  ,[Fecha_Desbloqueo]
                                                  ,[Descripcion_Bloqueo]
                                                  ,[Fecha_Registro]
                                                  ,[Fecha_Actualizacion]
                                              FROM [Laboratorio_clinico].[dbo].[Usuarios] where id_usuario = @id";
                        command.Parameters.AddWithValue("@id", id);
                        
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Cache_Usuario.IdUsuarioEdit = reader.GetInt32(0);
                                Cache_Usuario.NombreUs = reader.GetString(1);
                                Cache_Usuario.DniUs = reader.GetString(2);
                                Cache_Usuario.ContraseniaUs = reader.GetString(3);
                                Cache_Usuario.EstadoUs = reader.GetBoolean(4);
                                Cache_Usuario.CorreoElectronicoUs = reader.GetString(5);
                                Cache_Usuario.IntentosUs = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);

                                Cache_Usuario.PinUs = reader.IsDBNull(7) ? null : reader.GetString(7);
                                Cache_Usuario.FechaGenPinUs = reader.IsDBNull(8) ? DateTime.Now : reader.GetDateTime(8);
                                Cache_Usuario.IdRolUs = reader.IsDBNull(9) ? -1 : reader.GetInt32(9);
                                Cache_Usuario.FechaBloqueoUs = reader.IsDBNull(10) ? DateTime.Now : reader.GetDateTime(10);
                                Cache_Usuario.MotivoBloqueoUs = reader.IsDBNull(11) ? null : reader.GetString(11);
                                Cache_Usuario.FechaDesbloqueoUs = reader.IsDBNull(12) ? DateTime.Now : reader.GetDateTime(12);
                                Cache_Usuario.DescripcionBloqueoUs = reader.IsDBNull(13) ?  null: reader.GetString(13);
                               
                                Cache_Usuario.FechaRegistroUs = reader.GetDateTime(14);
                                Cache_Usuario.FechaActualizacionUs = reader.GetDateTime(15);
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
        /// Funcion para obtener todos los cargos
        /// </summary>
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
       
      

        /// <summary>
        /// Funcion para buscar Usuario por pin de recuperacion
        /// </summary>
        /// <param name="pin">pin de recuperacion que recibe el usuario</param>
        /// <returns>Respuesta verdadera si el pin esta correcto</returns>
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

        /// <summary>
        /// Función para cambiar la Contraseña
        /// </summary>
        /// <param name="Contraseña">Nueva Contraseña</param>
        /// <param name="id">Id del Usuario</param>
        /// <returns>Mensaje de Confirmación</returns>
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

        /// <summary>
        /// Funcion para agregar un nuevo usuario a la base de datos
        /// </summary>
        /// <param name="Contraseña">Contraseña</param>
        /// <param name="dni">Identidad</param>
        /// <param name="correo">Correo Electronico</param>
        /// <param name="user">Nombre de Usuario</param>
        /// <param name="id_rol">Id dell Cargo</param>
        /// <returns>Mensaje de Confirmación</returns>
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

        /// <summary>
        /// Funcion para editar Usuario 
        /// </summary>
        /// <param name="Contraseña">Contraseña</param>
        /// <param name="dni">Identidad</param>
        /// <param name="correo">Correo Electronico</param>
        /// <param name="user">Nombre de Usuario</param>
        /// <returns></returns>
        public string EditarUsuario(string Contraseña, string dni ,string correo,string user,int idRol)
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
                        CMD.Parameters.AddWithValue("@id_Rol", idRol);
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

        /// <summary>
        /// Funcion para editar los datos del usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="genero"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Funcion para editar los datos del usuario que inicio sesión
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="genero"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Funcion para obtener los permisos del usuario
        /// </summary>
        /// <param name="idRol"></param>
        public void obtenerPermisosUsuario(int idRol)
        {
            Cache_Cargos.Permisos.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"[PermisoUsuario]";
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Cargos.Permisos.Add(new Seguridad(){IdPermiso = reader.GetInt32(1),NombrePermiso = reader.GetString(2),descripcion = reader.GetString(3),EstadoRol = reader.GetInt32(4),PosX = reader.GetInt32(6),PosY = reader.GetInt32(7),idPos = reader.GetInt32(5)});
                        }

                    }

                }
            }
        }

        /// <summary>
        /// Funcion para validar que el usuario exista
        /// </summary>
        /// <param name="id">id del usuario</param>
        /// <param name="loginName">Nombre de Usuario o Dni</param>
        /// <param name="pass">Contraseña</param>
        /// <returns></returns>
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
