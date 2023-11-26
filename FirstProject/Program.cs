using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa factorialul unui numar n,
             * n fiind citit de la tastatura.*/

             Console.Write("Introduceti numarul:");
             int number = int.Parse(Console.ReadLine());
             int factorial = 1;
             for(int i = 1; i <= number; i++)
             {
                 factorial  *= i;
             }
             Console.Write("factorialul numarului " +  number + " este:" + factorial);
 
            //---------------------
            /*Să se scrie un program care citeşte de la tastatură un şir de n numere
            naturale 
            şi determină media aritmetică a celor pare, n fiind citit de la tastatra
*/
             Console.Write("Introduceti numarul de elemente: ");
             int numarElemente = int.Parse(Console.ReadLine());

             int sumaPare = 0;
             int numerePare = 0;

             for(int i = 0; i < numarElemente;i++ )
             {
                 Console.Write($"Introduceti numarul {i + 1}: ");
                 int numar = int.Parse(Console.ReadLine());

                 if(numar % 2 == 0)
                 {
                     sumaPare += numar;
                     numerePare++;
                 }
             }
             if(numerePare > 0)
             {
                 float mediaAritmeticaPare = (float)sumaPare / numerePare;
                 Console.WriteLine($"Media aritmetica a numerelor pare este: {mediaAritmeticaPare}");
             }
             else
             {
                 Console.Write("Nu am gasit numere pare");
             }

            //-------------------

            /*: Scrieti un program care va determina daca un numar este sau nu palindrom.*/

             Console.Write("Introduceti numaru: ");
             int numar = int.Parse(Console.ReadLine());
             int numarInversat = 0;
             int memorieAux = numar;

             while(numar !=0)
             {
                 numarInversat = numarInversat * 10 + numar % 10;
                 numar = numar / 10;
             }
             if(memorieAux == numarInversat)
             {
                 Console.Write("Sunt egale este palindrom");
             }
             else
             {
                 Console.Write("Nu este un palindrom");
            } 
            //-----------------
            /*Să se scrie un program care citeşte de la tastatură un număr natural şi verifică dacă numărul este par sau impar.

Date de intrare
Programul va citi de la tastatură un număr natural n.

Date de ieşire
Programul va afişa pe ecran mesajul n este par, dacă numărul citit n este par, respectiv mesajul n este impar în caz contrar, ca în exemplu.

Restricţii şi precizări
0 < n < 1.000.000.000
Exemplu:
Intrare

2012
Ieşire

2012 este par*/


             Console.Write("Introduceti numarul: ");
             int numar = int.Parse(Console.ReadLine());

             if(numar % 2 == 0)
             {
                 Console.Write(numar + " este par");

             }
             else
             {
                 Console.Write(numar + " este impar");
             }

            //-------------

            
/*Să se scrie un program care determină maximul a două numere întregi citite de la tastatură.

Date de intrare
Programul va citi de la tastatură două numere întregi.

Date de ieşire
Programul va afişa pe ecran cel mai mare dintre cele două numere citite.

Restricţii şi precizări
valorile absolute ale numerelor citite vor fi mai mici decât 2.000.000.000
Exemplu:
Intrare

125 68
Ieşire

125*/

            Console.Write("Introdu primul numar :");
            int numar1 = int.Parse(Console.ReadLine());
            Console.Write("Introdu al doilea numar :");
            int numar2 = int.Parse(Console.ReadLine());

            if(numar1 > numar2)
            {
                Console.Write(numar1);
            }
            else
            {
                Console.Write(numar2);
            }

            //-------------

            /*Scrieți un program care determină câte sticle de x litri cu apă trebuie deschise pentru a umple un vas de y litri.

Date de intrare
Programul citește de la tastatură numerele naturale x și y.

Date de ieșire
Programul va afișa pe ecran numărul n, reprezentând numărul de sticle ce trebuie deschise.

Restricții și precizări
1 ≤ x,y ≤ 1.000.000 și sunt numere naturale
Exemplu:
Intrare

5   8
*/

            Console.Write("Introduceti x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduceti y: ");
            int y = int.Parse(Console.ReadLine());

            int numarSticle;
            numarSticle = y / x;

          
            Console.Write(numarSticle + " sticle");

            //-------------

            /*Gigel are S lei. O ciocolata costă c lei, iar o napolitană costă n lei. Gigel poate să cumpere fie ciocolate, 
             * fie napolitane,* cu condiția să cheltuiască întreaga sumă.
             * Scrieți un program care să citească numerele S c n și să afișeze pe ecran:

      textul CN dacă Gigel poate alege să cumpere ciocolate sau napolitane;
      textul C dacă Gigel poate să cumpere numai ciocolate;
      textul N dacă Gigel poate să cumpere numai napolitane;
      textul nimic dacă Gigel nu poate să cumpere nici ciocolate, nici napolitane.
      Date de intrare
      Programul citește de la tastatură numerele naturale S C N.

      Date de ieșire
      Programul afișează pe ecran textul precizat în enunț.

      Restricții și precizări
      1 ≤ S , c , n ≤ 1.000.000.000
      Exemplu:
      Intrare

      15 4 3
      Ieșire

      N
      Explicație
      Gigel are 15 lei, o ciocolată costă 4 lei, iar o napolitană costă 3 lei. Poate cumpăra 5 napolitane, dar nu poate cumpăra ciocolate, deoarece nu ar cheltui întreaga sumă.
      */

            Console.Write("Introduceti s: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pretul ciocolatii: ");
            int ciocolata = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pretu napolitanei: ");
            int napolitana = int.Parse(Console.ReadLine());

            if (s % ciocolata == 0 && s % napolitana != 0)
            {
                Console.Write("C");
            }
            else if (s % napolitana == 0 && s % ciocolata != 0)
            {
                Console.Write("N");

            }else if ( s % ciocolata == 0 &&  s % napolitana == 0)
            {
                Console.Write("CN");
            }
            else
            {
                Console.Write("Nimic");
            }
            //------------

            /*Un melc se deplasează cu viteza de v km/h. El trebuie să parcurgă distanța de d metri. 
             * Să se determine în câte minute va parcurge melcul această distanță.

Date de intrare
Programul citește de la tastatură numărul real v și numarul natural d, separate prin spații.

Date de ieșire
Programul va afișa pe ecran numărul întreg t, reprezentând timpul exprimat în minute în care melcul va parcurge distanța d.

Restricții și precizări
v este număr real;
0 < d < 1.000.000.000
Exemplu:
Intrare

0.3 20
Ieșire

4
Explicație
Timpul necesar este de t=4 minute.*/
            Console.Write("Introduceti viteza: ");
            float viteza = float.Parse(Console.ReadLine());
            Console.Write("Introduceti metri: ");
            int distanta = int.Parse(Console.ReadLine());
            int timp;

            viteza = viteza * 1000 / 60;
            timp = (int)( distanta / viteza);
         
            Console.Write(timp + " minute");
        }
    }
}
