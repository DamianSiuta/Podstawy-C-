using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.
            int[] tablica = new int[1000];
            int i = 0, j, liczba;
            Console.WriteLine("Podaj liczbę naturalną: ");
            liczba = int.Parse(Console.ReadLine());
            while ((liczba/2!=0 || ((liczba / 2 == 0) && (liczba % 2 != 0))))
            {
                tablica[i] = liczba % 2;
                liczba = liczba / 2;
                i++;
            }
            {
                Console.Write("Liczba w systemie dwójkowym: ");
                for (j = i - 1; j >= 0; j--)
                {
                    Console.Write(tablica[j]);
                }
                Console.ReadKey();
            }

        }
    }
}
