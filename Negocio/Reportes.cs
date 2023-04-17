using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Reportes
    {
        //Reporte de Uusario
        public  string NombreUsuario { get; set; }
        public  string DniUsuario { get; set; }
        public  string  EstadoUsuario { get; set; }

        public  string CorreoElectronicoUsuario { get; set; }
        public  DateTime FechaRegistroUsuario { get; set; }
        public  DateTime FechaActualizacionUsuario { get; set; }


        //Reporte de Inventario

        /**
         * "select 
                                    i.Id_Inventario 'Codigo',
                                    p.Nombre_Producto 'Nombre del Producto',
                                    p.Cantidad_Stock 'Cantidad del Producto' ,
                                    p.Nombre_Proveedor 'Proveedor',
                                    p.Precio_Producto 'Precio',
                                    i.Ubicacion_Almacenamiento 'Ubicación',
                                    i.Fecha_Compra 'Fecha de Compra',
                                    i.Fecha_Registro 'Fecha de Registro',
                                    i.Fecha_Actualizacion 'Fecha de Actualización'
                                    from Inventario i
                                    join Productos p on p.Id_Producto = i.Id_Producto"
         */

        

        public int idInventario { get; set; }
        public string NombreProducto { get; set; }
        public string NombreProveedor { get; set; }
        public int CantidadProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaCompraProducto { get; set; }

        public DateTime FechaRegistroProducto { get; set; }
        public DateTime FechaActualizacionProducto { get; set; }



        //Reportes de Examenes

        public string NombreExamen { get; set; }
        public string CategoriaExamen { get; set; }
        public decimal PrecioExamen { get; set; }
        public DateTime FechaRegistroExamen { get; set; }


        //Reporte de Ventas

        /**
         *   f.Id_Facturacion '#Referencia',
                                    CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente',
                                    u.Nombre_Us 'Usuario',
                                    f.Sub_Total 'Sub Total',
                                    f.ISV  'Isv',
                                    f.descuento 'Descuento',
                                    (f.Sub_Total + f.ISV) - (f.descuento) 'Total'
         */


        public int ReferenciaVenta { get; set; }
        public string PacienteVenta { get; set; }
        public string Usuario { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }


        //Medicos

        public int IdMedico { get; set; }
        public string NombreMedico { get; set; }
        public string ApellidoMedico { get; set; }
        public string DniMedico { get; set; }
        public DateTime FechaNacimientoMedico { get; set; }
        public string GeneroMedico { get; set; }
        public bool EstadoMedico { get; set; }
        public string TelefonoMedico { get; set; }
        public string DireccionMedico { get; set; }
        public DateTime FechaRegistroMedico { get; set; }
        public DateTime FechaActualizacionMedico { get; set; }
    }
}
