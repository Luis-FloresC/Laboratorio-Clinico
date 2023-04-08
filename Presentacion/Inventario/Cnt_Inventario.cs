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
using Presentacion.Inventario;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Cnt_Inventario : UserControl
    {
        public Cnt_Inventario()
        {
            InitializeComponent();
        }


        private Utilidades utilidades = new Utilidades();
        private InventarioModel inventario = new InventarioModel();

        private void Actualizar()
        {
            dg_inventario.DataSource = inventario.DataTableInventario();
        }
        private void Cnt_Inventario_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Productos_Main productos = new Frm_Productos_Main();
            productos.Show();
            productos.FormClosed += CerrarForm;
        }
    }
}
