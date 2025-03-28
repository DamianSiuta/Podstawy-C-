using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb
            int[] tablica = new int[1000];
            int n, i, suma = 0;
            Console.WriteLine("Podaj ilość elementow n<=1000: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("podaj tab[{0}]= ", i);
                tablica[i] = int.Parse(Console.ReadLine());
                suma += tablica[i];
            }
            {
                Console.Write("Suma elementów tablicy: ");
                Console.Write(suma);
                Console.ReadKey();
            }
        }
    }
}