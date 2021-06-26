using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using SEMCP.Clases;
using System.ComponentModel;

namespace SEMCP
{
    public class Mazo: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

       
        
        public int nivel = 1,puntaje = 0;
        public bool Ban = true;
        private List<Carta> Conjunto_Cartas = new List<Carta>();
        private List<int> Numeros = new List<int>();
        private int aux = 1;

        private FlowLayoutPanel panel;
        Timer tiempo = new Timer();
        Label lbTiempo;
        Label lbAviso;
        Label lbPuntaje;

        public Mazo(FlowLayoutPanel P, Label LbT, Label LbA,Label LbP) {
            panel = P;
            Crear_Mazo();
            tiempo.Tick += Tiempo_Tick;
            tiempo.Interval = 1000;
            lbTiempo = LbT;
            lbAviso = LbA;
            lbPuntaje = LbP;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (aux > 10)
            {
                foreach (Carta c in panel.Controls) c.Girar_Carta();
                tiempo.Stop();
                lbAviso.Text = "Gira las cartas en el orden que se el indico.";

            }
            lbTiempo.Text = $"Tiempo {(11 - aux)}"; 
            aux++; 
        }

        public void Crear_Mazo() {
            Conjunto_Cartas.Clear();
            panel.Controls.Clear();

            int aux;
            int aux_nivel = (nivel >= 11) ? 11 : nivel;
            while (Conjunto_Cartas.Count <= aux_nivel) {

                Random random = new Random();
                aux = random.Next(0, ((2 * nivel) + 1));

                if (!(Conjunto_Cartas.Exists(x => x.X == aux)))
                {
                    Conjunto_Cartas.Add(new Carta(aux));
                    Conjunto_Cartas[Conjunto_Cartas.Count - 1].centro = this;
                    panel.Controls.Add(Conjunto_Cartas[Conjunto_Cartas.Count - 1]);
                    Numeros.Add(aux);
                }
            }
        }

        public void Orden_A() {
            lbAviso.Text = "Memoriza las cartas en orden ascendente";
            int tmp = 0;

            for (int i = 0; i < Numeros.Count - 1; i++)
            {
                for (int j = i + 1; j < Numeros.Count; j++)
                {
                    if (Numeros[i] > Numeros[j])
                    {
                        tmp = Numeros[i];
                        Numeros[i] = Numeros[j];
                        Numeros[j] = tmp;
                    }
                }
            }
        }

        public void Orden_D()
        {
            Orden_A();
            Numeros.Reverse();
            lbAviso.Text = "Memoriza las cartas en orden descendente";
        }

        public void A_Jugar() {

            Random random = new Random();
            bool opc = (random.Next(1, 20) % 2 == 0) ? true : false;

            if (opc)
            {
                Orden_A();
                
            }
            else
            {
                Orden_D();
               
            }
            lbPuntaje.Text = $"Nivel : {nivel}\nPuntaje: {puntaje}";
            aux = 1;
            tiempo.Start();


        }

        public void Notificar(int valor) {

            if (Numeros[0] == valor) Numeros.RemoveAt(0);
            else {
                Ban = false;
                OnPropertyChanged("Ban");
            }

            if (Numeros.Count == 0 && Ban) {
                nivel++;
                puntaje++;
                Crear_Mazo();
                A_Jugar();
            }

        }
        //Notifica si cambio el valor de una propiedad
        protected virtual void OnPropertyChanged(string Propiedad)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Propiedad));
        }

    }
}
