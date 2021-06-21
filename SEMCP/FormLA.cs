using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SEMCP
{
    public partial class FormLA : Form
    {
        int puntaje=0, tiempo =21, aciertos=-1;
        static string[] animales =
             {"Águilas","Avestruz","Ballena","Ballena","Bisonte","Búfalo","Búhos","Buitre","Burro","Caballo","Cabra","Camaleón","Camello","Canario","Castor","Cebra","Cerdo","Ciervo",
             "Cobra","Colibrí","Comadreja","Cóndor","Conejo","Delfín","Elefante","Faisan","Flamenco","Foca","Gallina","Gallo","Gato","Gorila","Guepardo","Hámster","Hiena","Hipopótamo","Jabalí","Jaguar","Jirafa","Koala","Lagarto","León","León marino","Llama","Lobo","Loro","Manatí","Mapache","Mono",
             "Murciélago","Nutria","Ñandú","Orcas","Oso hormiguero","Oso marino","Oso","Oso polar","Pájaro carpintero","Paloma","Panda","Pato","Pavo real","Pelícano","Perro","Pingüino","Puercoespín","Puma","Rana","Ratón","Reno","Rinoceronte","Salamandra","Sapo","Serpiente","Tapir","Tejon","Tiburón","Tigre","Topo","Toro","Tucán","Vaca","Vicuñas","Zorrillo","Zorro"};
        string[] colores =
             {"amarillo","ámbar","azul","blanco","café","caqui","carmesí","castaño","celeste","cian","cobre","coral","crema","fucsia","gris","lila","magenta",
             "marrón","morado","naranja","negro","dorado","plata","púrpura","rojo","rosa","turquesa","verde","violeta"};
        string[] adjetivos =
        {
                "grande","pequeño","alto","bajo","gordo","flaco","ancho","largo","estrecho","fino","grueso","delicado","grotesco","inteligente", "tonto","hábil",
                "torpe","culto","ignorante","limpio","sucio","frío","caliente","tibio","cálido","helado", "espontáneo","simple","complicado","sencillo","amable",  "gentil",
                "rudo","bruto","astuto", "ingenuo","humilde","modesto","presumido","altanero","curioso","apático","bello","hermoso","feo","horrible","agradable","desagradable",
                "lento","veloz","rápido","maduro","inmaduro","dulce","amargo","ácido","salado","blando","rugoso","suave","áspero","aterciopelado","arrugado","liso","sedoso","duro",
                "pegajoso","adherente","común","ordinario","elegante","tímido","audaz","extrovertido","introvertido","entusiasta","alegre","feliz","triste","contento","desanimado","animado",
            };
        
        Random rnd = new Random();
        public class Animales
        {
            public string Nombre { get; set; }
            public string Color { get; set; }
            public string Adjetivo { get; set; }
        }
        List<Animales> animalesLista = new List<Animales>();
       
        public FormLA()
        {
            InitializeComponent();
        }

        public void FormLA_Load(object sender, EventArgs e)
        {
            Array.Sort(adjetivos);
            labelLista.Text = "";
            listaRecordar();
            llenarListaAnimal();
            timer1.Enabled = true;
        }
        public void listaRecordar()
        {
        //    for (int i = 0; i <= puntaje; i++)
           // {
                Animales animal = new Animales();
                animal.Nombre = animales[rnd.Next(0, animales.Length)];
                animal.Color = colores[rnd.Next(0, colores.Length)];
                animal.Adjetivo = adjetivos[rnd.Next(0, adjetivos.Length)];
                animalesLista.Add(animal);
                //labelLista.Text += animal.Nombre + "   " + animal.Color + "  " + animal.Adjetivo + " \n";

            llenarLabel();
        }
        public void llenarLabel()
        {
            labelLista.Text = "";
            foreach(Animales animal in animalesLista)
            {
                labelLista.Text += animal.Nombre + "   " + animal.Color + "  " + animal.Adjetivo + " \n";
            }
        }
        public void contadorTiempo(int t)
        {
            lTiempo.Text = "Tiempo para memorizar: " + t;
        }

            public void llenarListaAnimal()
        {
            for (int i = 0; i < animales.Length; i++)
            {
                string animal = animales[i];
                listBox1.Items.Add(animal);
            }
            for (int i = 0; i < colores.Length; i++)
            {
                string color = colores[i];
                listBox2.Items.Add(color);
            }
            for (int i = 0; i < adjetivos.Length; i++)
            {
                string adjetivo = adjetivos[i];
                listBox3.Items.Add(adjetivo);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Animales animalCreado = new Animales();
            animalCreado.Nombre = listBox1.SelectedItem.ToString();
            animalCreado.Color = listBox2.SelectedItem.ToString();
            animalCreado.Adjetivo = listBox3.SelectedItem.ToString();

            if (animalesLista.Exists(x => x.Nombre == animalCreado.Nombre && x.Color == animalCreado.Color && x.Adjetivo == animalCreado.Adjetivo))
            {
                MessageBox.Show("Si existe en el listado");
                lTiempo.Visible = true;
                aciertos++;
                lListaAcierto.Text += "\n" + animalCreado.Nombre + " " + animalCreado.Color + " " + animalCreado.Adjetivo;
                if(aciertos >= puntaje)
                {
                    listaRecordar();
                    puntaje++;
                    aciertos = -1;
                    labelLista.Visible = true;
                    lListaAcierto.Text = "";
                    labelPuntaje.Text = "Puntaje: " + puntaje;
                    timer1.Start();

                }
                    

            }
            else
            {
                MessageBox.Show("No existe");
                lTiempo.Visible = true;
                puntaje = 0;
                timer1.Start();
                labelLista.Visible = true;
                animalesLista.Clear();
                listaRecordar();
                labelPuntaje.Text = "Puntaje: " + puntaje;
                lListaAcierto.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo < 1)
            {
                timer1.Stop();
                tiempo = 21;
                labelLista.Visible = false;
                lTiempo.Visible = false;
            }
            lTiempo.Text = "Tiempo restante:" + tiempo--;
        }
    }
}
