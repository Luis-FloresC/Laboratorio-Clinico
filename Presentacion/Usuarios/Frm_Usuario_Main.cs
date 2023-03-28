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
using Presentacion.Usuarios;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Usuario_Main : Form
    {
        public Frm_Usuario_Main()
        {
            InitializeComponent();
            Actualizar();
        }

        private string Mode;
        public Frm_Usuario_Main(string mode)
        {
            InitializeComponent();
            Mode = mode;
            if (mode == "Editar")
            {
                lblNombre.Visible = false;
                btn_buscar.Visible = false;
                label6.Text = "Editar Usuario";
                var existUser = userModel.BuscarUsuarioPorId(Cache_Usuario.IdUsuarioEdit);
                if (existUser)
                {
                    txtNombreUser.Text = Cache_Usuario.NombreUs;
                    txtDni.Text = Cache_Usuario.DniUs;
                    txtCorreoElectronico.Text = Cache_Usuario.CorreoElectronicoUs;
                    txtPassword.Text = Cache_Usuario.ContraseniaUs;
                    txtConfirmarPassword.Text = Cache_Usuario.ContraseniaUs;
                   
                    cmb_Cargos.DataSource = userModel.ComboBoxCargo();
                    cmb_Cargos.DisplayMember = "Nombre_Rol";
                    cmb_Cargos.ValueMember = "Id_Rol";

                    cmb_Cargos.SelectedValue = Cache_Usuario.IdRolUs;
                }
            }


        }
        UserModel userModel = new UserModel();

        private void Actualizar()
        {
            cmb_Cargos.DataSource = userModel.ComboBoxCargo();
            cmb_Cargos.DisplayMember = "Nombre_Rol";
            cmb_Cargos.ValueMember = "Id_Rol";
            txtDni.Enabled = false;

        } 
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtDni.Text = BuscarPersonal.Dni;
           lblNombre.Text = BuscarPersonal.Nombre + " - " + BuscarPersonal.Dni;
        }
        Utilidades utilidades = new Utilidades();

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            if (Mode == "Editar")
            {
                if (utilidades.AlgoritmoContraseñaSegura(txtPassword.Text))
                {
                    if (txtPassword.Text == txtConfirmarPassword.Text)
                    {
                        int id_rol = Convert.ToInt32(cmb_Cargos.SelectedValue);


                        UserModel user = new UserModel();
                        var result = user.EditarUsuario(txtPassword.Text, txtDni.Text,
                            txtCorreoElectronico.Text, txtNombreUser.Text, id_rol);

                        utilidades.AlertMessage(result, "I");
                        this.Close();






                    }
                    else
                    {
                        utilidades.AlertMessage("Las contraseñas deben coincidir", "A");
                    }
                }
                else
                {
                    utilidades.AlertMessage(
                        "La Contraseña debe contener:\n1 carcter especial\nal menos 1 letra Mayuscula y \nal menos 1 número\ny debe contener al menos 8 caracteres",
                        "A");
                }
            }
            else
            {
               
                if (utilidades.CampoVacio(txtDni.Text) || utilidades.CampoVacio(txtNombreUser.Text) || utilidades.CampoVacio(txtPassword.Text) ||
                    utilidades.CampoVacio(txtCorreoElectronico.Text) || utilidades.CampoVacio(cmb_Cargos.Text))
                {
                    utilidades.AlertMessage("Los Campos son Obligatorios", "A");
                }
                else
                {
                    if (utilidades.AlgoritmoContraseñaSegura(txtPassword.Text))
                    {
                        if (txtPassword.Text == txtConfirmarPassword.Text)
                        {
                            int id_rol = Convert.ToInt32(cmb_Cargos.SelectedValue);
                           
                            
                            UserModel user = new UserModel();
                            var result = user.NuevoUsuario(txtPassword.Text, txtDni.Text,
                                txtCorreoElectronico.Text, txtNombreUser.Text,id_rol);

                            utilidades.AlertMessage(result, "I");
                            this.Close();






                        }
                        else
                        {
                            utilidades.AlertMessage("Las contraseñas deben coincidir", "A");
                        }
                    }
                    else
                    {
                        utilidades.AlertMessage(
                            "La Contraseña debe contener:\n1 carcter especial\nal menos 1 letra Mayuscula y \nal menos 1 número\ny debe contener al menos 8 caracteres",
                            "A");
                    }
                }
            }
        }

        private void Frm_Usuario_Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Personal buscarPersonal = new Frm_Buscar_Personal();
            buscarPersonal.Show();
            buscarPersonal.FormClosed += CerrarSesion;

        }

        private void txtNombreUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
