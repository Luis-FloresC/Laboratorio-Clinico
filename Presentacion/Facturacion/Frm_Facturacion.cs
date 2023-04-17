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

namespace Presentacion
{
    public partial class Frm_Facturacion : Form
    {
        public Frm_Facturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Nueva_Factura nuevaFactura = new Frm_Nueva_Factura();
            nuevaFactura.Show();
            nuevaFactura.FormClosed += CerrarForm;
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private FacturacionModel facturacion = new FacturacionModel();
        private void Actualizar()
        {
            dg_facturacion.DataSource = facturacion.DataTableFactturacion();
        }

        private void Frm_Facturacion_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
