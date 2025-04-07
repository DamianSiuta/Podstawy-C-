using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_funkcje
{//Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
    //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.

    internal class Program
    { static double max(double x, double y)
            {if (x>y) return x;
            else return y;
            }

        static void Main(string[] args)
        {
        Console.WriteLine("max z 3 i 8 to {0}", max (3,8));
        Console.WriteLine("max z 3 i 2 to {0}", max(3, 2));
        Console.WriteLine("max z 5 i 12 to {0}", max(5, 12));
        Console.ReadKey();
    }
    }
}
