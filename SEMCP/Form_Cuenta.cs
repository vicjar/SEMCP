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
    public partial class Form_Cuenta : Form
    {
        Usuario User;    
        public Form_Cuenta(Usuario U)
        {
            InitializeComponent();
            User = U;
            Restablecer();

        }


        

        public void Carga_Datos() {

            txtNombres.Text = User.Nombre;
            txtApellidos.Text = User.Apellido;
            txtUsuario.Text = User.User;
            txtCorreo.Text = User.Correo;
            ComFN.Value = DateTime.Parse(User.Fecha_Nac);
            ComEdad.Value = User.Edad;
            ComSexo.SelectedIndex = User.Sexo - 1;
        }

        public bool Validar()
        {

            if (txtNombres.Text.Length == 0) return false;
            if (txtApellidos.Text.Length == 0) return false;
            if (txtCorreo.Text.Length == 0) return false;
            if (txtUsuario.Text.Length <= 2) return false;
            if (ComSexo.Text == "Selecciona") return false;

            return true;
        }
        public void Restablecer()
        {
            Carga_Datos();
            foreach (Control cnt in gbUsuario.Controls)
            {
                if (cnt.Name.Remove(3) == "txt" || cnt.Name.Remove(3) == "Com" || cnt.Name == "btnCancelar" || cnt.Name == "bntGuardar") cnt.Enabled = false;
            }
            btnEditar.Enabled = true;
        }

        public void Editar(object sender, EventArgs e) {

            foreach (Control cnt in gbUsuario.Controls) {
                if (cnt.Name.Remove(3) == "txt" || cnt.Name.Remove(3) == "Com" || cnt.Name == "btnCancelar" || cnt.Name == "bntGuardar") cnt.Enabled = true;
            }
            btnEditar.Enabled = false;
           
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                
                User.Nombre = txtNombres.Text;
                User.Apellido = txtApellidos.Text;
                User.Edad = (int)ComEdad.Value;
                User.Fecha_Nac = ComFN.Value.ToString("yyyy-MM-dd");
                User.User = txtUsuario.Text;
                User.Correo = txtCorreo.Text;
                User.Tipo = 2;
                User.Sexo = (ComSexo.SelectedItem.ToString() == "Hombre") ? 1 : 2;

                if (User.Actulizar())
                {

                    MessageBox.Show("Usuario Actulizado!.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restablecer();
                }
                else
                {

                    MessageBox.Show("Lo sentimos, algo salio mal. Al aparecer ya existe el usuario o el correo.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {


                MessageBox.Show("Lo sentimos, algo salio mal. Te recomendamos ingresa correctamente los datos.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (User.Password == txtPassword.Text) {

                if (txtNP.Text == txtNPV.Text)
                {
                    if (User.Restablecer_Password(User.User, txtNP.Text)) {
                        txtNP.Clear();
                        txtNPV.Clear();
                        txtPassword.Clear();
                        MessageBox.Show("La nuvea contraseña fue registrada. ", "SEMCP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else MessageBox.Show("Lo sentimos!. La nuvea contraseña no paso la verificación. ", "SEMCP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show("Lo sentimos!. La nuvea contraseña no paso la verificación. ", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("Lo sentimos!. La contraseña actual es incorrecta.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
