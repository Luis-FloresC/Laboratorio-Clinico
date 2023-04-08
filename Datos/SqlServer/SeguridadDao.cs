using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soporte.Cache;

namespace Datos.SqlServer
{
    public class SeguridadDao:Connection
    {
        public DataTable DataTablePermisos()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT [Id_Permiso] 'Codigo'
                                      ,[Descripcion] 'Permiso'
                                      ,[Fecha_Registro] 'Fecha de Registro'
                                      ,[Fecha_Actualizacion] 'Fecha de Actualizacion'
                                  FROM [Laboratorio_clinico].[dbo].[Permisos]";

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


        public DataTable DataTableRoles()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT [Id_Rol] 'Codigo'
                                  ,[Nombre_Rol] 'Cargo'
	                              ,Estatus_Rol 'Activo'
                                  ,[Fecha_Registro] 'Fecha de Registro'
                                  ,[Fecha_Actualizacion] 'Fecha de Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Roles]";

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

        public void obtenerTodosLosPermisos()
        {
            Cache_Cargos.ListaPermisosList.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from [Permisos] where Permiso not in ('btn_Cerrar');";
                   
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Cargos.ListaPermisosList.Add(new Seguridad{descripcion = reader.GetString(2) ,IdPermiso = reader.GetInt32(0),NombrePermiso = reader.GetString(1)});
                        }

                    }

                }
            }
        }

       

        public void PermisosPorRol(int idRol)
        {
            Cache_Cargos.ListaPermisosPorRolList.Clear();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select p.* from [Permisos] p
                    join Roles_Permisos rp on rp.Id_Permiso = p.Id_Permiso
                    where rp.Id_Rol = @idRol";
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Cargos.ListaPermisosPorRolList.Add(new Seguridad { descripcion = reader.GetString(2), IdPermiso = reader.GetInt32(0), NombrePermiso = reader.GetString(1) });
                        }

                    }

                }
            }
        }


        public void AsignarPermisos(int idRol,string permiso,int estado)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"[AsignarPermisos]";
                        CMD.Parameters.AddWithValue("@idRol", idRol);
                        CMD.Parameters.AddWithValue("@permiso", permiso);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.CommandType = CommandType.StoredProcedure;
                        CMD.ExecuteNonQuery();
                       
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }

        public string NuevoRol(string nombre,bool estado)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"insert into Roles (Nombre_Rol,Estatus_Rol) values(@nombre,@estado);
                                            insert into Roles_Permisos(Id_Rol,Id_Permiso) values ((select Id_Rol from Roles where Nombre_Rol = @nombre),(select Id_Permiso from Permisos where Permiso = 'btn_Cerrar'));";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Cargo Registrado con Éxito";
                    }
                }
            }
            catch (Exception ex)
            {

                return(ex.ToString());
            }

        }

        public string EdiatrRol(string nombre, bool estado,int id)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"UPDATE [dbo].[Roles]
                                           SET [Nombre_Rol] = @nombre
                                              ,[Estatus_Rol] = @estado
                                              ,[Fecha_Actualizacion] = GETDATE()
                                         WHERE Id_Rol = @id";
                        CMD.Parameters.AddWithValue("@nombre", nombre);
                        CMD.Parameters.AddWithValue("@estado", estado);
                        CMD.Parameters.AddWithValue("@id", id);
                        CMD.CommandType = CommandType.Text;
                        if (CMD.ExecuteNonQuery()== 1)
                        {
                            return "Cargo Actualizado con Éxito";
                        }
                        else
                        {
                            return "No se Pudo Actualizar el cargo";
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {

                return (ex.ToString());
            }

        }

    }
}
