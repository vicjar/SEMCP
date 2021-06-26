using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEMCP.Clases;

namespace SEMCP
{
    public partial class FromCC : Form
    {
        Mazo M;
        Usuario User;
        public FromCC()
        {
            InitializeComponent();
            
        }

        public FromCC(Usuario U)
        {
            InitializeComponent();
            User = U;
        }

        private void Tablero_Load(object sender, EventArgs e)
        {
            
 

        }

        private void M_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Ban")
            {
                MessageBox.Show("Termino el juego");
                Terminar();
            }
        }

        private void ButtonJugar_Click(object sender, EventArgs e)
        {
            Panel_I.Visible = false;
            M = new Mazo(Tablero, lbNivel, lbAviso, lbPuntaje);
            M.A_Jugar();

            M.PropertyChanged += M_PropertyChanged;
        }

        public void Terminar() {
            Panel_R.Visible = true;
            int PF = M.puntaje * 10;
            labelRN.Text = $"Te has quedado el Nivel {M.nivel}\nPuntaje : {M.puntaje}\nPuntaje Final: {PF}";
            labelR.Text = "Te recomendamos en seguir practicando el ejercicio, además de tener una vida sana";
            User.Registrar_Resultados(PF, 4);
        }
    }
}
