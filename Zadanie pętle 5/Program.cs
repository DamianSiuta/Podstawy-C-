using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_pętle_5
{
    class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny.
         //Użyj pętli for. Przykładowo dla n=3 narysowany trójkąt powinien wyglądać: 
            int n, j, k;
            Console.WriteLine("Podaj liczbe naturaną n: ");

            n = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= n; j++)
            {
                for (k = 1; k <= j; k++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    }
}
