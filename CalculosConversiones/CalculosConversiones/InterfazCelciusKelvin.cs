using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazCelciusKelvin
    {
        private double GradosCelcius;
        private double GradosKelvin;


        public InterfazCelciusKelvin()
        {
            GradosCelcius = 0;
            GradosKelvin = 0;
        }

        public void PedirGradosCelcius()
        {
            Console.WriteLine("Introduce la temperatura en grados Celcius que deceas convertir Kelvin:");
            GradosCelcius = double.Parse(Console.ReadLine());
        }

        public void PedirGradosKelvin()
        {
            Console.WriteLine("Introduce la temperatura en grados Kelvin que deceas convertir Celcius:");
            GradosKelvin = double.Parse(Console.ReadLine());
        }

        public double GetGradosCelcius()
        {
            return GradosCelcius;
        }

        public double GetGradosKelvin()
        {
            return GradosKelvin;
        }

        public void ImprimirGradosCelcius(double GradosCelcius)
        {
            Console.WriteLine("Los grados en Celcius son : " + GradosCelcius + "c");
        }

        public void ImprimirGradosKelvin(double GradosKelvin)
        {
            Console.WriteLine("Los grados en Kelvin son : " + GradosKelvin + "k");
        }
    }
}
