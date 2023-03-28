using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.SqlServer;

namespace Negocio
{
   public class BitacoraModel
   {
       private BitacoraDao bitacora = new BitacoraDao();

       public DataTable DataTableBitacora()
       {
           return bitacora.DataTableBitacora();
       }

       public string NuevaActividad(string TipoEvento, string DescripcionEvento, int idUsuario)
       {
           return bitacora.NuevaActividad(TipoEvento, DescripcionEvento, idUsuario);
       }

       public DataTable DataTableBitacora(int inicio, int final)
       {
           return bitacora.DataTableBitacora(inicio, final);
       }

       public int TotalRegistros()
       {
           return bitacora.TotalRegistros();
       }
   }
}
