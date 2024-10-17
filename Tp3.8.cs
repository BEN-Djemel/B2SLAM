using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int facto = 0, result = 1;
            Console.Write("Pour quelle valeure souhaitez vous calculer la factorielle : ");
            facto = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= facto; i++)
            {
                result *= i;
            }

            Console.WriteLine("");
            Console.WriteLine("Factorielle de {0} : {1}", facto, result);

            Console.ReadKey();
        }
    }
}
