using SEMCP.Clases;
using System;
using System.Windows.Forms;

namespace SEMCP
{
    public partial class Form_M : Form
    {
        private Usuario User;
        private Memorama M;
        public Form_M()
        {
            InitializeComponent();
        }
        public Form_M(Usuario U)
        {
            InitializeComponent();
            M = new Memorama(Panel_T, label_intentos);
            User = U;
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
            if (M.pares == 10)
            {
                timer1.Stop();
                Panel_R.Visible = true;
                int PF = (M.numero_intentos * 10);
                labelRN.Text += M.numero_intentos.ToString() + $" intentos \n Puntaje Final {PF}";
                User.Registrar_Resultados(PF, 3);
            }
        }
    }
}
