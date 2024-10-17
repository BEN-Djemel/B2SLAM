using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* livres 3€ = 1*, 5€ = 2* ou 6,5€ = 3* 
                -10%(nbr * 0.1) pour tout achat > 20 du même livre 
            if achat par correspondance, && prix < 25€ alors prix = +2% (nbr * 1.02)
            */

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            float prixLivres = 0;
            float nbex = 0;
            float nbetoile = 0;
            string typeVente;

            float Ht = 0;
            float montantReduc = 0;
            float fdp = 0;
            float prixTtc = 0;

            Console.WriteLine("Veuillez saisir le nombre d'exemplaire");
            nbex = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre d'étoile");
            nbetoile = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le type de vente (M/C)");
            typeVente = Console.ReadLine();

            if (nbetoile == 1f)
            {
                prixLivres = 3f;
                Ht = prixLivres * nbex;
                if (nbex > 20f) 
                { montantReduc = Ht * 0.9f; }
                if (typeVente == "C" && prixLivres < 25f) 
                { fdp = Ht * 0.02f; }
                prixTtc = Ht + montantReduc + fdp;
                Console.WriteLine("le montant ht est de {0} euros, la réduction est de {1} euros, les frais de port {2} et le prix ttc : {3} euros", Ht, montantReduc, fdp, prixTtc);
            }
            else if (nbetoile == 2f)
            {
                prixLivres = 5f;
                Ht = prixLivres * nbex;
                if (nbex > 20f) { montantReduc = Ht * 0.9f; }
                if (typeVente == "C" && prixLivres < 25f) { fdp = Ht * 0.02f; }
                prixTtc = Ht + montantReduc + fdp;
                Console.WriteLine("le montant ht est de {0} euros, la réduction est de {1} euros, les frais de port {2} et le prix ttc : {3} euros", Ht, montantReduc, fdp, prixTtc);
            }
            else if (nbetoile == 3f)
            {
                prixLivres = 6.5f;
                Ht = prixLivres * nbex;
                if (nbex > 20f) { montantReduc = Ht * 0.9f; }
                if (typeVente == "C" && prixLivres < 25f) { fdp = Ht * 0.02f; }
                prixTtc = Ht + montantReduc + fdp;
                Console.WriteLine("le montant ht est de {0} euros, la réduction est de {1} euros, les frais de port {2} et le prix ttc : {3} euros", Ht, montantReduc, fdp, prixTtc);
            }

            Console.ReadKey();
        }
    }
}
