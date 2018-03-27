using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Moneda
    {
        private double Monto;
        private double Total;

        public Moneda()
        {
            Monto = 0;
            Total = 0;
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
        //Pesos a Dolares
        public void CambiarPesoDolar()
        {
            Total = Monto * 0.05455;
        }
        //Pesos a Euros
        public void CambiarPesoEuro()
        {
            Total = Monto * 0.04383;
        }

        //Dolares a Pesos
        public void CambiarDolarPeso()
        {
            Total = Monto * 18.3345;
        }
        //Dolares a Euros
        public void CambiarDolarEuro()
        {
            Total = Monto * 0.80335;
        }

        //Euros a Pesos
        public void CambiarEuroPeso()
        {
            Total = Monto * 22.8134;
        }
        //Euros a Dolares
        public void CambiarEuroDolar()
        {
            Total = Monto * 1.2443;
        }

    }
}
