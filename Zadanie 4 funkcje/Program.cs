using System;

namespace Zadanie_4_funkcje
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            
            if (liczba == 0)
            {
                return 1;
            }

            int i = 0;
            while (liczba != 0)
            {
                liczba /= 10;
                i++;
            }
            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Liczba zero ma {0} cyfr", ile_cyfr(0));
            Console.WriteLine("Liczba 12345 ma {0} cyfr", ile_cyfr(12345));
            Console.WriteLine("Liczba -9876 ma {0} cyfr", ile_cyfr(-9876));
            Console.ReadKey();
        }
    }
}