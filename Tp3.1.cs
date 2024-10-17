using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            float nbEtoile = 0;
            Console.WriteLine("Saisir le nbre d'étoiles à afficher :");
            nbEtoile = Convert.ToSingle(Console.ReadLine());

            for (int i=0; i < nbEtoile; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
