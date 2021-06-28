using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using SEMCP.Properties;

namespace SEMCP
{
    /// <summary>
    /// Chechbox modificado para el modulo de Lista de artículos. 
    /// </summary>
    public class CustomCheckBox : CheckBox
    {
        public CustomCheckBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (this.Checked)
            {
                pevent.Graphics.DrawImage((Bitmap) global::SEMCP.Properties.Resources.sharp_task_alt_black_24dp1,
                    new RectangleF(10, 10, 50, 50), new RectangleF(0, 0, 50, 50), GraphicsUnit.Pixel);
            }
            else
            {

                //pevent.Graphics.DrawImage(global::ListaArticulos.Properties.Resources.sharp_radio_button_unchecked_black_24dp,
                //    new RectangleF(10, 10, 50, 50), new RectangleF(0, 0, 50, 50), GraphicsUnit.Pixel);
            }
        }
    }
}
