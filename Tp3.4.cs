using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1 : 16 bits soit 65535 valeurs possible
            //Q2 : 0 à 63535
            //Q3 : La boucle se termine et i est reinitialiser à 0
            for (ushort i = 0; i < 65536; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("la variable i est égale à 0...Appuyer sur une touche pour continuer");
                    Console.ReadKey();
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
