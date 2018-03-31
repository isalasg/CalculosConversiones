using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazVehiculo
    {
        private float Velocidad;
        private float Tiempo;
        private float Distancia;

        public InterfazVehiculo()
        {
            Velocidad = 0;
            Tiempo = 0;
            Distancia = 0;
        }

        public void PedirVelocidad()
        {
            Console.Write("Dame velocidad: ");
            Velocidad = float.Parse(Console.ReadLine());
        }

        public void PedirTiempo()
        {
            Console.Write("Dame tiempo: ");
            Tiempo = float.Parse(Console.ReadLine());
        }

        public void PedirDistancia()
        {
            Console.Write("Dame distancia: ");
            Distancia = float.Parse(Console.ReadLine());
        }

        public float GetVelocidad()
        {
            return Velocidad;
        }

        public float GetTiempo()
        {
            return Tiempo;
        }

        public float GetDistancia()
        {
            return Distancia;
        }

        public void ImprimirVelocidad(float Velocidad)
        {
            Console.WriteLine("La velocidad es: " + Velocidad);
        }

        public void ImprimirTiempo(float Tiempo)
        {
            Console.WriteLine("El tiempo es: " + Tiempo);
        }

        public void ImprimirDistancia(float Distancia)
        {
            Console.WriteLine("La distancia es: " + Distancia);
        }


    }
}