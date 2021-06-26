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
    public partial class Form_SN : Form
    {
        private Random random = new Random();
        public int nivel = 1;
        private int tiempo = 10, Puntaje =0;
        private String serie_numeros;
        private Usuario User;

        public Form_SN()
        {
            InitializeComponent();
        }

        public Form_SN(Usuario U)
        {
            InitializeComponent();
            User = U;
        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            Panel_I.Visible = false;
            Panel_J.Visible = true;
            VerSerie();
        }

        /// Validar la entreta de datos.
        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void VerSerie() {

            labelSerie.Text = "";
            TextBoxNumber.Text = "";
            TextBoxNumber.Visible = false;
            labelinfo3.Visible = false;
            ButtonComprobar.Visible = false;
            LabelN.Text = "Nivel "+ nivel.ToString();


            for (int x = 0; x < nivel + 2; x++) {
                labelSerie.Text += random.Next(10); 
            }
            timer1.Start();
        }

        private void Jugar() {
            TextBoxNumber.Visible = true;
            labelinfo3.Visible = true;
            ButtonComprobar.Visible = true;
            TextBoxNumber.Text = "";
        }

        private void Terminar()
        {
            Panel_R.Visible = true;
            Panel_J.Visible = false;
            nivel--;
            int LimIn = ((nivel - 2) <= 0) ? 0 : nivel - 2;
            int LimSu = nivel + 2;
            int NivelA = (nivel <= 1) ? 1 : nivel;
            labelRN.Text += NivelA.ToString() + $"\nPuedes recordar: {LimIn} a {LimSu}  digitos \nPuntaje Final : {Puntaje}";

            User.Registrar_Resultados(Puntaje, 2);


            if (nivel < 5) labelR.Text = $"{User.Nombre} te recomendamos en seguir practicando el ejercicio, además de tener una vida sana.";
            else if (nivel < 8) labelR.Text = $"Felicidades {User.Nombre} tienes una memoria buena, sigue teniendo una vida sana y productiva.";
            else labelR.Text = $"Wow {User.Nombre}, tienes una memoria excelente.";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label_T.Text = tiempo.ToString();
            tiempo--;


            if (tiempo < 0)
            {
                label_T.Text = "0";
                tiempo = 10;
                serie_numeros = labelSerie.Text;
                labelSerie.Text = "----------------";
                timer1.Stop();
                Jugar();

            }
        }

        private void ButtonComprobar_Click(object sender, EventArgs e)
        {
            if (serie_numeros == TextBoxNumber.Text)
            {
                MessageBox.Show("Felicidades pasa al siguiente nivel", "Bien Hecho !!");
                nivel++;
                Puntaje = Puntaje + (nivel * 10);
                VerSerie();
            }
            else {
                MessageBox.Show("Oh no, haz fallado!", "Oh no..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Terminar();
            }
        }

        private void Panel_R_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
