using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dodatkowe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i
            //wypisujący na ekranie jego wartość.
            double n;
            Console.WriteLine("Wzór ciągu arytmetycznego to a(n)= 3n-1. Podaj numer wyrazu ciągu: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Wartość wyrazu tego ciągu to: {0}",  (3 * n - 1));
            Console.ReadKey();


        }
    }
}
