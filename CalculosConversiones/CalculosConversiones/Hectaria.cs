using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculosConversiones
{
    class Hectaria
    {
        double hectarias;
        double metroscuadrados;

        public Hectaria()
        {
            metroscuadrados = 0;
            hectarias = 0;
        }

        public void Sethectarias(float hctarias)
        {
            this.hectarias = hectarias;
        }
        public void Setmetroscuadrados(float metrosuadrados)
        {
            this.metroscuadrados = metroscuadrados;
        }


        public double Gethectarias()
        {
            return hectarias;
        }
        public double Getmetroscuadrados()
        {
            return metroscuadrados;
        }

    }
}
