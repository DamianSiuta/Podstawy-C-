using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_funkcje
{//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
 // powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
 //             utworzonej funkcji.

    internal class Program
        
    {
        static int liczba_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba; i++)
                if (liczba % i == 0)
                    return 0;
            return 1;

               
        }



        static void Main(string[] args)
        {
            Console.WriteLine($"czy 12 jest liczba 1. {liczba_pierwsza(12)}");
            Console.WriteLine($"czy 13 jest liczba 1. {liczba_pierwsza(13)}");
            Console.ReadKey();

        }
    }
}
