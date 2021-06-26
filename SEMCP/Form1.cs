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
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            User = U;
            lbTitulo.Text = "Hola " + User.Nombre;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lista_Articulos(object sender, EventArgs e)
        {
            Ocultar();
            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);


            Form_LA FLA = new Form_LA(User);

            FLA.TopLevel = false;
            FLA.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FLA);
            PanelJuego.Tag = FLA;
            FLA.Show();
        }


        public void Ocultar()
        {
            //PanelJuego.BackColor = Color.White;
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

            PanelJuego.BackgroundImage = global::SEMCP.Properties.Resources.angryimg__2_;

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

        private void Memorama(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);


            Form_M FSN = new Form_M(User);

            FSN.TopLevel = false;
            FSN.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FSN);
            PanelJuego.Tag = FSN;
            FSN.Show();
        }

        private void Serie_Numeros(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);



            Form_SN FSN = new Form_SN(User);

            FSN.TopLevel = false;
            FSN.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FSN);
            PanelJuego.Tag = FSN;
            FSN.Show();
        }

        private void Simon_Dice(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);
            FormSD FSN= new FormSD(User);

            FSN.TopLevel = false;
            FSN.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FSN);
            PanelJuego.Tag = FSN;
            FSN.Show();
        }

        private void Lista_Animales(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);

            FormLA FSN = new FormLA(User);

            FSN.TopLevel = false;
            FSN.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FSN);
            PanelJuego.Tag = FSN;
            FSN.Show();
        }

        private void Cartas(object sender, EventArgs e)
        {
            Ocultar();

            if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);
            FromCC FSN = new FromCC(User);

            FSN.TopLevel = false;
            FSN.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(FSN);
            PanelJuego.Tag = FSN;
            FSN.Show();

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
            if (User.Tipo != 3)
            {
                Ocultar();

                if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);

                if (User.Tipo == 1)
                {
                    if (PanelJuego.Controls.Count > 0) PanelJuego.Controls.RemoveAt(0);
                    lbTitutloModulo.Text = "Progesos";
                    Form_Progresos FS = new Form_Progresos(User);

                    FS.TopLevel = false;
                    FS.Dock = DockStyle.Fill;
                    PanelJuego.Controls.Add(FS);
                    PanelJuego.Tag = FS;
                    FS.Show();

                }
                if (User.Tipo == 2)
                {
                    lbTitutloModulo.Text = "Progreso";
                    Form_Progreso FS = new Form_Progreso(User);

                    FS.TopLevel = false;
                    FS.Dock = DockStyle.Fill;
                    PanelJuego.Controls.Add(FS);
                    PanelJuego.Tag = FS;
                    FS.Show();

                }
            }

            
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
