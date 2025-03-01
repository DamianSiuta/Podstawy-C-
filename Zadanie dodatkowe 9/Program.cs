using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dodatkowe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów
            //wczytanych liczb.
            Int32 a, b;
            Console.WriteLine("Podaj pierwszą liczbę całkowitą a= ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę całkowitą b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma kwadratów tych liczb wynosi: {0}", (a*a)+(b*b));
            Console.ReadKey();
        }
    }
}
