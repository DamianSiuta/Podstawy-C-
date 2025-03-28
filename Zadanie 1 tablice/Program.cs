using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i
            //wypisujący wczytane liczby na ekranie
            int[] tablica = new int[1000];
            int n, i;
            Console.WriteLine("Podaj ilość elementow n<=1000: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("podaj tab[{0}]= ", i);
                tablica[i] = int.Parse(Console.ReadLine());
            }
           
            {
                Console.Write("elementy tablicy: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(tablica[i] + " ");
                }
                Console.ReadKey();

            }
        }
    }
}
