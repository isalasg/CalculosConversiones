using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazConversion
    {
        private double Kilo;
        private double Libra;

        public InterfazConversion()
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
