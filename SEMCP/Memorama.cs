using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SEMCP
{
    public class Memorama
    {
        public Casilla c1, c2;
        public int numero_intentos = 0;
        public int pares = 0;
        private int[] valores = {1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,0};
        public Panel Tablero;
        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private Label label_I;

        public Memorama(Panel T,Label L) {
            Tablero = T;
            c1 = null;
            c2 = null;
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 600;
            label_I = L;

            AsignarCarta();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            c1.BackgroundImage = global::SEMCP.Properties.Resources.carta_volteada;
            c2.BackgroundImage = global::SEMCP.Properties.Resources.carta_volteada;
            c1 = null;
            c2 = null;
            numero_intentos++;
            label_I.Text = numero_intentos.ToString();

            timer1.Stop();
        }

        public void Notificar(Casilla C) {

            if (c1 == null && C.on == false)
            {
                c1 = C;
                c1.BackgroundImage = c1.Imagen;
            }
            else {
                if (c2 == null && C.on == false) {
                    c2 = C;
                    c2.BackgroundImage = c2.Imagen;
                    //MessageBox.Show(c2.Imagen.ToString());
                    
                   
                }
            }

            if(c1 != null && c2 != null) Verificar();
        }

        public void Verificar() {
            
            
            

            if (c1.valor == c2.valor)
            {
               
                c1.on = true;
                c2.on = true;
                c1 = null;
                c2 = null; 
                numero_intentos++;
                label_I.Text = numero_intentos.ToString();

                if (pares == 9) {
                    MessageBox.Show("Felicidades!");
                }
                pares++;
                
            }
            else {
                timer1.Start();
            }
            
        }


        public void AsignarCarta() {
            Revolver();
            int x = 0;
            foreach (Casilla c in Tablero.Controls)
            {
                c.Asignar(valores[x]);
                x++;
            }
        }

        public void Revolver()
        {
            Random random = new Random();
            int x = valores.Length;

            while (x > 1)
            {
                x--;
                int Aux = random.Next(x + 1);
                int P = valores[x];
                valores[x] = valores[Aux];
                valores[Aux] = P;
            }
        }
    }
}
