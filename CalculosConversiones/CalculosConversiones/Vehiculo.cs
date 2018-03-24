using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Vehiculo
    {
        private float Velocidad;
        private float Tiempo;
        private float Distancia;

        public Vehiculo()
        {
            Velocidad = 0;
            Tiempo = 0;
            Distancia = 0;
        }

        public void SetVelocidad(float Velocidad)
        {
            this.Velocidad = Velocidad;
        }

        public void SetTiempo(float Tiempo)
        {
            this.Tiempo = Tiempo;
        }

        public void SetDistancia(float Distancia)
        {
            this.Distancia = Distancia;
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

        public void CalcularVelocidad()
        {
            Velocidad = Distancia / Tiempo;
        }

        public void CalcularTiempo()
        {
            Tiempo = Distancia / Velocidad;
        }

        public void CalcularDistancia()
        {
            Distancia = Velocidad * Tiempo;
        }
    }
}
