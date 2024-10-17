using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Une entreprise souhaite pouvoir appliquer un tarif dégressif pour ses articles en fonction de la quantité achetée.
            Ecrire l'algorithme permettant d'afficher le montant total d'une facture lors de l'achat d'une quantité d'article: 

            - si la quantité n'excède pas 10, l'article coûte 150 €
            - si la quantité est supérieur à 10 mais n’excède pas 49, l'article coûte 135 € 
            - si la quantité dépasse 49, l'article coûte 110 €

            On fera saisir la quantité désirée à l'utilisateur du programme. On considère que la quantité saisie est valide. */
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float quantite = 0;

            Console.WriteLine("Veuillez saisir une quantité");
            quantite = Convert.ToSingle(Console.ReadLine());

            if (quantite < 10f)
            {
                quantite = quantite * 150f;
                Console.WriteLine("le montant de la facture s'élève à {0} euros", quantite);
            }
            else if (quantite > 10f && quantite < 49)
            {
                quantite = quantite * 135f;
                Console.WriteLine("le montant de la facture s'élève à {0} euros", quantite);
            }
            else
            {
                quantite = quantite * 110f;
                Console.WriteLine("le montant de la facture s'élève à {0} euros", quantite);
            }

            Console.ReadKey();
        }
    }
}
