using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            float nbEtoile = 0, verif = 0, verif2=0;
            char chara='$';

            /* if nombre alors tant que nombre est pas = 0 et nombre % 0 != 0 
              alors dessiner * et nombre = nombre -1   */

            Console.WriteLine("Saisir le nbre d'étoiles à afficher :");
            nbEtoile = Convert.ToSingle(Console.ReadLine());

            for (int i = 0; i < nbEtoile; i++)
            {
                verif = i % 5f;
                if (verif == 0f)
                {
                    if (chara == '$') { chara = '*'; }
                    else { chara = '$'; }
                    Console.Write("\n");
                    Console.Write(chara);
                }
                else
                {
                    Console.Write(chara);
                }
            }
            Console.ReadKey();
        }
    }
}
