using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int facto=0, fo=0, fi=1, result=-1;
            Console.Write("Pour quelle valeure souhaitez vous calculer la suite de fibonacci : ");
            facto = Convert.ToInt32(Console.ReadLine());

            if (facto == 0f)
            {
                result = fo;
            }
            if (facto == 1f)
            {
                result = fi;
            }

            for (int i = 1; i < facto; i++)
            {
                result = fi + fo;
                fo = fi;
                fi = result;
            }

            Console.WriteLine("");
            Console.WriteLine("Pour la valeur n : {0} \nLe resultat de F{0} vaut : {1}", facto, result);

            Console.ReadKey();
        }
    }
}
