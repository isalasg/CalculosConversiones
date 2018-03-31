using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazHectareasMetrosCuadrados
    {
        double Hectareas;
        double MetrosCuadrados;

        public InterfazHectareasMetrosCuadrados()
        {
            MetrosCuadrados = 0;
            Hectareas = 0;
        }

        public void PedirHectareas()
        {
            Console.Write("Ingrese el numero de Hectareas:");
            Hectareas = double.Parse(Console.ReadLine());
        }

        public void PedirMetrosCuadrados()
        {

            Console.Write("Ingrese el numero de Metros Cuadrados:");
            MetrosCuadrados = double.Parse(Console.ReadLine());
        }

        public double GetHectareas()
        {
            return Hectareas;
        }

        public double GetMetrosCuadrados()
        {
            return MetrosCuadrados;
        }

        public void ImprimirHectareas(Double Hectareas)
        {
            Console.WriteLine("Las Hectareas son {0}", Hectareas);
        }

        public void ImprimirMetrosCuadrados(Double MetrosCuadrados)
        {
            Console.WriteLine("Los Metros Cuadrados son {0}", MetrosCuadrados);
        }
    }
}
