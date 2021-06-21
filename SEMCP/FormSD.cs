using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SEMCP
{
    public partial class FormSD : Form
    {
        int secuencia = 0;
        Random numeroRand;
        List<int> simonDice = new List<int>();
        bool hablando = false;
        int tiempoEspera = 1500;
        public FormSD()
        {
            InitializeComponent();
            numeroRand = new Random();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void FormSD_Load(object sender, EventArgs e)
        {

        }
        public void iniciarJuego()
        {
           // SoundPlayer sp = new SoundPlayer(Properties.Resources.boton);
            Thread.Sleep(tiempoEspera);
            hablando = true;

            foreach (int cuadro in simonDice)
            {
                switch (cuadro)
                {
                    case 0:
                        amarillo.Image = Properties.Resources.ama2;
                        Thread.Sleep(tiempoEspera);
                        amarillo.Image = Properties.Resources.ama1;
                        break;
                    case 1:
                        rojo.Image = Properties.Resources.roj2;
                        Thread.Sleep(tiempoEspera);
                        rojo.Image = Properties.Resources.roj1;
                        break;
                    case 2:
                        azul.Image = Properties.Resources.azu2;
                        Thread.Sleep(tiempoEspera);
                        azul.Image = Properties.Resources.azu1;

                        break;
                    case 3:
                        verde.Image = Properties.Resources.ver2;
                        Thread.Sleep(tiempoEspera);
                        verde.Image = Properties.Resources.ver;
                        break;
                }
                Thread.Sleep(1000);

            }
            hablando = false;
        }
        public void verificarBoton(int valor)
        {
            if (hablando || simonDice.Count == 0) return;
            if (simonDice[secuencia] == valor)
            {
               secuencia++;
            }
            else
            {
                MessageBox.Show("Tu puntuacion final es: " + simonDice.Count);
                secuencia = 0;
                simonDice = new List<int>();
            }
            if(secuencia >= simonDice.Count)
            {
                simonDice.Add(numeroRand.Next(0, 4));
                secuencia = 0;
                new Thread(iniciarJuego).Start();
            }
            puntos.Text = simonDice.Count.ToString();
        }
        private void iniciar_Click(object sender, EventArgs e)
        {
            //numeroRand.Next(0, 4);
            simonDice.Add(numeroRand.Next(0, 4));
            new Thread(iniciarJuego).Start();

        }

        private void amarillo_Click(object sender, EventArgs e)
        {
            string presionado = ((PictureBox)sender).Name;
            int valor = 0;
            if (((PictureBox)sender).Name == "amarillo"){ valor = 0; }
            if (((PictureBox)sender).Name == "rojo") { valor = 1; }
            if (((PictureBox)sender).Name == "azul") { valor = 2; }
            if (((PictureBox)sender).Name == "verde") { valor = 3; }
            verificarBoton(valor);
        }

        private void amarillo_MouseDown(object sender, MouseEventArgs e)
        {amarillo.Image = Properties.Resources.ama2;}
        private void amarillo_MouseUp(object sender, MouseEventArgs e)
        {amarillo.Image = Properties.Resources.ama1;}
        private void rojo_MouseDown(object sender, MouseEventArgs e)
        {rojo.Image = Properties.Resources.roj2;}
        private void rojo_MouseUp(object sender, MouseEventArgs e)
        {rojo.Image = Properties.Resources.roj1;}
        private void azul_MouseDown(object sender, MouseEventArgs e)
        { azul.Image = Properties.Resources.azu2;}
        private void azul_MouseUp(object sender, MouseEventArgs e)
        {azul.Image = Properties.Resources.azu1;}
        private void verde_MouseDown(object sender, MouseEventArgs e)
        {verde.Image = Properties.Resources.ver2;}
        private void verde_MouseUp(object sender, MouseEventArgs e)
        {verde.Image = Properties.Resources.ver;}
    }
}
