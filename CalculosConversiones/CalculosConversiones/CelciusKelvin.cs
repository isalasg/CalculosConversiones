using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class CelciusKelvin
    {
        private double GradosCelcius;
        private double GradosKelvin;

        public CelciusKelvin()
        {
            GradosCelcius = 0;
            GradosKelvin = 0;
        }

        public void SetGradosCelcius(double GradosCelcius)
        {
            this.GradosCelcius =GradosCelcius;
        }

        public double GetGradosCelcius()
        {
            return GradosCelcius;
        }

        public void SetGradosKelvin(double GradosKelvin)
        {
            this.GradosKelvin = GradosKelvin;
        }

        public double GetGradosKelvin()
        {
            return GradosKelvin;
        }

        public void CovertirCelciusAKelvin()
        {
            GradosKelvin = GradosCelcius + 273.15;
        }

        public void ConvertirKelvinACelcius()
        {
            GradosCelcius = GradosKelvin - 273.15;
        }
    }
}
