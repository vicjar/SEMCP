using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEMCP.Clases;
using System.Data.SqlClient;

namespace SEMCP
{
    public partial class Form_Progresos : Form
    {
        Usuario User;
        private double[] dataX;
        private double[] dataY;
        private bool validar = false;
        public Form_Progresos()
        {
            InitializeComponent();
        }

        public Form_Progresos(Usuario U)
        {
            InitializeComponent();
            User = U;
        }

        private void Form_Progresos_Load(object sender, EventArgs e)
        {
            
            Grafica.Plot.YAxis.Label("Puntaje");
            Grafica.Plot.XAxis.Label("Jugadas");

            Carga_Usuarios();
            Carga_Juegos();

        }

        private void bntVer_Click(object sender, EventArgs e)
        {
            String key_u = ((KeyValuePair<string, string>)ComUsuario.SelectedItem).Key;
            String key_j = ((KeyValuePair<string, string>)ComJuego.SelectedItem).Key;
            //string value = ((KeyValuePair<string, string>)ComUsuario.SelectedItem).Value;
            Carga_Datos(key_u, key_j);

        }

        public void Carga_Usuarios()
        {
            ComUsuario.Enabled = true;
            User.conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from Usuarios", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            while (sdr.Read())
            {
                comboSource.Add(sdr["Id_U"].ToString(), sdr["Nombre"].ToString() + " "+sdr["Apellido"].ToString());
            }
            ComUsuario.DataSource = new BindingSource(comboSource, null);
            ComUsuario.DisplayMember = "Value";
            ComUsuario.ValueMember = "Key";
            comando.Dispose();
            User.conexion.Close();
        }

        public void Carga_Juegos()
        {
            ComJuego.Enabled = true;
            User.conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from Juegos", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            while (sdr.Read())
            {
                comboSource.Add(sdr["Id_J"].ToString(), sdr["Nombre"].ToString());
            }
            ComJuego.DataSource = new BindingSource(comboSource, null);
            ComJuego.DisplayMember = "Value";
            ComJuego.ValueMember = "Key";
            comando.Dispose();
            User.conexion.Close();
        }

        public void Carga_Datos(String U, String J)
        {

            User.conexion.Open();
            DGPuntaje.Rows.Clear();
            Grafica.Plot.Clear();

            SqlCommand comando = new SqlCommand($"Select * from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();
            int x = 0;
            List<double> dx = new List<double>();
            List<double> dy = new List<double>();
            while (sdr.Read())
            {
                DGPuntaje.Rows.Add();

                DataGridViewButtonCell btn = DGPuntaje[0, x] as DataGridViewButtonCell;

                DGPuntaje[0, x].Value = sdr["Puntaje"].ToString();
                DGPuntaje[1, x].Value = sdr["Fecha"].ToString();
                dx.Add(double.Parse(sdr["Puntaje"].ToString()));
                dy.Add((x+1));
                x++;

            }

            if (x != 0) {
                dataX = dx.ToArray();
                dataY = dy.ToArray();

                Grafica.Plot.AddScatter(dataY, dataX, color: Color.Blue, lineWidth: 5, markerSize: 15);
                validar = true;
            } else validar = false;
            

            comando.Dispose();
            User.conexion.Close();
        }

        private void rbar_CheckedChanged(object sender, EventArgs e)
        {
            if (validar) {
                Grafica.Plot.Clear();
                Grafica.Plot.AddBar(dataX);
            }
        }

        private void rlineal_CheckedChanged(object sender, EventArgs e)
        {
            if (validar)
            {
                Grafica.Plot.Clear();
                Grafica.Plot.AddScatter(dataY, dataX, color: Color.Blue, lineWidth: 5, markerSize: 15);
            }
        }
    }
}
