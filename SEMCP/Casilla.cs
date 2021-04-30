using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace SEMCP
{
    public class Casilla : PictureBox
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );

        public Memorama centro;
        public int valor;
        public bool on = false;
        public Bitmap Imagen;

        public Casilla()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ClientSize.Width, ClientSize.Height, 20, 20));
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ClientSize.Width, ClientSize.Height, 20, 20));
            base.OnClientSizeChanged(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {

            Control[] ctrls = centro.Tablero.Controls.Find(this.Name, true);

            if (ctrls.Length > 0)
            {

                centro.Notificar(ctrls[0] as Casilla);
            }

            

        }

        public void Asignar(int v) {
            valor = v;
            switch (valor) {
                case 1:
                    Imagen = global::SEMCP.Properties.Resources.carta_circulo;
                    break;
                case 2:
                    Imagen = global::SEMCP.Properties.Resources.carta_corazon;
                    break;
                case 3:
                    Imagen = global::SEMCP.Properties.Resources.carta_cuadrado;
                    break;
                case 4:
                    Imagen = global::SEMCP.Properties.Resources.carta_e4;
                    break;
                case 5:
                    Imagen = global::SEMCP.Properties.Resources.carta_engarne;
                    break;
                case 6:
                    Imagen = global::SEMCP.Properties.Resources.carta_estrella;
                    break;
                case 7:
                    Imagen = global::SEMCP.Properties.Resources.carta_pentagono;
                    break;
                case 8:
                    Imagen = global::SEMCP.Properties.Resources.carta_rombo;
                    break;
                case 9:
                    Imagen = global::SEMCP.Properties.Resources.carta_triangulo;
                    break;
                case 0:
                    Imagen = global::SEMCP.Properties.Resources.carta_x;
                    break;
            }
            this.BackgroundImage = global::SEMCP.Properties.Resources.carta_volteada;
        }

        public Memorama Centro {
            get => centro;
            set => centro = value;
        }

    }
}
