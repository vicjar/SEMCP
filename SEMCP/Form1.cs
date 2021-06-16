using SEMCP.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace SEMCP
{
    public partial class Form1 : Form
    {
        Usuario User;

        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1(Usuario U)
        {
            InitializeComponent();
            User = U;
            lbTitulo.Text = "Hola " + User.Nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bc1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ocultar();
            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);


            //Form_LA FLA = new Form_LA(User);

            //FLA.TopLevel = false;
            //FLA.Dock = DockStyle.Fill;
            //PanelJuego.Controls.Add(FLA);
            //PanelJuego.Tag = FLA;
            //FLA.Show();
        }


        public void Ocultar()
        {
            PanelJuego.BackColor = Color.White;
            bc6.Size = new System.Drawing.Size(976, 162);
            PanelJuego.Location = new System.Drawing.Point(157, 121);
            PanelJuego.Size = new System.Drawing.Size(930, 470);


            CardAnimales.Visible = false;
            CardArticulos.Visible = false;
            CardCartas.Visible = false;
            CardMemorama.Visible = false;
            CardNumeros.Visible = false;
            CardSimon.Visible = false;
            lbTitulo.Text = "Hola " + User.Nombre;

        }

        public void Mostrar()
        {
            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);

            PanelJuego.BackColor = Color.FromArgb(224, 224, 224);

            bc6.Size = new System.Drawing.Size(976, 279);
            PanelJuego.Location = new System.Drawing.Point(157, 238);
            PanelJuego.Size = new System.Drawing.Size(931, 350);

            CardAnimales.Visible = true;
            CardArticulos.Visible = true;
            CardCartas.Visible = true;
            CardMemorama.Visible = true;
            CardNumeros.Visible = true;
            CardSimon.Visible = true;

            lbTitutloModulo.Text = "Inicio";
            lbTitulo.Text = "Hola " + User.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);


            //Form_M FSN = new Form_M(User);

            //FSN.TopLevel = false;
            //FSN.Dock = DockStyle.Fill;
            //PanelJuego.Controls.Add(FSN);
            //PanelJuego.Tag = FSN;
            //FSN.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);



            //Form_SN FSN = new Form_SN(User);

            //FSN.TopLevel = false;
            //FSN.Dock = DockStyle.Fill;
            //PanelJuego.Controls.Add(FSN);
            //PanelJuego.Tag = FSN;
            //FSN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (User.Tipo != 3) {
                Ocultar();

                if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);

                if (User.Tipo == 1)
                {
                    lbTitutloModulo.Text = "Cuentas";
                    Form_Cuentas FSN = new Form_Cuentas(User);

                    FSN.TopLevel = false;
                    FSN.Dock = DockStyle.Fill;
                    PanelJuego.Controls.Add(FSN);
                    PanelJuego.Tag = FSN;
                    FSN.Show();

                }
                if (User.Tipo == 2)
                {
                    lbTitutloModulo.Text = "Cuenta";
                    Form_Cuenta FS = new Form_Cuenta(User);

                    FS.TopLevel = false;
                    FS.Dock = DockStyle.Fill;
                    PanelJuego.Controls.Add(FS);
                    PanelJuego.Tag = FS;
                    FS.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Login fm = new Form_Login();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }



    }
}
