using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SEMCP.Clases;

namespace SEMCP
{
    public partial class Form_Progreso : Form
    {
        Usuario User;
        private double[] dataX;
        private double[] dataY;
        private bool validar = false;
        public Form_Progreso()
        {
            InitializeComponent();
        }

        public Form_Progreso(Usuario U)
        {
            InitializeComponent();
            User = U;

            //Carga_Juegos();
        }


        public void Carga_Datos(String U, String J)
        {

            User.conexion.Open();
            Grafica.Plot.Clear();
            Grafica.Plot.Title("Tu progreso");
            Grafica.Plot.YAxis.Label("Puntaje");
            Grafica.Plot.XAxis.Label("Jugadas");
            SqlCommand comando = new SqlCommand($"Select * from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();
            int x = 0;
            List<double> dx = new List<double>();
            List<double> dy = new List<double>();
            List<String> auxy = new List<string>();
            dx.Add(0);
            dy.Add(0);
            auxy.Add("0");
            while (sdr.Read())
            {
                dx.Add(double.Parse(sdr["Puntaje"].ToString()));
                dy.Add((x + 1));
                auxy.Add((x + 1).ToString());
                x++;

            }

            if (x != 0)
            {
                dataX = dx.ToArray();
                dataY = dy.ToArray();
                String[] Xs = auxy.ToArray();

                Grafica.Plot.AddScatter(dataY, dataX, lineWidth: 5, markerSize: 15);
                Grafica.Plot.Grid(enable: false, lineStyle: null);
                Grafica.Plot.XTicks(dataY, Xs);
                //Grafica.Plot.Style(ScottPlot.Style.Light2);
                validar = true;
            }
            else validar = false;


            comando.Dispose();
            User.conexion.Close();
        }


        private void Menu(object sender, EventArgs e)
        {
            Label aux = sender as Label;
            foreach (Control x in Panel_Menu.Controls) {
                x.Size = new Size(245, 45);

                if (aux.Name.Substring(3, 1) == x.Name.Substring(2, 1)) {
                    String juego = aux.Name.Substring(3, 1);
                    String id = User.Id.ToString();
                    
                    Carga_Datos(id, juego);


                    try
                    {
                        if (juego == "1") Lista_Articulos(id, juego);
                        if (juego == "2") Serie_Numeros(id, juego);
                        if (juego == "3") Memorama(id, juego);
                        if (juego == "4") Cartas(id, juego);
                        if (juego == "5") Simon(id, juego);
                        if (juego == "6") Aniamles(id, juego);
                        x.Size = new Size(245, 120);
                    }
                    catch (Exception ex) {
                        User.conexion.Close();
                        MessageBox.Show("Sin datos");
                        x.Size = new Size(245, 45);
                    }
                }
            }

            
        }


        public void Serie_Numeros(String U, String J) {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read()) {
                int capacidad = Desmontar(Int32.Parse(sdr["r"].ToString()));
                lbPSN.Text = $"Según los resultados, en promedio puedes recordar entre {(capacidad - 2)} y {capacidad} dígitos.";
            }

            User.conexion.Close();
        }

        public void Lista_Articulos(String U, String J)
        {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read())
            {
                int capacidad = Desmontar(Int32.Parse(sdr["r"].ToString()));
                lbPLA.Text = $"Según los resultados, en promedio puedes recordar entre {(capacidad - 2)} y {capacidad} artículos.";
            }

            User.conexion.Close();
        }

        public void Memorama(String U, String J)
        {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read())
            {
                int capacidad = Int32.Parse(sdr["r"].ToString());
                lbPMemorama.Text = $"Según los resultados, en promedio puedes encotrar todos los pares en {capacidad} intentos.";
            }

            User.conexion.Close();
        }

        public void Simon(String U, String J)
        {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read())
            {
                int capacidad = Int32.Parse(sdr["r"].ToString());
                lbPSimon.Text = $"Según los resultados, en promedio puedes seguir una secuencia de {capacidad}";
            }

            User.conexion.Close();
        }

        public void Aniamles(String U, String J)
        {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read())
            {
                int capacidad = Int32.Parse(sdr["r"].ToString());
                lbPLAN.Text = $"Según los resultados, en promedio puedes memorizar  {capacidad*3} palabras";
            }

            User.conexion.Close();
        }

        public void Cartas(String U, String J)
        {
            User.conexion.Open();

            SqlCommand comando = new SqlCommand($"Select AVG(Puntaje)/10 as R from Resultados where Id_U ={U} and Id_J ={J}", User.conexion.connetion);
            SqlDataReader sdr = comando.ExecuteReader();

            if (sdr.Read())
            {
                int capacidad = Int32.Parse(sdr["r"].ToString());
                lbPC.Text = $"Según los resultados, en promedio puedes memorizar  {capacidad +1 } numeros en orden.";
            }

            User.conexion.Close();
        }
        public int Desmontar(int Puntaje) {
            int aux = 1, n = 3; 

            while (Puntaje > 3) {
                Puntaje -= n;
                n++;
                aux++;
            }

            return (aux+2);
         
        }

    }
}
