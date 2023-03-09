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
    }
}
