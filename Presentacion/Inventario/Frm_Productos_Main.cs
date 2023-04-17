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
    public partial class Frm_Productos_Main : Form
    {
        private InventarioModel inventario = new InventarioModel();
        private Utilidades utilidades = new Utilidades();
        public Frm_Productos_Main()
        {
            InitializeComponent();
        }


        private void Guardar()
        {
            if (utilidades.CampoVacio(txtNombre.Text) || utilidades.CampoVacio(txtProveedor.Text) ||
                utilidades.CampoVacio(txtPrecio.Text) || utilidades.CampoVacio(txtCantidad.Text) ||
                utilidades.CampoVacio(TxtUbicacion.Text))
            {
                utilidades.AlertMessage("Todos los campos son obligatorios","A");
            }
            else
            {
                decimal precio = 0;
                bool isValido = Decimal.TryParse(txtPrecio.Text, out precio);
                if (utilidades.ValidarPrecio(precio))
                {
                    if (utilidades.CheckDates(DtpFechaCompra.Value, DateTime.Now))
                    {
                        if (utilidades.EsSoloNumeros(txtCantidad.Text, false))
                        {
                            var result = inventario.NuevoInventario(txtNombre.Text, txtProveedor.Text,
                                Convert.ToInt32(txtCantidad.Text), utilidades.GenerarNumeroSerie(), precio,
                                TxtUbicacion.Text, DtpFechaCompra.Value);
                            utilidades.AlertMessage(result, "I");
                            this.Close();
                        }
                        else
                        {
                            utilidades.AlertMessage("Cantidad no valida", "A");
                        }
                    }
                    else
                    {
                        utilidades.AlertMessage("Fecha no valida", "A");
                    }
                }
                else
                {
                    utilidades.AlertMessage("Precio no Valido", "A");
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
