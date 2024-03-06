using System;
using System.Diagnostics.Eventing.Reader;

namespace PrefinalPOO.Montes.Entidades
{
    public static class Triangulo
    {
        private static int ladoA;
        private static int ladoB;
        private static int ladoC;

        public static bool ValidarTriangulo(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                Console.WriteLine("Los lados deben ser mayores a 0");
            }
            return  true;


        }

        public static string TipodeTriangulo(int ladoA, int ladoB, int ladoC)
        {

            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
            {
                return "Tiene todos sus lados iguales lo cual es un equilatero ";
            }
            else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
            {
                return "No tiene ningun lado igual lo cual es un escaleno ";
            }
            else
            {
                return "Tiene 2 lado iguales lo cual es un isosceles " ;
            }

        }
    }
}
