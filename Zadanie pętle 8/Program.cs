using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_pętle_8
{
    class Program
    {
        static void Main(string[] args)
        { //Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata przestępne od roku_początkowego do roku_końcowego włącznie.
            //Użyj pętli for. 
            int rok_początkowy, rok_końcowy;
            Console.WriteLine("Podaj rok początkowy: ");
            rok_początkowy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rok końcowy: ");
            rok_końcowy = Convert.ToInt32(Console.ReadLine());
            for (int i = rok_początkowy; i <= rok_końcowy; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
    }
}
