using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le premier nombre :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre :");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Le résultat de la division est : " + result);

            // Le message d'erreur affiché est qu'il ne souhaite pas diviser par 0. 
            // Pour eviter ça, on devrai utiliser des floats car float c est des nombres reels alors que int c est des entiers


            /*
            float nb1 = 0;
            float nb2 = 0;
            float result = 0;

            Console.WriteLine("Veuillez saisir le nombre d'heures");
            nb1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre d'heures");
            nb2 = Convert.ToSingle(Console.ReadLine());

            result = nb1 / nb2;

            Console.WriteLine("Votre salaire cette semaine est de {0} euros", result);
            */
            Console.ReadKey();
            
        }
    }
}
