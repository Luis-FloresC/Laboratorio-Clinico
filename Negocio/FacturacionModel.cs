using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
   public class FacturacionModel
   {
       private FacturacionDao facturacionDao = new FacturacionDao();

       public DataTable DataTableFactturacion()
       {
           return facturacionDao.DataTableFacturacion();
       }

       public int nuevaFactura(int idExamen, int idUser, decimal subtotal, decimal isv, decimal descuento)
       {
           return facturacionDao.nuevaFactura(idExamen, idUser, subtotal, isv, descuento);
       }

       public string NuevoDetalleFactura(int idFact, int idExamenMed, int cantidad, decimal precio)
       {
           return facturacionDao.NuevoDetalleFactura(idFact, idExamenMed, cantidad, precio);
       }
   }
}
