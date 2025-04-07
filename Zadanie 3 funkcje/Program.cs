using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_funkcje
{//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
    //obliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola.

    internal class Program
    { 
     static double pole_kola(double r)
    {
        return Math.PI* r *r;
            }
        static void Main(string[] args)
        {
        Console.WriteLine("dla r= 5.5 pole wynosi {0}", pole_kola(5.5));
        Console.ReadKey();
        }
    }
}
