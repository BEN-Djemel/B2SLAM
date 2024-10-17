using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;

            float nbEtoile = 0;
            Console.WriteLine("Saisir le nbre d'étoiles à afficher :");
            nbEtoile = Convert.ToSingle(Console.ReadLine());

            for (int j = 0; j < nbEtoile; j++) { Console.Write("*"); }

            for (int i = 0; i < (nbEtoile-2); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < (nbEtoile-1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("*");
                    }
                    else if (j == (nbEtoile-2))
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
            }

            Console.Write("\n");

            for (int l = 0; l < nbEtoile; l++) { Console.Write("*"); }

            Console.ReadKey();
        }
    }
}