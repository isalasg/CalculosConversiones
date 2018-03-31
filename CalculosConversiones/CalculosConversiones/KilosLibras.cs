using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class KilosLibras
    {
        private double Kilo;
        private double Libra;

        public KilosLibras()
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

        public void CalcularLibrasAKilos()
        {
            Kilo = Libra * 0.453592;
        }

        public void CalcularKilosALibras()
        {
            Libra = Kilo * 2.20462;
        }
    }
}
