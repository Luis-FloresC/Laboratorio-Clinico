using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
   public class ReporteModel
    {
        public DateTime reportDate { get; private set; }
        public DateTime fromDate { get; private set; }
        public DateTime toDate { get; private set; }
        public int totalUsuario { get; private set; }

        public string Mes { get;private set; }

        private EmpleadosModel empleados = new EmpleadosModel();
        private UserModel userModel = new UserModel();
        private ExamenesDao examenes = new ExamenesDao();
        private MedicosDao medicosDao = new MedicosDao();
        private SeguridadModel seguridadModel = new SeguridadModel();
        private FacturacionDao facturacion = new FacturacionDao();

        private InventarioDao inventario = new InventarioDao();
        public List<Reportes> ListUsuarios = new List<Reportes>();
        public List<Reportes> VentasPorPeriodo = new List<Reportes>();
        public List<Reportes> VentasPorMes = new List<Reportes>();
        public List<Reportes> ListExamenesTop = new List<Reportes>();
        public List<Reportes> ListMedicos = new List<Reportes>();
        public string Categoria { get; set; }
        public List<Reportes> ListaExamenesPorArea = new List<Reportes>();

        public List<Reportes> ListaInventario = new List<Reportes>();


        /**
         * u.[id_usuario] 'Código'
                                  ,u.[Nombre_Us] 'Nombre de Usuario'
                                  ,u.[Dni_Us] 'Identidad'
                                  ,u.[Estatus_Us] 'Activo'
                                  ,u.[Correo_Us] 'Correo Electrónico'
                                  ,r.Nombre_Rol 'Cargo'
                                  ,u.[Fecha_Registro] 'Registro'
                                  ,u.[Fecha_Actualizacion] 'Actualización'
         */
        public void ReporteListaDeUsuarios()
        {
            reportDate = DateTime.Now;
            var result = userModel.DataTableUsuarios();

            ListUsuarios = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newUsuario = new Reportes()
                {
                    
                    NombreUsuario = row[1].ToString(),
                    CorreoElectronicoUsuario = row[4].ToString(),
                    DniUsuario = Convert.ToString(row[2]),
                    FechaRegistroUsuario = Convert.ToDateTime(row[6]),
                    FechaActualizacionUsuario = Convert.ToDateTime(row[7]),
                    EstadoUsuario = Convert.ToBoolean(row[3]) ? "Activo" : "Inactivo"

                };

                ListUsuarios.Add(newUsuario);
                totalUsuario++;
            }
        }

        public void ReporteListaDeExamenesPorArea(string area)
        {
            reportDate = DateTime.Now;
            Categoria = area;
            var result = examenes.DataTableExamenesPorArea(area);

            ListaExamenesPorArea = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newExamen = new Reportes()
                { 
                      NombreExamen = row[0].ToString(),
                      PrecioExamen = Convert.ToDecimal(row[1]),
                      FechaRegistroExamen = Convert.ToDateTime(row[2])
                };

                ListaExamenesPorArea.Add(newExamen);
                totalUsuario++;
            }
        }


        /**
         *   i.Id_Inventario 'Codigo',
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
        public void ReporteInventario()
        {
            reportDate = DateTime.Now;
            var result = inventario.DataTableInventario();

            ListaInventario = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newInventario = new Reportes()
                {

                    idInventario = Convert.ToInt32(row[0]),
                    NombreProducto = row[1].ToString(),
                    CantidadProducto = Convert.ToInt32(row[2]),
                    NombreProveedor = Convert.ToString(row[3]),
                    PrecioProducto = Convert.ToDecimal(row[4]),
                    Ubicacion = Convert.ToString(row[5]),
                    FechaCompraProducto = Convert.ToDateTime(row[6]),

                    FechaRegistroProducto = Convert.ToDateTime(row[7]),
                    FechaActualizacionUsuario = Convert.ToDateTime(row[8]),
                };

                ListaInventario.Add(newInventario);
                
            }
        }



        /**
         *   f.Id_Facturacion '#Referencia',
                                    CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente',
                                    u.Nombre_Us 'Usuario',
                                    f.Sub_Total 'Sub Total',
                                    f.ISV  'Isv',
                                    f.descuento 'Descuento',
                                    (f.Sub_Total + f.ISV) - (f.descuento) 'Total'
         */
        public void ReporteVentas(DateTime fecha1,DateTime fecha2)
        {
            reportDate = DateTime.Now;
            fromDate = fecha1;
            toDate = fecha2;
            var result = facturacion.DataTableFacturacionPorFecha(fecha1,fecha2);

            VentasPorPeriodo = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newVenta = new Reportes()
                {

                    ReferenciaVenta = Convert.ToInt32(row[0]),
                    PacienteVenta = row[1].ToString(),
                    Usuario = row[2].ToString(),
                    SubTotal = Convert.ToDecimal(row[3]),
                    ISV = Convert.ToDecimal(row[4]),
                    Descuento = Convert.ToDecimal(row[5]),
                    Total = Convert.ToDecimal(row[6]),

                };

                VentasPorPeriodo.Add(newVenta);

            }
        }


        public void ReporteVentasPorMes(string mes,int NumMes)
        {
            reportDate = DateTime.Now;
            Mes = mes;
            var result = facturacion.DataTableVentasPorMes(NumMes);

            VentasPorMes = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newVenta = new Reportes()
                {

                    ReferenciaVenta = Convert.ToInt32(row[0]),
                    PacienteVenta = row[1].ToString(),
                    Usuario = row[2].ToString(),
                    SubTotal = Convert.ToDecimal(row[3]),
                    ISV = Convert.ToDecimal(row[4]),
                    Descuento = Convert.ToDecimal(row[5]),
                    Total = Convert.ToDecimal(row[6]),

                };

                VentasPorMes.Add(newVenta);

            }
        }


        public void ReporteExamenesTop()
        {
            reportDate = DateTime.Now;
            
            var result = examenes.DataTableExamenesTop();

            ListExamenesTop = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var NewExamen = new Reportes()
                {

                   NombreExamen = row[0].ToString(),
                   CategoriaExamen = row[1].ToString(),
                   Total = Convert.ToDecimal(row[2])

                };

                ListExamenesTop.Add(NewExamen);

            }
        }

        /**
         * [Id_Medico] 'Código'
                                  ,concat([Nombres],' ',[Apellidos]) 'Nombre'
                                  ,[Dni] 'Identidad'
                                  ,[Fecha_Nacimiento] 'Fecha de Nacimiento'
                                  ,[Direccion] 'Dirección'
                                  ,[Telefono] 'Telefono'
	                              ,(select coalesce(count(*),0) from Medicos_Especialidades where Id_Medico = m.Id_Medico) 'Cantidad de Especialidades'
                                  ,[Estatus_us] 'Estado'
                                  ,[Genero] 'Genero'
                                  ,[Fecha_Registro] 'Fecha de Registro'
                                   ,[Fecha_Actualizacion] 'Fecha de Actualización'
                              FROM [Laboratorio_clinico].[dbo].[Medicos] m"
         */
        public void ReporteListaDeMedicos()
        {
            reportDate = DateTime.Now;
            var result = medicosDao.DataTableMedicos();

            ListMedicos = new List<Reportes>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var newMeddico = new Reportes()
                {
                    IdMedico = Convert.ToInt32(row[0]),
                    NombreMedico = row[1].ToString(),
                    DniMedico = row[2].ToString(),
                    FechaNacimientoMedico = Convert.ToDateTime(row[3]),
                    DireccionMedico = row[4].ToString(),
                    TelefonoMedico = row[5].ToString(),
                    EstadoMedico = Convert.ToBoolean(row[7]),
                    GeneroMedico = row[8].ToString(),
                    FechaRegistroMedico = Convert.ToDateTime(row[9]),
                    FechaActualizacionMedico = Convert.ToDateTime(row[10])
                };

                ListMedicos.Add(newMeddico);
              
            }
        }
    }
}
