using System;
using System.Collections.Generic;
using System.Text;

namespace SEMCP
{
    public class Canasta
    {
        // Clase Canasta - Lista de Articulos

        public List<String> Lista = new List<string>();

        public Canasta() {
            LLenar_Lista();
        }

        public void LLenar_Lista() {

            Lista.Add("Aceite");
            Lista.Add("Arroz");
            Lista.Add("Sopa");
            Lista.Add("Manzana");
            Lista.Add("Vaso");
            Lista.Add("Agua");
            Lista.Add("Galleta");
            Lista.Add("Huevo");
            Lista.Add("Leche");
            Lista.Add("Chile");
            Lista.Add("Pan");
            Lista.Add("Pasta");
            Lista.Add("Tortilla");
            Lista.Add("Te");
            Lista.Add("Café");
            Lista.Add("Plato");
            Lista.Add("Jabón");
            Lista.Add("Toallas");
            Lista.Add("Carne");
            Lista.Add("Naranja");
            Lista.Add("Sandia");
            Lista.Add("Limón");
            Lista.Add("Jamaica");
            Lista.Add("Aguacate");
            Lista.Add("Papel");
            Lista.Add("Queso");
            Lista.Add("Cereal");
            Lista.Add("Salsa");
            Lista.Add("Sal");
            Lista.Add("Azucar");
            Lista.Add("Cuchara");
            Lista.Add("Tenedor");
            Lista.Add("Taza");
            Lista.Add("Cepillo");
            Lista.Add("Crema");
            Lista.Add("Pilas");
            Lista.Add("Lápiz");
            Lista.Add("Sacapuntas");
            Lista.Add("Pelota");
            Lista.Add("Juguete");
            Lista.Add("Cargador");
            Lista.Add("Jamón");
            Lista.Add("Salchicha");
            Lista.Add("Pescado");
            Lista.Add("Nopal");
            Lista.Add("Papa");
            Lista.Add("Tomate");
            Lista.Add("Pepino");
            Lista.Add("Repollo");
            Lista.Add("Pluma");
            Lista.Add("Liberta");
        }

        public List<String> Revolver(List<String> L) {
            Random random = new Random();
            int x = L.Count;

            while (x > 1) {
                x--;
                int Aux = random.Next(x + 1);
                String P = L[x];
                L[x] = L[Aux];
                L[Aux] = P;
            }

            return L;
        }

        public (List<String>, List<String>) Pedir(int Nivel) {

            Lista = Revolver(Lista);

            List<String> A = Revolver(Lista.GetRange(0, Nivel + 2));
            List<String> B = Revolver(Lista.GetRange(0, 20));

            return (A, B);
        }



    }
}
