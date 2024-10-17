# B2SLAM

Vous trouverez sur ce repertoire mes fichiers c# correspondant aux tp 1,2 et 3.

Vous pouvez télecharger les fichiers sur vos telephones ou ordinateur : 

## Installation sur un terminal shell

#### lancez les commandes : 
```
1. sudo apt update && sudo apt install git
2. git clone https://github.com/BEN-Djemel/B2SLAM.git
```

## Installation sur ish shell (IOS)

#### lancez les commandes :
```
1. apk update && apk add git
2. git clone https://github.com/BEN-Djemel/B2SLAM.git
```

## Installation sur termux (ANDROID)

#### lancez les commandes : 
```
1. apt update && apt install git
2. git clone https://github.com/BEN-Djemel/B2SLAM.git
```

# ENONCÉS
### TP1
 ```
## 1.1 :
Ecrivez un programme qui calcule la moyenne de 3 nombres saisis.
## 1.2 :
Ecrire un programme qui permet la saisie d’un prix unitaire, d’une quantité et d’un taux de TVA. A l’issu de la saisie, le programme affiche le montant TTC à payer.
## 1.3 :
Ecrivez un programme qui calcule le prix d’une commande pour une société. Les règles de gestion vous sont présentées ci-après
## 1.4 :
Ecrivez un programme qui transforme une durée exprimée en heures, minutes et secondes en une durée exprimée uniquement en secondes. Les heures, minutes et secondes doivent être saisies par l’utilisateur.
```

### TP2
 ```
## 2.1 :
Une entreprise verse une prime d’objectif à ses commerciaux qui est fonction du montant du chiffre d’affaire qu’ils ont atteint sur l’année.
Cette prime est de 4% du CA lorsque celui-ci est supérieur à 10K€.

Ecrire le programme qui comme dans l’exemple ci-dessous calcul et affiche le montant de la prime d’objectif pour un chiffre d’affaire saisi par l’utilisateur.
## 2.2 :
Reprenez le programme précédent. La prime de 4% est maintenant calculée sur la part du CA qui est supérieur à 10000€.
Ecrire le programme qui comme dans l’exemple ci-dessous calcul et affiche le montant de la prime d’objectif pour un chiffre d’affaire saisi par l’utilisateur.
## 2.3 :
Ecrire un programme qui qui comme dans l’exemple ci-dessous affiche le plus petit de deux nombres réels saisis au clavier par l'utilisateur
## 2.4 :
Ecrire un programme qui respecte le cahier des charges présenté ci-après :
Une entreprise souhaite pouvoir appliquer un tarif dégressif pour ses articles en fonction de la quantité achetée.

Ecrire l'algorithme permettant d'afficher le montant total d'une facture lors de l'achat d'une quantité d'article: 

- si la quantité n'excède pas 10, l'article coûte 150 €
- si la quantité est supérieur à 10 mais n’excède pas 49, l'article coûte 135 € 
- si la quantité dépasse 49, l'article coûte 110 €

On fera saisir la quantité désirée à l'utilisateur du programme. On considère que la quantité saisie est valide.
## 2.5 :
Ecrire un programme qui affiche le plus petit de trois nombres réels saisis au clavier par l'utilisateur.
## 2.6 :
Ecrire le programme qui réponde au cahier des charges ci-après.
Un libraire propose les livres de poche à (3), (5) ou (6,5) Euros.
Chaque livre est caractérisé par un nombre d’étoiles, 1, 2 ou 3 proportionnel aux nombres de pages et qui est utilisé pour déterminer le prix d’un livre. Un livre à une étoile est vendu 3 euros, ceux à deux étoiles 5 euros, et enfin, 6,5 euros pour un livre à trois étoiles.
La libraire accorde 10 % de réduction pour tout achat groupé à partir de 20 exemplaires du même ouvrage. 
La vente s’effectue en magasin ou par correspondance. Dans le second cas, le prix est majoré de 2 % pour intégrer les frais de port, si l'achat par correspondance n'atteint pas 25 Euros (montant avant réduction).
Le programme se restreint volontairement au traitement de la vente d'un seul livre pour l'instant, seul le nombre d'exemplaire varie. 
Le libraire saisit (ou sélectionne) :
    • le nombre d'exemplaire (nbex) ; 
    • le nombre d'étoiles (nbetoile) ;  
    • le type de vente (type_vente) : "M" pour la vente au magasin 
				et "C" pour la vente par correspondance.
Il veut obtenir :
		
    • le montant de l'achat (achat) ;
    • le montant de la réduction (réduction) ; 
    • le montant des frais de port (port) ;
    • le prix à payer (prix). 

Le détail du calcul sera affiché même si certaines valeurs sont nulles.
## 2.7 :
Ecrire le programme qui réponde au cahier des charges ci-après.
Ecrire le programme qui calcule le salaire hebdomadaire (par semaine) d’un employé. Un employé est payé sur une base de 35 heures. Les heures supplémentaires, à partir de la 36ème heure, sont payées à 150% du tarif horaire. L’utilisateur du programme saisit le salaire horaire et le nombre d’heures effectuées.
## 2.8 :
Copiez et exécutez le programme ci-après en utilisant la valeur 10 en premier nombre et 0 pour le second nombre.

Expliquez le message d’erreur qui s’affiche ?

Proposez une correction pour éviter ce cas de figure

Console.WriteLine("Entrez le premier nombre :");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez le deuxième nombre :");
int num2 = int.Parse(Console.ReadLine());

int result = num1 / num2;
Console.WriteLine("Le résultat de la division est : " + result);
## 2.9 :
La société « Composite » est spécialisée dans la fabrication et la vente de micro-processeurs. Elle accorde des remises lorsque les quantités commandées sont importantes. Certains clients bénéficient de remise supplémentaire.

La réduction consentie est de 10 % si le nombre de composants commandés est compris entre 10 000 et 20 000, 15 % si ce nombre est compris entre 20 001 et 40 000 et 20 % pour plus de 40 000 composants.

De plus, le client « DeepInside », bénéficie d’une réduction supplémentaire de 2 %. « JBC » bénéficie, quant à lui, d’une réduction majorée de 1 %.

Ecrire un programme qui affiche le taux de la réduction consentie à un client donné pour une quantité commandée saisie.
 ```
### TP3
 ```
## 3.1 :
Ecrire un programme qui permet, comme dans l’exemple d’exécution ci-dessous, la saisie d’une valeur et affiche le nombre d’étoiles correspondant.
## 3.2 :
Ecrire un programme qui permet, comme dans l’exemple d’exécution ci-dessous, la saisie d’une valeur et affiche le nombre d’étoiles correspondant. Un retour à la ligne sera effectué toutes les 5 étoiles
## 3.3 :
Ecrire un programme qui permet, comme dans l’exemple d’exécution ci-dessous,  la saisie d’une valeur et affiche un nombre de caractère équivalent. Un retour à la ligne sera effectué toutes les 5 caractères. Deux caractères seront affichés alternativement : l’étoile et le dollar.
## 3.4 :
Copier, coller puis exécuter le programme ci-dessous dans la console. Répondez aux questions ci-après
for (ushort i = 0; i < 65536; i++)
{
if (i == 0)
{
    Console.WriteLine("la variable i est égale à 0...Appuyer sur une touche pour continuer");
    Console.ReadKey();
}
Console.WriteLine(i);
}

Quelle est la taille d’une variable de type « ushort » ? 
Quelle est la plage de valeurs possibles pour la variable « i » ?
Que se passe-t-il quand la valeur maximale possible de la variable (plage de valeur possible) est atteinte ?

## 3.5 :
Copier, coller puis exécuter le programme ci-dessous dans la console. Répondez aux questions ci-après
for (int i = 65; i < 91; i++)
{
 	char c = Convert.ToChar(i);
Console.WriteLine(c);
}
Quelle est la plage et le nombre de valeurs possibles pour la variable « i » ?
En vous appuyant sur le tableau présenté ici, expliquez ce résultat
## 3.6 :
Ecrire un programme qui comme dans l’exemple ci-dessous, dessine un carré d’étoiles. L’utilisateur saisit le nombre d’étoiles d’un côté. Le carré est plein.
## 3.7 :
Ecrire un programme qui comme dans l’exemple ci-dessous, dessine un carré d’étoiles. L’utilisateur saisit le nombre d’étoiles d’un côté. Seuls les côtés sont représentés.
## 3.8 :
Ecrire un programme qui permet la saisie d’une valeur et retourne la factorielle correspondante. (ex : Fact(5) = 5*4*3*2*1 = 120.)
## 3.88 :
La suite de « Fibonacci 1» où  Fn = Fn-1 +  Fn-2. Ecrire un programme qui permet la saisie d’une valeur (n)  et affiche Fn. 
F0 = 0
F1=1
F2=1 (car F2 = F1+F0)
F3=2 (car F3 = F2+F1)
F4=3 ; F5=5 ; F6=8 etc.

On remarquera les éléments suivants :
    • Cette suite dispose d’un état initial : f(0) = 0 et f(1) = 1.
    • Le calcul de chaque terme de la suite s’effectue à l’aide d’une structure itérative.
    • Chaque terme de la suite (un f), il est nécessaire de connaitre les deux termes précédents.
## 3.9 :
Copiez et exécutez le programme ci-après en utilisant la valeur 5

Le programme devrait afficher la somme des entiers de 1 à 4. Ce qui n’est pas le cas.

Proposez une correction !

Console.WriteLine("Entrez un nombre :");
int valeurSaisie = 0;
bool resultat = int.TryParse(Console.ReadLine(),out valeurSaisie);
if (resultat == true)
{
int sommeDesEntiers = 0;
for (int i = 1; i <= valeurSaisie; i++)
{
sommeDesEntiers += i;
}
Console.WriteLine("La somme des entiers de 1 jusqu'à {0} est : {1}", valeurSaisie - 1, sommeDesEntiers);
}
 ```
