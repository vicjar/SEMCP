using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace SEMCP
{
    /// <summary>
    /// Componente que similar un carta del modulo de conjunto de cartas
    /// </summary>
    class Carta : PictureBox
    {
        private int x;
        public Mazo centro;
        private bool girar = true;   
        public Carta()
        {

            this.Size = new Size(120, 166);
        }

        public Carta(int valor)
        {
            x = valor;
            this.Size = new Size(120, 166);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (girar)
            {
                this.BackColor = Color.LightGreen;
                if (x > 9) pe.Graphics.DrawString(this.x.ToString(), new Font("Arial", 65), System.Drawing.Brushes.Green, new Point(0, 30));
                else pe.Graphics.DrawString(this.x.ToString(), new Font("Arial", 65), System.Drawing.Brushes.Green, new Point(25, 30));
            }
            else {
                this.BackColor = Color.LightSeaGreen;
                pe.Graphics.DrawString("?", new Font("Arial", 65), System.Drawing.Brushes.Blue, new Point(25, 30));
               // pe.Graphics.DrawEllipse(new Pen(Color.Blue,3f), 20,35,this.Height/2, this.Height/2);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            girar = !(girar);
            this.Invalidate();
            centro.Notificar(this.x);
        }
        public void cambio(int x)
        {
            this.x = x;
            this.Invalidate();
        }

        public void Girar_Carta()
        {
            girar = !(girar);
            this.Invalidate();
        }
        public int X
        {
            get => x;
            set => x = value;
        }

        public bool Girar {
            get => girar;
            set => girar = value;
        }
    }
}
