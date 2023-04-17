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
using Presentacion.Resultados_Examenes;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Nueva_Factura : Form
    {
        public Frm_Nueva_Factura()
        {
            InitializeComponent();
            LimpiarCampos();
            CalcularDatos();
        }


        private Utilidades utilidades = new Utilidades();
        private FacturacionModel facturacion = new FacturacionModel();
        private decimal subTotal = 0,isv=0,descuento=0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int idCodigo = 0;
        private void BuscarExamen(object sender, FormClosedEventArgs e)
        {
            txtExamen.Text = Cache_Examenes.NombreExamen;
            txtPaciente.Text = Cache_Examenes.NombrePaciente;
            txtPrecio.Text = Cache_Examenes.PrecioExamen.ToString();
            idCodigo = Cache_Examenes.IdExamenMedico;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Examen_Medico buscarExamenPaciente = new Frm_Buscar_Examen_Medico();
            buscarExamenPaciente.Show();
            buscarExamenPaciente.FormClosed += BuscarExamen;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcularDatos()
        {
            subTotal = 0;
            isv = 0;
            descuento = 0;


            foreach (DataGridViewRow item in dg_detalle.Rows)
            {
                subTotal += (Convert.ToDecimal(item.Cells[2].Value) * Convert.ToDecimal(item.Cells[3].Value));
                descuento += Convert.ToDecimal(item.Cells[4].Value);
            }

            isv = (subTotal - descuento) * Convert.ToDecimal(0.15);
            lblSubTotal.Text = "Sub Total: L. " + subTotal;
            lblIsv.Text = "ISV: L. " + isv;
            LblDescuento.Text = "Descuento: L." + descuento;
            lblTotal.Text = "Total: L." + (subTotal - descuento + isv);
        }

        private void LimpiarCampos()
        {
            txtCantidad.Text = "0";
            txtPrecio.Text = "0";
            txtDescuento.Text = "0";
            txtExamen.Text = "";
            txtPaciente.Text = "";
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilidades.CampoVacio(txtExamen.Text) || utilidades.CampoVacio(txtPaciente.Text) ||
                    utilidades.CampoVacio(txtPrecio.Text) || utilidades.CampoVacio(txtDescuento.Text) ||
                    utilidades.CampoVacio(txtCantidad.Text))
                {
                    utilidades.AlertMessage("Todos los campos son obligatorios", "A");
                }
                else
                {
                    if (utilidades.ValidarPrecio(Convert.ToDecimal(txtPrecio.Text)))
                    {
                        if (utilidades.ValidarPrecio(Convert.ToDecimal(txtCantidad.Text)))
                        {
                            if ((Convert.ToDecimal(txtDescuento.Text)) >= 0)
                            {
                                int rowEscribir = dg_detalle.Rows.Count;

                                dg_detalle.Rows.Add(1);

                                dg_detalle.Rows[rowEscribir].Cells[0].Value = idCodigo;
                                dg_detalle.Rows[rowEscribir].Cells[1].Value = txtExamen.Text;
                                dg_detalle.Rows[rowEscribir].Cells[2].Value = txtPrecio.Text;
                                dg_detalle.Rows[rowEscribir].Cells[3].Value = txtCantidad.Text;
                                dg_detalle.Rows[rowEscribir].Cells[4].Value = txtDescuento.Text;


                                LimpiarCampos();
                                CalcularDatos();
                            }
                            else
                            {
                                utilidades.AlertMessage("Ingrese un descuento valido", "A");
                            }
                        }
                        else
                        {
                            utilidades.AlertMessage("Ingrese una cantidad valido", "A");
                        }
                    }
                    else
                    {
                        utilidades.AlertMessage("Ingrese un precio valido", "A");
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                utilidades.AlertMessage("Ocurrio un Error","E");
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (dg_detalle.Rows.Count > 0)
            {
                CalcularDatos();
                var idFactura = facturacion.nuevaFactura(idCodigo, Cache_Usuario.IdUsuario, subTotal, isv, descuento);
                foreach (DataGridViewRow item in dg_detalle.Rows)
                {
                    mensaje = facturacion.NuevoDetalleFactura(idFactura, Convert.ToInt32(item.Cells[0].Value),
                        Convert.ToInt32(item.Cells[3].Value), Convert.ToDecimal(item.Cells[2].Value));
                
                }
                utilidades.AlertMessage(mensaje,"I");
                this.Close();
            }
            else
            {
                utilidades.AlertMessage("Ingrese al menos un examen para poder realizar la factura","A");
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_detalle.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(dg_detalle.CurrentRow.Cells["num"].Value);
                dg_detalle.Rows.RemoveAt(dg_detalle.CurrentRow.Index);
                CalcularDatos();
            }
        }
    }
}
