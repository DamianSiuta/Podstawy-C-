using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_funkcje
{//Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
    //całkowitymi.Napisz program wykorzystujący funkcję suma
    internal class Program
    {
        static int suma(int a, int b)
        {
            return a + b;



        }
        static void Main(string[] args)
        {
            Console.WriteLine("wartosc 2+5={0}", suma(2, 5));
            Console.ReadKey();



        }
    }
}

