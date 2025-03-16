using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_pętle_4
{
    class Program
    {
        static void Main(string[] args)
        {//Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt posiadający n wierszy i k kolumn. Użyj pętli for. 
            int i, j, k, n;
            Console.WriteLine("podaj liczbe n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę k: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
