# romanNumbers

Les chiffres romains sont représentés par sept symboles différents : I, V, X, L, C, D et M.

Symbole Valeur
I 1
V 5
X 10
L 50
C 100
D 500
M 1000
Par exemple, 2 s'écrit II en chiffres romains, soit deux 1 additionnés. Le nombre 12 s'écrit XII, c'est-à-dire simplement X + II. Le nombre 27 s'écrit XXVII, soit XX + V + II.

Les chiffres romains s'écrivent généralement de gauche à droite, du plus grand au plus petit. Cependant, le chiffre correspondant à quatre n'est pas IIII. Au lieu de cela, le chiffre quatre s'écrit IV. Comme le un précède le cinq, nous le soustrayons, ce qui donne quatre. Le même principe s'applique au chiffre neuf, qui s'écrit IX. Il y a six cas où la soustraction est utilisée :

I peut être placé avant V (5) et X (10) pour obtenir 4 et 9. 
X peut être placé devant L (50) et C (100) pour obtenir 40 et 90. 
C peut être placé devant D (500) et M (1000) pour obtenir 400 et 900.
A partir d'un chiffre romain, convertissez-le en un nombre entier.

 

Exemple 1 :

Entrée : s = « III »
Sortie : 3
Explication : III = 3.
Exemple 2 :

Entrée : s = « LVIII »
Sortie : 58
Explication : L = 50, V= 5, III = 3.
Exemple 3 :

Entrée : s = « MCMXCIV »
Sortie : 1994
Explication : M = 1000, CM = 900, XC = 90 et IV = 4.



 for (int i = romanNumber.Length - 1; i >= 0; i--) // loop into entered romanNumber
    {

        if (romanNumber[i] == 'I') // I
        {
            if (result < 3) // II, II, III
            {
                number = 1;
                result += number;
            }

            if (result == 5 || result == 10) // IV, IX
            {
                number = -1;
                result += number;

            }
            else if (result >= 3 && result <= 7 || result > 8)
            {
                Console.WriteLine("Invalid number.");
            }
        }

        if (romanNumber[i] == 'V') // V
        {
            if (result <= 3) // VI, VII, VIII
            {
                number = 5;
                result += number;
            }

            if (result > 8) // VV
            {
                Console.WriteLine("Invalid number.");
            }
        }

        if (romanNumber[i] == 'X')
        {

            if (result < 30) // XX, XX, XXX
            {
                number = 10;
                result += number;
            }

            if (result == 50 || result == 100)
            { //IV
                number = -10;
                result += number;
            }

        }
        if (romanNumber[i] == 'L')
        {
            if (result < 300)
            {
                number = 50;
                result += number;
            }

            if (result == 500 || result == 1000)
            { //IV
                number = -50;
                result += number;
            }
        }

        if (romanNumber[i] == 'C')
        {
            number = 100;
            result += number;
        }

        if (romanNumber[i] == 'D')
        {
            number = 500;
            result += number;
        }

        if (romanNumber[i] == 'M') // M = 1000
        {
            number = 1000;
            result += number;
        }

    }


    Console.WriteLine("result = " + result);