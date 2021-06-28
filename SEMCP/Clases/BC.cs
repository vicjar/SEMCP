using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SEMCP
{   
    /// <summary>
    /// Panel con bordes redondos.
    /// </summary>
    class BC : Panel 
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

        public BC() {
            this.Region =  System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ClientSize.Width, ClientSize.Height, 20, 20));
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ClientSize.Width, ClientSize.Height, 20, 20));
            base.OnClientSizeChanged(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //GraphicsPath grpath = new GraphicsPath();
            //grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            //this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pevent);
        }
    }
}
