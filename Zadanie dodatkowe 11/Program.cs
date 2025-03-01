using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dodatkowe_11
{
    class Program
    {
        static void Main(string[] args)
        {
             //Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego
             //objętość i pole całkowite
             Double a, b, c;
            Console.WriteLine(value: "Podaj długość boku a:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(value: "Podaj długość boku b:");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(value: "Podaj długość boku c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Objętość prostopadłościanu wynosi: {0}", a * b * c);
            Console.WriteLine("Pole całkowite prostopadłościanu wynosi: {0}", 2 * a * b + 2 * a * c + 2 * b * c);
            Console.ReadKey();
        }
    }
}
