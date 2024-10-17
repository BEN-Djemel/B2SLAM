using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._9
{
    class Program
    {
        static void Main(string[] args)
        {

            // remises lorsque les quantités commandées sont importantes.Certains clients bénéficient de remise supplémentaire.

            // If nbcomposant > 10 000 && nbcomposant <= 20 000 alors prix - 10%,
            // if nbcomposant > 20 0001 && nbcomposant < 40 000 alors prix -15 %,
            // if nbcomposant > 40 000 alors prix - 20%,

            // if client = "DeepInside" alors prix -2%
            // if client = "JBC" alors prix +1 %.

            // affiche le taux de la réduction consentie pour le client donné pour une quantité commandée saisie.

            float quantite = 0, prixttc = 0, prixht = 0, montantreduc = 0, tauxReduc = 0, prixUnit = 0;
            string client;

            Console.WriteLine("Veuillez saisir votre nom :");
            client = Console.ReadLine();

            Console.WriteLine("Veuillez saisir le nombre de composants souhaités :");
            quantite = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le prix d'un seul composant souhaité :");
            prixUnit = Convert.ToSingle(Console.ReadLine());


            prixht = quantite * prixUnit;


            if (quantite > 10000f && quantite <= 20000f)
            {
                montantreduc = prixht * 0.9f;
                tauxReduc = (prixht * 0.1f); //- ((prixht * 0.1f) * 2f);
            }
            else if (quantite > 20001 && quantite <= 40000)
            {
                montantreduc = prixht * 0.85f;
                tauxReduc = (prixht * 0.15f) - ((prixht * 0.15f) * 2f);
            }
            else if (quantite > 40001)
            {
                montantreduc = prixht * 0.80f;
                tauxReduc = (prixht * 0.20f) - ((prixht * 0.20f) * 2f);
            }

            if (client == "DeepInside")
            {
                tauxReduc = tauxReduc - 2;
            }
            else if (client == "JBC")
            {
                tauxReduc = tauxReduc + 1;
            }

            Console.WriteLine(montantreduc);
            Console.WriteLine(tauxReduc-2);

            Console.ReadKey();

        }
    }
}
