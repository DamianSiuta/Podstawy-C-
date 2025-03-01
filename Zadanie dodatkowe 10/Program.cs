using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dodatkowe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.
            double r;
            Console.WriteLine("Podaj wartość promienia koła dla którego chciałbyś obliczć pole i obwód: ");
            r= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole tego koła wynosi {0}, natomiast obwód wynosi {1}.", Math.PI*(r*r), 2*Math.PI*r);
            Console.ReadKey();
        }
    }
}
