using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class InterfazHectaria
    {
        double hectarias;
        double metroscuadrados;

        public InterfazHectaria()
        {
            metroscuadrados = 0;
            hectarias = 0;
        }
        public void PedirVehectaria()
        {
            Console.Write("Ingrese el numero de hectarias:");
            hectarias = double.Parse(Console.ReadLine());
        }
        public void Pedirmetroscuadrados()
        {

            Console.Write("Ingrese el numero de Metros Cuadrados:");
            metroscuadrados = double.Parse(Console.ReadLine());
        }
        public double Gethectarias()
        {
            return hectarias;
        }
        public double Getmetroscuadrados()
        {
            return metroscuadrados;
        }

        public void Imprimirhectarias(Double hectarias)
        {
            Console.WriteLine(" {0} Ectarias equivalen a {1} metroscuadrados", hectarias, metroscuadrados);


        }
        public void ImprimirMetrosCuadrados(Double metroscuadrados)
        {
            Console.WriteLine(" {0} metros cuadrados equivalen a {1} hectarias", metroscuadrados, hectarias);
        }
    }
}
