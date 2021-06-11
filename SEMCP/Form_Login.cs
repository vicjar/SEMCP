using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SEMCP.Clases;

namespace SEMCP
{
    public partial class Form_Login : Form
    {
        ConexionBD conexion = new ConexionBD();
        public Form_Login()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Registro.Visible = false;
            Panel_RP.Visible = false;
            Panel_Login.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_Login.Visible = false;
            Panel_RP.Visible = false;
            Panel_Registro.Visible = true;
            Limpiar_Registro();
        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text != "" && txtUsuarioLogin.Text != "")
            {

                Usuario User = new Usuario(conexion);
                if (User.login(txtUsuarioLogin.Text, txtPasswordLogin.Text))
                {
                    Form1 fm = new Form1();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordLogin.Clear();
                    txtUsuarioLogin.Clear();
                    txtUsuarioLogin.Focus();

                }

            }
        }

        public bool Validar_RP()
        {

            if (txtRPU.Text.Length <= 2) return false;
            if (txtRPC.Text.Length <= 4) return false;
            if (txtRPV.Text.Length <= 4) return false;
            if (txtRPC.Text != txtRPV.Text) return false;

            return true;
        }
        public void Limpiar_RP()
        {
            txtRPV.Clear();
            txtRPU.Clear();
            txtRPC.Clear();
        }

        public bool Validar_Registro()
        {

            if (txtNombres.Text.Length == 0) return false;
            if (txtApellidos.Text.Length == 0) return false;
            if (txtCorreo.Text.Length == 0) return false;
            if (txtPassword.Text.Length <= 4) return false;
            if (txtUsuario.Text.Length <= 2) return false;
            if (ComSexo.Text == "Selecciona") return false;

            return true;
        }

        public void Limpiar_Registro()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtUsuario.Clear();
            ComSexo.Text = "Selecciona";
            ComEdad.Value = 0;
        }
        
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel_Login.Visible = false;
            Panel_Registro.Visible = false;
            Panel_RP.Visible = true;
            Limpiar_RP();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel_RP.Visible = false;
            Panel_Registro.Visible = false;
            Panel_Login.Visible = true;
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            if (Validar_RP())
            {
                Usuario User_Tem = new Usuario(conexion);
                if (User_Tem.Restablecer_Password(txtRPU.Text, txtRPC.Text))
                {
                   
                    MessageBox.Show("Listo!, ya puedes iniciar sesión.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Panel_RP.Visible = false;
                    Panel_Registro.Visible = false;
                    Panel_Login.Visible = true;
                    Limpiar_Registro();
                    txtUsuarioLogin.Focus();
                }
                else
                {
                    txtRPU.Focus();
                    MessageBox.Show("Lo sentimos, algo salio mal. Intentalo mas tarde.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                txtRPU.Focus();
                MessageBox.Show("Lo sentimos, algo salio mal. Te recomendamos ingresa correctamente los datos.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validar_Registro())
            {
                Usuario NuevoUsuario = new Usuario(conexion);

                NuevoUsuario.Nombre = txtNombres.Text;
                NuevoUsuario.Apellido = txtApellidos.Text;
                NuevoUsuario.Edad = (int)ComEdad.Value;
                NuevoUsuario.Fecha_Nac = ComFN.Value.ToString("yyyy-MM-dd");
                NuevoUsuario.User = txtUsuario.Text;
                NuevoUsuario.Password = txtPassword.Text;
                NuevoUsuario.Correo = txtCorreo.Text;
                NuevoUsuario.Tipo = 2;
                NuevoUsuario.Sexo = (ComSexo.SelectedItem.ToString() == "Hombre") ? 1 : 2;

                if (NuevoUsuario.Registar())
                {
                    
                    MessageBox.Show("Usuario registrado! Ya puede cerrar el registro y poder iniciar sección.","SEMCP",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Panel_Registro.Visible = false;
                    Panel_RP.Visible = false;
                    Panel_Login.Visible = true;
                }
                else
                {

                    MessageBox.Show("Lo sentimos, algo salio mal. Al aparecer ya existe el usuario o el correo.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                NuevoUsuario = null;
            }
            else
            {


                MessageBox.Show("Lo sentimos, algo salio mal. Te recomendamos ingresa correctamente los datos.","SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
