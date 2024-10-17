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

            float prixUnitaire = 0;
            float quantite = 0;
            float tva = 0;
            float montantTva = 0;
            float totalHt = 0;
            float ttc = 0;

            /* traitements - calculs etc... */
            
            Console.WriteLine("veuillez saisir le prix unitaire");
            prixUnitaire = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("veuillez saisir la quantité");
            quantite = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("veuillez saisir la tva");
            montantTva = Convert.ToSingle(Console.ReadLine());

            totalHt = prixUnitaire * quantite;

            tva = (montantTva * totalHt / 100f);

            ttc = totalHt + tva;

            /* resultats - affichage */
            Console.Clear();
            Console.WriteLine("le montant net TTC à payer est de {0} euros", ttc);

            Console.ReadKey();
        }
    }
}
