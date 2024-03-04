using System;
using System.Diagnostics.Eventing.Reader;

namespace PrefinalPOO.Montes.Entidades
{
    public static class Triangulo
    {
        private static int ladoA;
        private static int ladoB;
        private static int ladoC;

        public static int ValidarTriangulo(int LadoA, int LadoB, int LadoC)
        {
            if (ladoA < 0 || ladoB < 0 || ladoC < 0)
            {
                throw new ArgumentException("Los lados deben ser mayores a 0");
            }
            
            return ValidarTriangulo(LadoA, LadoB, LadoC);

        }

        public static int TipodeTriangulo(int LadoA, int LadoB, int LadoC)
        {

            if (ladoA == ladoB || ladoA == ladoC || ladoB==ladoC)
            {
                throw new ArgumentException("Tiene 2 lado iguales lo cual es un isosceles ");
            }
            else if (ladoA != ladoB || ladoA != ladoC || ladoB != ladoC)
            {
                throw new ArgumentException("No tiene ningun lado igual lo cual es un escaleno ");
            }
            else
            {
                throw new ArgumentException("Tiene todos sus lados iguales lo cual es un equilatero ");
            }

        }
    }
}
