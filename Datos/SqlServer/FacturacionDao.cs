using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
  public  class FacturacionDao : Connection
    {
        public DataTable DataTableFacturacion()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    f.Id_Facturacion 'Codigo'
                                    ,f.Fecha_Facturacion 'Fecha de Facturacion'
                                    ,(select CONCAT(Nombre_Paciente,' ',Apellido_Paciente) from Pacientes where Id_Paciente = f.Id_Paciente) 'Paciente'
                                    ,coalesce(CONCAT(e.Nombre_Empleado,' ',e.Apellido_Empleado) ,(select concat(Nombres,' ',Apellidos) from Medicos where Dni = u.Dni_Us)) 'Empleado'
                                    ,f.Sub_Total 'Sub Total'
                                    ,f.ISV 'ISV'
                                    ,f.descuento 'Descuento'
                                    from Facturacion f
                                    join Usuarios u on u.id_usuario = f.Id_Usuario
                                    join Empleados e on e.Dni_Empleado = u.Dni_Us";

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

        public DataTable DataTableFacturacionPorFecha(DateTime fecha1,DateTime fecha2)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    f.Id_Facturacion '#Referencia',
                                    CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente',
                                    u.Nombre_Us 'Usuario',
                                    f.Sub_Total 'Sub Total',
                                    f.ISV  'Isv',
                                    f.descuento 'Descuento',
                                    (f.Sub_Total + f.ISV) - (f.descuento) 'Total'
                                    from Facturacion f
                                    join Pacientes p on p.Id_Paciente = f.Id_Paciente
                                    join Usuarios u on u.id_usuario = f.Id_Usuario
                                    where Fecha_Facturacion between @fecha1 and @fecha2";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@fecha1", fecha1);
                    cmd.Parameters.AddWithValue("@fecha2", fecha2);
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


        public DataTable DataTableVentasPorMes(int numMes)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    f.Id_Facturacion '#Referencia',
                                    CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente',
                                    u.Nombre_Us 'Usuario',
                                    f.Sub_Total 'Sub Total',
                                    f.ISV  'Isv',
                                    f.descuento 'Descuento',
                                    (f.Sub_Total + f.ISV) - (f.descuento) 'Total'
                                    from Facturacion f
                                    join Pacientes p on p.Id_Paciente = f.Id_Paciente
                                    join Usuarios u on u.id_usuario = f.Id_Usuario
                                    where MONTH(f.Fecha_Facturacion) = @mes";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@mes", numMes);
                    
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


        public int nuevaFactura(int idExamen,int idUser,decimal subtotal,decimal isv,decimal descuento)
        {
            int total = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"declare @idPaciente int = (select Id_Paciente from Examenes_Medicos where Id_Examen_Med = @idExamen) 

                    insert into Facturacion(Fecha_Facturacion, Id_Paciente, Id_Usuario, Sub_Total, ISV, descuento)
                    values(GETDATE(), @idPaciente, @idUser, @subtotal, @isv, @descuento)


                    select coalesce(max(Id_Facturacion),0) 'maxId' from Facturacion";
                    command.Parameters.AddWithValue("@idExamen", idExamen);
                    command.Parameters.AddWithValue("@idUser", idUser);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@isv", isv);
                    command.Parameters.AddWithValue("@descuento", descuento);
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

        public string NuevoDetalleFactura(int idFact,int idExamenMed,int cantidad,decimal precio)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = @"declare @idExamen int = (select Id_Examen from Examenes_Medicos_Detalles where Id_Examen_Med = @idExamenMed)

                                            insert into Detalle_Facturacion(Id_Facturacion,Id_Examen,Cantidad,Precio)
                                            values(@idFact,@idExamen,@cantidad,@precio)";
                        CMD.Parameters.AddWithValue("@idFact", idFact);
                        CMD.Parameters.AddWithValue("@idExamenMed", idExamenMed);
                        CMD.Parameters.AddWithValue("@cantidad", cantidad);
                        CMD.Parameters.AddWithValue("@precio", precio);
                        CMD.CommandType = CommandType.Text;
                        CMD.ExecuteNonQuery();
                        return "Factura Registrada con éxito";
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
