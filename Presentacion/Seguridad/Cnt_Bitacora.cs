using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Cnt_Bitacora : UserControl
    {
        private int PagInicio = 1, indice = 0, numFilas = 10, pagFinal,pagActual=1;
        public Cnt_Bitacora()
        {
            InitializeComponent();
            pagFinal = numFilas;
            Actualizar();
        }

        private void paginacion()
        {
            Utilidades utilidades = new Utilidades();
            try
            {

                int pagina = Convert.ToInt32(CmbPag.SelectedIndex) +1;

                indice = pagina - 1;
                PagInicio = (pagina - 1) * numFilas + 1;
                pagFinal = pagina * numFilas;

                string mensaje = ("Indice:" + indice + " Pagina. " + pagina);
                //MessageBox.Show(mensaje);
                Actualizar();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                utilidades.AlertMessage(exception.ToString(), "E");

            }
        }

        private void CmbPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbPag_ValueMemberChanged(object sender, EventArgs e)
        {
         
        }

        private void CmbPag_SelectionChangeCommitted(object sender, EventArgs e)
        {

            paginacion();

        }

        private void Cnt_Bitacora_Load(object sender, EventArgs e)
        {
          
        }

        private BitacoraModel bitacora = new BitacoraModel();
        private void Actualizar()
        {
            DataTable dt = new DataTable();
            int total = bitacora.TotalRegistros();
            dt = bitacora.DataTableBitacora(PagInicio, pagFinal);
            dg_bitacora.DataSource = dt;
            int cantidad = total / numFilas;

            if (total % numFilas > 0) cantidad++;

            txtTotalPag.Text = cantidad.ToString();
            CmbPag.Items.Clear();

            for (int i = 1; i <= cantidad; i++)
            {
                CmbPag.Items.Add(i.ToString());
            }

            CmbPag.SelectedIndex = indice;
            pagActual = Convert.ToInt32(CmbPag.Text);
        }
    }
}
