using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMCP
{
    public partial class Form_LA : Form
    {
        public Canasta C = new Canasta();
        List<String> ListaA = new List<string>();
        List<String> ListaB = new List<string>();
        public int Nivel = 0;
        private int tiempo = 10;

        public Form_LA()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                if (r.Checked) {
                    foreach (String p in ListaA) {
                        if (p == r.Text) n++;
                    }
                    c++;
                }
            }

            if ((n - 2) == Nivel && c == (Nivel + 2))
            {
                MessageBox.Show("Felicidades pasa al siguiente nivel", "Bien Hecho !!");
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


            foreach (CustomCheckBox r in Panel_P.Controls)
            {
                r.Checked = false;
                r.Text = ListaB[n];
                n++;
            }
        }

        private void Terminar() {
            Panel_R.Visible = true;
            labelRN.Text += Nivel.ToString();

            if (Nivel < 3) labelR.Text = "Te recomendamos en seguir practicando el ejercicio, además de tener una vida sana.";
            else if (Nivel < 5) labelR.Text = "Felicidades tiene una memoria buena, sigue teniendo una vida sana y productiva.";
            else labelR.Text = "Wow, tienes una memoria excelente, sigue así de bueno.";
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
