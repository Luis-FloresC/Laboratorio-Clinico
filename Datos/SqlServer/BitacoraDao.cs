using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
    public class BitacoraDao:Connection
    {

        public DataTable DataTableBitacora()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT B.[Id_Bitacora] 'Código'
                                  ,B.[Fecha_Registro] 'Fecha'
                                  ,B.[Tipo_Evento] 'Evento'
                                  ,B.[Descripcion_Evento] 'Descripcion del Evento'
                                  ,U.Nombre_Us 'Nombre de Usuario'
                              FROM [Laboratorio_clinico].[dbo].[Bitacora] B
                              join Usuarios U ON U.id_usuario = B.Id_Usuario";

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


        public int TotalRegistros()
        {
            int total = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select coalesce(count(*),0)'Total' from Bitacora";
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

        public DataTable DataTableBitacora(int inicio,int final)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    B.RowN as '#'
                                    ,B.[Fecha_Registro] 'Fecha'
                                    ,B.[Tipo_Evento] 'Evento'
                                    ,B.[Descripcion_Evento] 'Descripcion del Evento'
								    ,(select Nombre_Us from Usuarios where id_usuario = B.Id_Usuario) 'Usuario'
                                    from (
	                                    Select 
	                                    ROW_NUMBER () over (Order by [Id_Bitacora] desc) as 'RowN',
	                                    *
	                                    from Bitacora 
                                    ) B
                                    where RowN between @inicio and @fin
                                    order by RowN";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@inicio", inicio);
                    cmd.Parameters.AddWithValue("@fin", final);
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

        public string NuevaActividad(string TipoEvento,string DescripcionEvento,int idUsuario)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"INSERT INTO [dbo].[Bitacora]
                                               ([Fecha_Registro]
                                               ,[Tipo_Evento]
                                               ,[Descripcion_Evento]
                                               ,[Id_Usuario])
                                         VALUES
                                               (GETDATE()
                                               ,@tipoEvento
                                               ,@descEvento
                                               ,@id)";
                        CMD.Parameters.AddWithValue("@tipoEvento", TipoEvento);
                        CMD.Parameters.AddWithValue("@descEvento", DescripcionEvento);
                        CMD.Parameters.AddWithValue("@id", idUsuario);

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
    }
}
