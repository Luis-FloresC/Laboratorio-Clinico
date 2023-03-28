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
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Catalogo_Examen_Main : Form
    {
        private AnalisisModel analisis = new AnalisisModel();
        private Utilidades utilidades = new Utilidades();
        private ExamenesModel examenesModel = new ExamenesModel();
        private int Id;
        private string Mode;
        public Frm_Catalogo_Examen_Main()
        {
            InitializeComponent();
            Actualizar();
        }

        public Frm_Catalogo_Examen_Main(string titulo,int id)
        {
            InitializeComponent();
            Actualizar();
            label1.Text = titulo;
            label3.Visible = true;
            Mode = titulo;
            Id = id;
            cmbEstado.Visible = true;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var result = examenesModel.BuscarExamenePorId(Id);
            if (result)
            {
                txtNombre.Text = Cache_Examenes.Nombre;
                txtPrecio.Text = Cache_Examenes.Precio.ToString();
                cmbAnalisis.SelectedValue = Cache_Examenes.IdAnalisis;
                cmbEstado.SelectedIndex = Cache_Examenes.Estado ? 0 : 1;
            }
          

        }

        private void Actualizar()
        {
            cmbAnalisis.DataSource = analisis.DataTableAnalisisComboBox();
            cmbAnalisis.DisplayMember = "Nombre";
            cmbAnalisis.ValueMember = "Id";
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
            if (utilidades.CampoVacio(txtNombre.Text) || utilidades.CampoVacio(txtPrecio.Text) ||
                utilidades.CampoVacio(cmbAnalisis.Text))
            {
                utilidades.AlertMessage("Todos los campos son obligatorios","A");
            }
            else
            {
                if (utilidades.EsSoloNumeros(txtPrecio.Text, true))
                {
                    if (Mode == "Editar Examen")
                    {
                        if (utilidades.CampoVacio(cmbEstado.Text))
                        {
                            utilidades.AlertMessage("Todos los campos son obligatorios", "A");
                        }
                        else
                        {
                            int id = Convert.ToInt32(cmbAnalisis.SelectedValue);
                            int estado = cmbEstado.Text == "Activo" ? 1 : 0;
                            var result =
                                examenesModel.EditarExamen(txtNombre.Text, id, Convert.ToDecimal(txtPrecio.Text),estado,Id);
                            utilidades.AlertMessage(result, "I");
                            this.Close();
                        }
                    }
                    else
                    {
                        int id = Convert.ToInt32(cmbAnalisis.SelectedValue);
                        var result =
                            examenesModel.NuevoExamen(txtNombre.Text, id, Convert.ToDecimal(txtPrecio.Text));
                        utilidades.AlertMessage(result, "I");
                        this.Close();
                    }
                }
                else
                {
                    utilidades.AlertMessage("Ingrese un número valido", "A");
                }
            }

        }
    }
}
