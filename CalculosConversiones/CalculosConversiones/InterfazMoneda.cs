using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazMoneda
    {
        private double Monto;
        private double Total;

        public InterfazMoneda()
        {
            Monto = 0;
            Total = 0;
        }

        public void PedirMonto()
        { 
            Console.Write("Escribe la cantidad a cambiar: ");
            Monto = double.Parse(Console.ReadLine());
        }

        public double GetMonto()
        {
            return Monto;
        }
        public void SetMonto(double Monto)
        {
            this.Monto = Monto;
        }
        public double GetTotal()
        {
            return Total;
        }
        public void SetTotal(double Total)
        {
            this.Total = Total;
        }

        public void ImprimirTotal(double Total)
        {
            Console.WriteLine("Tu tienes : " + Total + " despues de cambiarlo ");
        }
    }
}
