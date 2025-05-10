using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_pętle_3
{
    class Program
    {
        static void Main(string[] args)
        {       //Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy 1+2+…+n. Do obliczenia wartości sumy użyj pętli for. 
            int i, n, suma = 0;
            Console.WriteLine("Podaj liczbe n (większą od 2): ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
                suma += i;
            Console.WriteLine("suma liczb od 0 do {0} to {1}", n, suma);
            Console.ReadKey();
        }
    }
}
