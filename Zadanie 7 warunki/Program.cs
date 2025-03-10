using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zadanie_7_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
         //  odpowiednik rzymski.
            Int32 a;
            Console.WriteLine(" podaj liczbę od 1-3999: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 3000) { a -= 3000; Console.WriteLine("MMM "); }
            else if (a >= 2000) { a -= 2000; Console.WriteLine("MM "); }
            else if (a >= 1000) { a -= 1000; Console.WriteLine("M "); }
            // setki
            if (a >= 900) { a -= 900; Console.WriteLine("CM"); }
            else if (a >= 800) { a -= 800; Console.WriteLine("DCCC"); }
            else if (a >= 700) { a -= 700; Console.WriteLine("DCC"); }
            else if (a >= 600) { a -= 600; Console.WriteLine("DC"); }
            else if(a >=500) { a -= 500; Console.WriteLine("D");  }
            else if (a>= 400) { a -= 400; Console.WriteLine("CD"); }
            else if (a>= 300) { a -= 300; Console.WriteLine("CCC"); }
            else if (a>=200) 
        
                

        }
    }
}
