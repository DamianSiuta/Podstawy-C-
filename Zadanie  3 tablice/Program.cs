using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie__3_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.
            int[] tablica = new int[1000];
            int n, i, j, temp;
            Console.WriteLine("podaj ilość elementow tablicy: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("podaj tab[{0}]= ", i);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
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
