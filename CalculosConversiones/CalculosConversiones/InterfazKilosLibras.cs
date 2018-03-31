using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazKilosLibras
    {
        private double Kilo;
        private double Libra;

        public InterfazKilosLibras()
        {
            Kilo = 0;
            Libra = 0;
        }

        public void PedirKilo()
        {
            Console.Write("Escribe cuantos kilos quieres convertir a Libras");
            Kilo = double.Parse(Console.ReadLine());
        }

        public void PedirLibra()
        {
            Console.Write("Escribe cuantos Libras quieres convertir a Kilos");
            Kilo = double.Parse(Console.ReadLine());
        }

        public double GetKilo()
        {
            return Kilo;
        }

        public double GetLibra()
        {
            return Libra;
        }

        public void ImprimirKilo(double Kilo)
        {
            Console.WriteLine("El resultado es: " + Kilo);
        }

        public void ImprimirLibra(double Libra)
        {
            Console.WriteLine("El resultado es: " + Libra);
        }

    }
}
