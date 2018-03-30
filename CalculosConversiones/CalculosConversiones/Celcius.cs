using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Celcius
    {
        private double GradosCelcius;
        private double Convertir;


        public Celcius()
        {
            GradosCelcius = 0;
            Convertir = 0;
        }
        public double SetGradosCelcius(double GradosCelcius)
        {
            return GradosCelcius;
        }
        public double GetCelcius()
        {
            return GradosCelcius;
        }
        public double SetConvertir(double Convertir)
        {
            return Convertir;
        }
        public double GetConvertir()
        {
            return Convertir;
        }
        //Grados Celcius a Kelvin 
        public void CovertirCelciusaKelvin()
        {
            Convertir = GradosCelcius + 273.15;
        }

    }
}
