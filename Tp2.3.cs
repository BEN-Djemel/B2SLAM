using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float nombre1 = 0;
            float nombre2 = 0;

            Console.WriteLine("Veuillez saisir un premier nombre");
            nombre1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un deuxième nombre");
            nombre2 = Convert.ToSingle(Console.ReadLine());

            if (nombre1 == nombre2)
            {
                Console.WriteLine("les deux nombres sont égaux");
            }
            else if (nombre1 < nombre2)
            {
                Console.WriteLine("{0} est le plus petit est nombre", nombre1);
            }
            else
            {
                Console.WriteLine("{0} est le plus petit est nombre", nombre2);
            }

            Console.ReadKey();
        }
    }
}
