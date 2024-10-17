using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float chiffreAffaire = 0;
            float prime = 0;

            Console.WriteLine("Veuillez indiquer votre chiffre d'affaire");
            chiffreAffaire = Convert.ToSingle(Console.ReadLine());

            if (chiffreAffaire >= 10000f)
            {
                prime = (chiffreAffaire - 10000) * 0.04f;
                Console.WriteLine("Votre prime s'élève à {0} euros", prime);
            }
            else
            {
                Console.WriteLine("Votre chiffre d'affaire est inferieur à 10 000 euros, vous n'avez pas de primes.");
            }

            Console.ReadKey();
        }
    }
}
