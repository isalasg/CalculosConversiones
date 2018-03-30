using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazGradosC_K
    {
        private double GradosCelcius;
        private double Convertir;


        public InterfazGradosC_K()
        {
            GradosCelcius = 0;
            Convertir = 0;
        }

        public void PedirGradosCelcius()
        {
            Console.WriteLine("Introduce la temperatura en grados celcius que deceas convertir Kelvin:");
            double GradosCelcius = double.Parse(Console.ReadLine());
            Console.ReadKey();
        }
        public double SetCelcius()
        {
            return GradosCelcius;
        }

        public double SetConvertir()
        {
            return Convertir;
        }
        public double GetConvetir()
        {
            return Convertir;
        }

        public void ImprimirConversion(double Convertir)
        {
            Console.WriteLine("Los grados en Kelvin son : " + Convertir + "k");
        }
    }
}
