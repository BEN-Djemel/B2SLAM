using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            float baseRectangle = 0;
            float hauteur = 0;
            float air = 0;

            Console.WriteLine("Quelle est la base en cm du rectangle ?");
            baseRectangle = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Quelle est la hauteur en cm du rectangle ?");
            hauteur = Convert.ToSingle(Console.ReadLine());

            // A = longueur * largeur

            air = baseRectangle * hauteur;

            Console.Clear();
            Console.WriteLine("Pour une hauteur de {0} cm et une base de {1} cm nous avons l'air qui fait {2} cm².", hauteur, baseRectangle, air);

            Console.ReadKey();
        }
    }
}
