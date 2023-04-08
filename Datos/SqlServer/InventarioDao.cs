using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SqlServer
{
   public class InventarioDao: Connection
    {

        public DataTable DataTableInventario()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"select 
                                    i.Id_Inventario 'Codigo',
                                    p.Nombre_Producto 'Nombre del Producto',
                                    p.Cantidad_Stock 'Cantidad del Producto' ,
                                    p.Nombre_Proveedor 'Proveedor',
                                    p.Precio_Producto 'Precio',
                                    i.Fecha_Compra 'Fecha de Compra',
                                    i.Fecha_Registro 'Fecha de Registro',
                                    i.Fecha_Actualizacion 'Fecha de Actualización'
                                    from Inventario i
                                    join Productos p on p.Id_Producto = i.Id_Producto";

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



        /*
         * @nombreProducto = N'Placas de TLC',
		@nombreProveedor = N'Avantor',
		@cantidad = 15,
		@precio = 200,
		@numeroSerial = N'QWTH1234UH',
		@ubicacion = N'Estante #1',
		@fechaCompra = N'2023-04-07',
         */
        public string NuevoInventario(string nombre, string proveedor, int cantidad, string numeroSerial, decimal precio,string ubicacion,DateTime fechaCompra)
        {

            try
            {
                using (var CN = GetConnection())
                {
                    CN.Open();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CN;
                        CMD.CommandText = "[nuevoInventario]";
                        CMD.Parameters.AddWithValue("@nombreProducto", nombre);
                        CMD.Parameters.AddWithValue("@nombreProveedor", proveedor);
                        CMD.Parameters.AddWithValue("@cantidad", cantidad);
                        CMD.Parameters.AddWithValue("@precio", precio);
                        CMD.Parameters.AddWithValue("@numeroSerial", numeroSerial);
                        CMD.Parameters.AddWithValue("@ubicacion", ubicacion);
                        CMD.Parameters.AddWithValue("@fechaCompra", fechaCompra);
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

    }
}
