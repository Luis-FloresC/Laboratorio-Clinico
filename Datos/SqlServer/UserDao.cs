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

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Nombre_Us=@user or Dni_Us=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(5);
                        string accountPassword = reader.GetString(1);
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: Password recovery request",
                            body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                                  "your current password is: " + accountPassword +
                                  "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            recipientMail: new List<string> { userMail }
                        );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                               "Please check your mail: " + userMail +
                               "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                        return "Sorry, you do not have an account with that mail or username";
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
