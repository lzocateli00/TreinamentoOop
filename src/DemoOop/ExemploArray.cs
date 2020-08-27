using System;
using System.Linq;

namespace DemoOop
{
    public class ExemploArray
    {


        public void MeuArray(string[] argumentos)
        {

            var tamanho = argumentos.Length;
            var dimensao = argumentos.Rank;

            var Inicio = argumentos.GetLowerBound(0);
            var Final = argumentos.GetUpperBound(0);

            Console.WriteLine($"Inicio: {Inicio}");
            Console.WriteLine($"Final: {Final}");
            Console.WriteLine($"Elementos: {tamanho}");
            Console.WriteLine($"Dimansão: {dimensao}");


            string[] minhaMatriz = new string[3];
            minhaMatriz.SetValue("Elemento 1", 0);
            minhaMatriz.SetValue("Elemento 2", 1);
            minhaMatriz.SetValue("Elemento 3", 2);

            //minhaMatriz.SetValue("Elemento 4", 3);


            string[] carnes = new string[]
            {
                "Picanha",
                "FileMignon",
                "Patinho",
                "Costela"
            };


            var temElemento = carnes.ElementAtOrDefault(10);
            var elementos = carnes.Count();

            var fileElemento = Array.IndexOf(carnes, "FileMignon");
            var fileCadeVoce = Array.BinarySearch(carnes, "FileMignon");

            var elementoValor = carnes.ElementAtOrDefault(fileCadeVoce);


            Console.WriteLine($"Valor: {elementoValor} posicao: {fileCadeVoce}");

            //////////////////////////////////////////////////////////////////////
            /// 2D


            string[,] biDimensional = new string[3, 5];
            // 1
            biDimensional[0, 0] = "1";
            biDimensional[0, 1] = "2";
            biDimensional[0, 2] = "3";
            biDimensional[0, 3] = "4";
            biDimensional[0, 4] = "5";

            // 2
            biDimensional[1, 1] = "2a";
            biDimensional[1, 2] = "2b";
            biDimensional[1, 3] = "2c";

            // 3
            biDimensional[2, 2] = "3a";
            biDimensional[2, 2] = "3b";



            //////////////////////////////////////////////////////////////////////
            /// Join e Split

            var clienteId = Guid.NewGuid().ToString();
            var matriz = clienteId.Split('-');

            Console.WriteLine($"Cliente ID: {clienteId}");
            Console.WriteLine($"Parte 1: {matriz[0]}");
            Console.WriteLine($"Parte 2: {matriz[1]}");
            Console.WriteLine($"Parte 3: {matriz[2]}");
            Console.WriteLine($"Parte 4: {matriz[3]}");
            Console.WriteLine($"Parte 5: {matriz[4]}");


            string texto = "Essa frase é um exemplo de split e join para os aluninhos";

            matriz = texto.Split(' ');

            foreach (var item in matriz)
            {
                Console.WriteLine($"{item}");
            }



            var novoTexto = string.Join(" ", matriz);
            Console.WriteLine($"{novoTexto}");

        }

    }
}
