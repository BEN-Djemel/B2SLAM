using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Une entreprise verse une prime d’objectif à ses commerciaux qui est fonction du 
              montant du chiffre d’affaire qu’ils ont atteint sur l’année.
Cette prime est de 4% du CA lorsque celui-ci est supérieur à 10K€.
Ecrire le programme qui comme dans l’exemple ci-dessous calcul et affiche le montant de 
            la prime d’objectif pour un chiffre d’affaire saisi par l’utilisateur.*/

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float chiffreAffaire = 0;
            float prime = 0;

            Console.WriteLine("Veuillez indiquer votre chiffre d'affaire");
            chiffreAffaire = Convert.ToSingle(Console.ReadLine());

            if (chiffreAffaire >= 10000f)
            {
                prime = chiffreAffaire * 0.04f;
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
