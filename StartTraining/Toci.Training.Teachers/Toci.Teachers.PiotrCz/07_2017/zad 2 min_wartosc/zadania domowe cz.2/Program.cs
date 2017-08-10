using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania_domowe_cz._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] concept = new int[] {3, 15, 28, 6, 81, 4, 123, 15, 444, 2, 1, 5};

            int minimalnawartosc = int.MaxValue;

            for (int i = 0; i < concept.Length; i++)
               //  for (int i = concept.Length -1; i >= 0; i--) petla puszczona od tylu lae wynik jest taki sam
               // zauwaz , ze gdy robisz petle od konca to zamieniaja sie miejscami 0 oraz concept.Length 

                if (minimalnawartosc>concept[i])
            {
                minimalnawartosc = concept[i];
            }

           // int finish1 = minimalnawartosc;
               Console.WriteLine("najmniejsza wartosc to : " + minimalnawartosc);
           
            Console.ReadLine();
        }
    }
}
