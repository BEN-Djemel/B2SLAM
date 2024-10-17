using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Td1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            float interet = 0;
            float capital = 0;
            float taux = 0;
            float dureeMois = 0;

            Console.WriteLine("Saisissez le taux annuel d'interêts");
            taux = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Saisissez le capital placé");
            capital = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Saisissez la durée en mois");
            dureeMois = Convert.ToSingle(Console.ReadLine());

            interet = capital * taux * dureeMois / 12f;

            Console.Clear();
            Console.WriteLine("Le taux d'interets pour un taux annuel à {0} %, le capital placé à hauteur de {1}, et une durée de {2} mois s'élève à {3} euros.", taux, capital, dureeMois, string.Format("{0:F2}", interet));

            Console.ReadKey();

        }
    }
}
