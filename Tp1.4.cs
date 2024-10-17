using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* traitement et initialisation des variables */

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            float nombreDHeures = 0;
            float nombreDeMinutes = 0;
            float nombreDeSecondes = 0;
            float conversionMinutes = 0;
            float conversionSecondes = 0;

            /* traitements - calculs etc... */

            Console.WriteLine("Saisissez le nombre d'heures");
            nombreDHeures = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Saisissez le nombre de minutes");
            nombreDeMinutes = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Saisissez le nombre de secondes");
            nombreDeSecondes = Convert.ToSingle(Console.ReadLine());

            conversionMinutes = (nombreDHeures * 60f) + nombreDeMinutes + (nombreDeSecondes / 60f);
            conversionSecondes = conversionMinutes * 60f;

            /* resultats - affichage */

            Console.Clear();
            Console.WriteLine("Nombre de secondes correspondant au nombre d'heures, de minutes et de secondes cumulées : {0}", string.Format("{0:F2}", conversionSecondes));

            Console.ReadKey();
        }
    }
}
