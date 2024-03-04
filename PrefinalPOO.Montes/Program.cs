using PrefinalPOO.Montes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefinalPOO.Montes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio N°1");

            Console.WriteLine("Informacion Priramide Rectangular");

            Console.Write("Ingrese el valor de la base Mayor:  ");
            var baseMayor = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la base Menor:  ");
            var baseMenor = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la Altura: ");
            var altura = double.Parse(Console.ReadLine());

            PiramideRectangular piramideRectangular = new PiramideRectangular(altura, baseMenor, baseMayor);
            Console.WriteLine($"{piramideRectangular.GetValores()}");

            Console.WriteLine("Presione ENTER para pasar al sieguiente ejercicio");
            Console.ReadLine();
            Console.WriteLine("-----------------------------");

           

            Console.Clear();
            Console.WriteLine("Ejercicio N°2");
          
            var ladoA = PedirInt("Ingrese el ladoA: ");
            var ladoB = PedirInt("Ingrese el ladoB: ");
            var ladoC = PedirInt("Ingrese el ladoC: ");
            Console.WriteLine($"{ Triangulo.ValidarTriangulo(ladoA,ladoB, ladoC)}");

            Console.WriteLine($"{Triangulo.TipodeTriangulo(ladoA, ladoB, ladoC)}");
            Console.WriteLine();


            Console.WriteLine("Presione ENTER para pasar al sieguiente ejercicio");
            Console.ReadLine();

        }

        private static int PedirInt(string mensaje)
        {
            int nro;
            do
            {
                string str;
                Console.Write(mensaje);
                str = Console.ReadLine();

                if (int.TryParse(str, out nro))
                {
                    break;
                }
                Console.WriteLine("Número no válido");

            } while (true);
            return nro;

        }

    }
}
