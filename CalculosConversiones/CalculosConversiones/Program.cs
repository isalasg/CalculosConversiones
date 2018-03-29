using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galones_Litros
{
    class Program
    {
        static void Main(string[] args)
        {
            int litros, galones;
            double resLitros, resGalones;

            Console.WriteLine("Introuce los litros");
            litros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introuce los Galones");
            galones = Convert.ToInt32(Console.ReadLine());

            resLitros = litros * 0.26417205 / 1;
            resGalones = galones * 3.78541178 / 1;

            Console.WriteLine("La conversion de Litros a Galones es: " + resLitros);
            Console.WriteLine("La conversion de Galones a Litros es: " + resGalones);

            Console.ReadKey();



        }
    }
}
