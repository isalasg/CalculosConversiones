using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Kelvin
    {
        private double GradosKelvin;
        private double Convertir;


        public Kelvin()
        {
            GradosKelvin = 0;
            Convertir = 0;
        }
        public double SetGradosKelvin(double GradosKelvin)
        {
            return GradosKelvin;
        }
        public double GetGradosKelvin()
        {
            return GradosKelvin;
        }
        public double SetConvertir(double Convertir)
        {
            return Convertir;
        }
        public double GetConvertir()
        {
            return Convertir;
        }
        //Grados Kelvin a Celcius 
        public void CovertirKelvinaCelcius()
        {
            Convertir = GradosKelvin - 273.15;
        }
    }
}
