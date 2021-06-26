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

namespace SEMCP
{
    public partial class Form_LA : Form
    {
        // Clase creada por el consultar los artículos  
        public Canasta C = new Canasta();
        private Usuario User; // Clase usuario
        List<String> ListaA = new List<string>();  // Lista verdadera
        List<String> ListaB = new List<string>();  // Lista falsa
        public int Nivel = 0;
        private int tiempo = 10,Puntaje = 0;


        public Form_LA()
        {
            InitializeComponent();

        }

        public Form_LA(Usuario U)
        {
            InitializeComponent();
            User = U;

        }

        private void customCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            int c = 0;

            foreach (CustomCheckBox r in Panel_P.Controls)
            {
                // Verifica las opciones seleccionadas por el usuario con la lista verdadera
                if (r.Checked) {
                    foreach (String p in ListaA) {
                        if (p == r.Text) n++;
                    }
                    c++;
                }
            }
            // Aumenta su puntaje según a los aciertos
            Puntaje += n;
            
            // Verifica si paso el nivel o no 
            if ((n - 2) == Nivel && c == (Nivel + 2))
            {
                MessageBox.Show($"Felicidades {User.Nombre} pasa al siguiente nivel", "Bien Hecho !!");
                VerLista();
            }
            else {
                MessageBox.Show("Oh no, haz fallado!", "Oh no..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Terminar();
            }
        }

        private void VerLista() {

            Panel_I.Visible = false;
            labelinfo2.Text = "Haz lo posible para poder memorizar la lista de artículos porque hay limite de tiempo. \n Nivel "+(Nivel+1).ToString();
            Nivel++;
            Panel_P.Visible = false;
            ButtonComprobar.Visible = false;
            label1.Text = "";
            P_T.Visible = true;
            label_T.Visible = true;
            timer1.Start();

            //Aquí el pedimos a la clase Canasta un artículo
            (ListaA, ListaB) = C.Pedir(Nivel);
            foreach (String x in ListaA)
            {
                label1.Text += "\r" + x;
            }
            
        }

        private void Jugar() {
            
            Panel_P.Visible = true;
            int n = 0;
            label1.Text = "";
            ButtonComprobar.Visible = true;
            labelinfo2.Text = "Ahora selecciona todos los artículos que se mostraron antes. \n Nivel " + Nivel.ToString();

            // Asigna articulos en texto de los CheckBox
            foreach (CustomCheckBox r in Panel_P.Controls)
            {
                r.Checked = false;
                r.Text = ListaB[n];
                n++;
            }
        }

        private void Terminar() {
            Panel_R.Visible = true;
            int PF = Puntaje * 10;
            int LimIn = ((Nivel - 2) <= 0) ? 0 : Nivel - 2;
            int LimSu = Nivel + 2;
            int NivelA = (Nivel == 1) ?  1 : (Nivel -1) ;
            labelRN.Text += NivelA.ToString() + $"\nPuedes recordar: {LimIn} a {LimSu}  productos \nPuntaje Final : {PF}";

            User.Registrar_Resultados(PF,1); // Se registra los resultados en la base de datos

        
            if (Nivel < 4) labelR.Text = $"{User.Nombre} te recomendamos en seguir practicando el ejercicio, además de tener una vida sana.";
            else if (Nivel < 6) labelR.Text = $"Felicidades {User.Nombre} tienes una memoria buena, sigue teniendo una vida sana y productiva.";
            else labelR.Text = $"Wow {User.Nombre}, tienes una memoria excelente.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerLista();
        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            VerLista();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            label_T.Text = tiempo.ToString();

            

            if (tiempo < 0) {
                timer1.Stop();
                tiempo = 10;
                P_T.Visible = false;
                label_T.Visible = false;
                label_T.Text = "10";
                Jugar();
            }  
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
