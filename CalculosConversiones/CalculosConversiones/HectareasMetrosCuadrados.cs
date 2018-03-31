using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class HectareasMetrosCuadrados
    {
        double Hectareas;
        double MetrosCuadrados;

        public HectareasMetrosCuadrados()
        {
            MetrosCuadrados = 0;
            Hectareas = 0;
        }

        public void SetHectareas(float Hectareas)
        {
            this.Hectareas = Hectareas;
        }

        public void SetMetrosCuadrados(float MetrosCuadrados)
        {
            this.MetrosCuadrados = MetrosCuadrados;
        }

        public double GetHectareas()
        {
            return Hectareas;
        }

        public double GetMetrosCuadrados()
        {
            return MetrosCuadrados;
        }

        public void CalcularMetrosCuadrados()
        {
            MetrosCuadrados = Hectareas * 10000;
        }

        public void CalcularHectareas()
        {
            Hectareas = MetrosCuadrados / 10000;
        }
    }
}
