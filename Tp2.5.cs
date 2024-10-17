using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float nombre1 = 0;
            float nombre2 = 0;
            float nombre3 = 0;

            Console.WriteLine("Veuillez saisir un premier nombre");
            nombre1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un deuxième nombre");
            nombre2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un troisième nombre");
            nombre3 = Convert.ToSingle(Console.ReadLine());

            if (nombre1 < nombre2 && nombre1 < nombre3)
            {
                Console.WriteLine("{0} est le plus petit nombre.", nombre1);
            }
            else if (nombre2 < nombre1 && nombre2 < nombre3)
            {
                Console.WriteLine("{0} est le plus petit est nombre", nombre2);
            }
            else if ( nombre3 < nombre1 && nombre3 < nombre2)
            {
                Console.WriteLine("{0} est le plus petit est nombre", nombre3);
            }
            else
            {
                Console.WriteLine("Merci de saisir trois nombres différents.");
            }
            Console.ReadKey();
        }
    }
}
