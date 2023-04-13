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

namespace Presentacion.Inventario
{
    public partial class Frm_Editar_Inventario : Form
    {
        public Frm_Editar_Inventario()
        {
            InitializeComponent();
        }

        private InventarioModel inventarioModel = new InventarioModel();
        private Utilidades utilidades = new Utilidades();
        private void Actualizar()
        {
          

            dg_inventario.DataSource = inventarioModel.DataTableInventario();
            this.dg_inventario.Columns[0].ReadOnly = true;
            this.dg_inventario.Columns[7].ReadOnly = true;
            this.dg_inventario.Columns[8].ReadOnly = true;
        }

        private void Frm_Editar_Inventario_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string nombreProducto = "", nombreProveedor = "",ubicacion = "",mensaje = "";
            int idInventario = 0,cantidad;
            decimal precio = 0;
            DateTime fechaCompra;

            
            foreach (DataGridViewRow row in dg_inventario.Rows)
            {
                idInventario = Convert.ToInt32(row.Cells[0].Value);
                nombreProducto = row.Cells[1].Value.ToString();
                cantidad = Convert.ToInt32(row.Cells[2].Value);
                nombreProveedor = row.Cells[3].Value.ToString();
                precio = Convert.ToDecimal(row.Cells[4].Value);
                ubicacion = row.Cells[5].Value.ToString();
                fechaCompra = Convert.ToDateTime(row.Cells[6].Value);

                mensaje = inventarioModel.EditarInventario(nombreProducto, nombreProveedor, cantidad, precio, ubicacion,
                    fechaCompra,idInventario);

            }

            utilidades.AlertMessage(mensaje,"I");
            this.Close();
        }

        private void dg_inventario_EditModeChanged(object sender, EventArgs e)
        {

        }
    }
}
