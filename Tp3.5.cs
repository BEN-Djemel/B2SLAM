using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q1 : Le nombre total de valeurs possibles pour une variable de type int est donc de 2^32, soit 4 294 967 296 valeurs, incluant les valeurs négatives, zéro et les valeurs positives
            //Q2 : Cela ecrit le caractère en ascii correspondant à notre valeur ex : la valeure decimal 65 correspond à un "A" en ASCII.
            for (int i = 65; i < 91; i++)
            {
                char c = Convert.ToChar(i);
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
