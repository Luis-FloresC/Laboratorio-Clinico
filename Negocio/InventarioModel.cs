using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
   public class InventarioModel
    {
        private InventarioDao inventario = new InventarioDao();

        public DataTable DataTableInventario()
        {
            return inventario.DataTableInventario();
        }

        public string NuevoInventario(string nombre, string proveedor, int cantidad, string numeroSerial,
            decimal precio, string ubicacion, DateTime fechaCompra)
        {
            return inventario.NuevoInventario(nombre, proveedor, cantidad, numeroSerial, precio, ubicacion,
                fechaCompra);
        }

        public string EditarInventario(string nombre, string proveedor, int cantidad, 
            decimal precio, string ubicacion, DateTime fechaCompra,int id)
        {
            return inventario.EditarInventario(nombre, proveedor, cantidad, precio, ubicacion,
                fechaCompra,id);
        }

    }
}
