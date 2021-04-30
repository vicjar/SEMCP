using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SEMCP
{
    public partial class Form_M : Form
    {

        private Memorama M;
        public Form_M()
        {
            InitializeComponent();
            M = new Memorama(Panel_T,label_intentos);
        }

        private void Form_M_Load(object sender, EventArgs e)
        {
            foreach (Casilla c in Panel_T.Controls)
            {
                c.Centro = M;
            }
        }

        private void casilla5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            Panel_I.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (M.pares == 10) {
                timer1.Stop();
                Panel_R.Visible = true;
                labelRN.Text += M.numero_intentos.ToString() + " intentos";
                
            }
        }
    }
}
