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
            float quantiteCommande = 0;
            float montantCommande = 0;
            float remise5Pourcent = 0;
            float fraisDePort = 0;
            float ttc;

            /* traitements - calculs etc... */


            /* resultats - affichage */
            Console.WriteLine("veuillez saisir le prix unitaire");
            prixUnitaire = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("veuillez saisir la quantité");
            quantiteCommande = Convert.ToSingle(Console.ReadLine());

            Console.Clear();
            montantCommande = quantiteCommande * prixUnitaire;
            Console.WriteLine("le montant de la commande s'élève à {0} ", string.Format("{0:F2}", montantCommande));

            remise5Pourcent = montantCommande * 5f / 100f;
            Console.WriteLine("le montant de la remise s'élève à {0} ", string.Format("{0:F2}", remise5Pourcent));

            fraisDePort = montantCommande * 2f / 100f;
            Console.WriteLine("le montant des frais de port s'élève à {0} ", string.Format("{0:F2}", fraisDePort));

            ttc = fraisDePort + montantCommande - remise5Pourcent;
            Console.WriteLine("le montant net TTC à payer est de {0} euros", string.Format("{0:F2}", ttc));

            Console.ReadKey();
        }
    }
}
