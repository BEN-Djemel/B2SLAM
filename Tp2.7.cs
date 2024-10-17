using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if > 36h, salaire = (heures - 35) + 150% (*2.5) */

            float nbHeures = 0;
            float salaireHoraire = 0;
            float heuresSupp = 0;
            float salaireHeuresSupp = 0;
            float salaire = 0;

            Console.WriteLine("Veuillez saisir le nombre d'heures");
            nbHeures = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le salaire horaire");
            salaireHoraire = Convert.ToSingle(Console.ReadLine());

            if (nbHeures > 35f)
            {
                heuresSupp = nbHeures - 35f;
                salaireHeuresSupp = heuresSupp * 2.5f * salaireHoraire;
                salaire = (((nbHeures - heuresSupp) * salaireHoraire) + salaireHeuresSupp);
            }
            else
            {
                salaire = nbHeures * salaireHoraire;
            }

            Console.WriteLine("Votre salaire cette semaine est de {0} euros", salaire);

            Console.ReadKey();
        }
    }
}
