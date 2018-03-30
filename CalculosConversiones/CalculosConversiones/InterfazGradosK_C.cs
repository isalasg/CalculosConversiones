using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazGradosK_C
    {
        private double GradosKelvin;
        private double Convertir;


        public InterfazGradosK_C()
        {
            GradosKelvin = 0;
            Convertir = 0;
        }

        public void PedirGradoskelvin()
        {
            Console.WriteLine("Introduce la temperatura en grados Kelvin que deceas convertir a Celcius:");
            double Celcius = double.Parse(Console.ReadLine());
            Console.ReadKey();
        }
        public double SetGradosKelvin()
        {
            return GradosKelvin;
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
            Console.WriteLine("Los grados en Celcius son : " + Convertir + "C");
            Console.ReadKey();
        }
    }
}
