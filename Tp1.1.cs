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

            string demandeUtilisateur;

            int noteUn = 0;
            int noteDeux = 0;
            int noteTrois = 0;
            int moyenne = 0;

            /* traitements - calculs etc... */


            /* resultats - affichage */
            Console.WriteLine("veuillez saisir la premiere valeure");
            noteUn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("veuillez saisir la deuxieme valeure");
            noteDeux = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("veuillez saisir la troisième valeure");
            noteTrois = Convert.ToInt32(Console.ReadLine());

            moyenne = (noteUn + noteDeux + noteTrois) / 3;

            Console.Clear();
            Console.Write("la moyenne est de ");
            Console.WriteLine(moyenne);


            Console.ReadKey();
        }
    }
}
