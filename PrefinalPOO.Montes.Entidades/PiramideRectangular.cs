using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefinalPOO.Montes.Entidades
{
    public class PiramideRectangular
    {
        private double baseMenor;
        private double baseMayor;
        private double altura;


        public PiramideRectangular(double BaseMayor, double BaseMenor, double Altura)
        {
            if (Altura <= 0 || BaseMenor <= 0 || BaseMayor <= 0)
            {
                throw new ArgumentException("La base mayor, la base menor y la altura deben ser mayores a 0");
            }
            altura = Altura;
            baseMayor = BaseMayor;
            baseMenor = BaseMenor;
        }
        public double BaseMayor
        {
            get { return baseMayor; }
            set { baseMayor = value; }
        }
        public double BaseMenor
        {
            get { return baseMayor; }
            set { baseMayor = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double GetCalcularAreaMayor() => Math.Pow(baseMayor, 2);

        public double GetCalcularAreaMenor() => Math.Pow(baseMenor, 2);

        public double GetCalcularAlturaTrapecio() => Math.Sqrt(Math.Pow((baseMayor / 2) - (baseMenor / 2), 2) + altura);
        public double GetCalcularAreaTrapecio() => ((baseMayor+baseMenor)/ 2)*GetCalcularAlturaTrapecio();

        public double GetArea() =>  (baseMayor + baseMenor + 4  + GetCalcularAreaTrapecio());
       
        public double GetVolumen()=> (altura / 3) + (baseMayor * baseMenor * Math.Sqrt(baseMayor * baseMenor));




        public string GetValores()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La altura de la piramide es: {altura}");
            sb.AppendLine($"La Base Mayor de la piramide es: {baseMayor}");
            sb.AppendLine($"La Base Menor de la piramide es: {baseMenor}");
            sb.AppendLine($"El Volumen de la piramide es: {GetVolumen()}");
            sb.AppendLine($"El Area de la piramide es: {GetArea()}");
            return sb.ToString();
        }
    }
}
