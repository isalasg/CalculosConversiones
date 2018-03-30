using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Conversion
    {
        private double Kilo;
        private double Libra;


        public Conversion()
        {
            Kilo = 0;
            Libra = 0;

        }

        public void SetKilo(double Kilo)
        {
            this.Kilo = Kilo;
        }

        public double GetKilo()
        {
            return Kilo;
        }


        public void SetLibra(double Libra)
        {
            this.Libra = Libra;
        }

        public double GetLibra()
        {
            return Libra;
        }

        public void CalcularLK()
        {
            Kilo = Libra * 0.453592;
        }
        public void CalcularKL()
        {
            Libra = Kilo * 2.20462;
        }


    }
}
