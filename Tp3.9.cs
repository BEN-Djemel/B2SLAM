using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entrez un nombre :");
            int valeurSaisie = 0;
            bool resultat = int.TryParse(Console.ReadLine(), out valeurSaisie);
            if (resultat == true)
            {
                int sommeDesEntiers = 0;
                for (int i = 1; i < valeurSaisie; i++) //J'ai remplacé <= par <, cela fonctionne.
                {
                    sommeDesEntiers += i;
                }
                Console.WriteLine("La somme des entiers de 1 jusqu'à {0} est : {1}", valeurSaisie - 1, sommeDesEntiers);
            }

            Console.ReadKey();
        }
    }
}
