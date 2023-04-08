using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Negocio;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion.Seguridad
{
    public partial class Frm_Asignar_Permisos : Form
    {
        public Frm_Asignar_Permisos()
        {
            InitializeComponent();
           // checkedListBox1.DataSource = seguridadModel.DataTablePermisos();
          
           
        }

        private SeguridadModel seguridadModel = new SeguridadModel();
        private UserModel userModel = new UserModel();
        private Utilidades utilidades = new Utilidades();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool buscar(string nombre)
        {
            bool encontrado=false;
            foreach (var permisoUser in Cache_Cargos.ListaPermisosPorRolList)
            {
                if (permisoUser.NombrePermiso == nombre)
                {
                    encontrado= true;
                    break;
                }
            }

            return encontrado;
        }

        private void marcar(int id)
        {

            checkedListBox1.Items.Clear();
            listBox1.Items.Clear();
            seguridadModel.PermisosPorRol(id);
            foreach (var xp in Cache_Cargos.ListaPermisosList)
            {
                if (buscar(xp.NombrePermiso))
                {
                    checkedListBox1.Items.Add(xp.descripcion, true);
                    listBox1.Items.Remove("");
                    listBox1.Items.Add(xp.descripcion);
                }
                else
                {
                    checkedListBox1.Items.Add(xp.descripcion);

                }
            }

        }

        private void Frm_Asignar_Permisos_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nombre_Rol";
            comboBox1.ValueMember = "Id_Rol";
            comboBox1.DataSource = userModel.ComboBoxCargo();
            listBox1.Items.Clear();
            seguridadModel.obtenerTodosLosPermisos();
            userModel.ObtenerCargos();
            int id = Convert.ToInt32(comboBox1.SelectedValue);


            lblDesPermiso.Text = "Permisos del Cargo: " + comboBox1.Text;

            marcar(id);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
          
        }

       

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listBox1.Items.Remove("");
            if (Convert.ToBoolean(e.CurrentValue))
            {
                listBox1.Items.Remove(checkedListBox1.Text);
               
            }
            else
            {
                listBox1.Items.Add(checkedListBox1.Text);
            }



           


        }

        private bool PermisoActivo(string permiso)
        {
            bool encontrado = false;
            foreach (var itemchecked in checkedListBox1.CheckedItems)
            {
                if (itemchecked.ToString() == permiso)
                {
                    Console.WriteLine("Permiso: {0} Encontrado", itemchecked.ToString());
                    encontrado = true;
                    break;
                }
              
            }

            return encontrado;
        }

        private void GuardarPermisos()
        {
            int estado = 0;
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            foreach (var item in checkedListBox1.Items)
            {
                estado = PermisoActivo(item.ToString()) ? 1 : 0;
                Cache_Cargos.ListaAsignarRoles.Add(new Soporte.Cache.Seguridad(){IdRol = id,descripcion = item.ToString(),EstadoRol = estado});
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GuardarPermisos();
            var result = seguridadModel.AsignarPermisos();
            if (result)
            {
                utilidades.AlertMessage("Permisos Actualizados con éxito","I");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                marcar(id);
                lblDesPermiso.Text = "Permisos del Cargo: " + comboBox1.Text;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
