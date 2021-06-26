using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SEMCP.Clases;
using System.Text.RegularExpressions;

namespace SEMCP
{
    public partial class Form_Cuentas : Form
    {

        Usuario User;
        int id_axu;
        public Form_Cuentas()
        {
            InitializeComponent();
        }

        public Form_Cuentas( Usuario U)
        {
            InitializeComponent();
            User = U;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = DGUsuarios[1, e.RowIndex].Value.ToString();
            id_axu = Int32.Parse(id);
            Usuario temp = new Usuario(User.conexion);

            if (DGUsuarios.Columns[e.ColumnIndex] == ColumnVer)
            {
                
                if (temp.Buscar(id))
                {
                    foreach (Control cnt in gbUsuario.Controls)
                    {
                        if (cnt.Name.Remove(3) == "txt" || cnt.Name.Remove(3) == "Com" || cnt.Name == "bntGuardar") cnt.Enabled = false;
                    }
                    txtNombres.Text = temp.Nombre;
                    txtApellidos.Text = temp.Apellido;
                    txtUsuario.Text = temp.User;
                    txtCorreo.Text = temp.Correo;
                    ComFN.Value = DateTime.Parse(temp.Fecha_Nac);
                    ComEdad.Value = temp.Edad;
                    ComSexo.Text = (temp.Sexo == 1) ? "Hombre" : "Mujer";

                }

            }
            if (DGUsuarios.Columns[e.ColumnIndex] == ColumnEditar)
            {

                if (temp.Buscar(id))
                {
                    foreach (Control cnt in gbUsuario.Controls)
                    {
                        if (cnt.Name.Remove(3) == "txt" || cnt.Name.Remove(3) == "Com" || cnt.Name == "bntGuardar") cnt.Enabled = true;
                    }
                    txtNombres.Text = temp.Nombre;
                    txtApellidos.Text = temp.Apellido;
                    txtUsuario.Text = temp.User;
                    txtCorreo.Text = temp.Correo;
                    ComFN.Value = DateTime.Parse(temp.Fecha_Nac);
                    ComEdad.Value = temp.Edad;
                    ComSexo.Text =  (temp.Sexo == 1) ? "Hombre" : "Mujer";

                }

            }
            if (DGUsuarios.Columns[e.ColumnIndex] == ColumnEliminar) {
                string message = "Estas seguro de eliminiar a "+ DGUsuarios[2, e.RowIndex].Value.ToString();
                string title = "Eliminar Usuario";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (temp.Eliminar(id))
                    {

                        MessageBox.Show("Usuario Eliminado!.", "SEMCP",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Carga_Tabla();
                    }
                    else {
                        MessageBox.Show("Lo sentimos, algo salio mal. ", "SEMCP",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            temp = null;
        }

        private void Form_Cuentas_Load(object sender, EventArgs e)
        {
            Carga_Tabla();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                Usuario NuevoUsuario = new Usuario(User.conexion);


                NuevoUsuario.Nombre = txtNombres.Text;
                NuevoUsuario.Apellido = txtApellidos.Text;
                NuevoUsuario.Edad = (int)ComEdad.Value;
                NuevoUsuario.Fecha_Nac = ComFN.Value.ToString("yyyy-MM-dd");
                NuevoUsuario.User = txtUsuario.Text;
                NuevoUsuario.Correo = txtCorreo.Text;
                NuevoUsuario.Tipo = 2;
                NuevoUsuario.Sexo = (ComSexo.SelectedItem.ToString() == "Hombre") ? 1 : 2;
                NuevoUsuario.Id = id_axu;

                if (NuevoUsuario.Actulizar())
                {

                    MessageBox.Show("Usuario Actulizado!.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Carga_Tabla();
                    Limpiar();
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


                MessageBox.Show("Lo sentimos, algo salio mal. Te recomendamos ingresa correctamente los datos.", "SEMCP",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool Validar()
        {

            if (txtNombres.Text.Length == 0) return false;
            if (txtApellidos.Text.Length == 0) return false;
            if (txtCorreo.Text.Length == 0 && Verificar_Correo(txtCorreo.Text)) return false;
            if (txtUsuario.Text.Length <= 2) return false;
            if (ComSexo.Text == "Selecciona") return false;

            return true;
        }

        public void Carga_Tabla() {
            User.conexion.Open();
            DGUsuarios.Rows.Clear();
            SqlCommand comando = new SqlCommand("Select * from Usuarios", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();
            int x = 0;
            while (sdr.Read())
            {
                DGUsuarios.Rows.Add();

                DataGridViewButtonCell btn = DGUsuarios[0, x] as DataGridViewButtonCell;

                DGUsuarios[0, x].Value = "Ver";
                DGUsuarios[1, x].Value = sdr["Id_U"].ToString();
                DGUsuarios[2, x].Value = sdr["Nombre"].ToString();
                DGUsuarios[3, x].Value = sdr["Apellido"].ToString();
                DGUsuarios[4, x].Value = sdr["Usuario"].ToString();
                DGUsuarios[5, x].Value = sdr["Correo"].ToString();
                DGUsuarios[6, x].Value = "Editar";
                DGUsuarios[7, x].Value = "Eliminar";
                x++;

            }

            comando.Dispose();
            User.conexion.Close();
        }

        public void Limpiar()
        {

            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            ComEdad.Value = 0;
            ComSexo.Text = "";
            id_axu = -1;
            foreach (Control cnt in gbUsuario.Controls)
            {
                if (cnt.Name.Remove(3) == "txt" || cnt.Name.Remove(3) == "Com" || cnt.Name == "bntGuardar") cnt.Enabled = false;
            }
        }

        private bool Verificar_Correo(String correo)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion)) return true;
            else return false;

        }
    }
}
