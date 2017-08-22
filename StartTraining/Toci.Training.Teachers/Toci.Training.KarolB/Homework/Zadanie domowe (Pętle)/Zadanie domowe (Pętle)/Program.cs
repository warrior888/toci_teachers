using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe__Pętle_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fish = new string[10];
            for (int i = 0; i < fish.Length; i++)
            {

                Console.WriteLine("Wpisz nazwe ryby {0} ", i);
                fish[i] = Console.ReadLine();

                if (i == fish.Length - 1)

                {
                    Console.WriteLine("Dziekuje za uzupełnienie tabeli");
                }


            }
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.WriteLine("Tablica Ryb");

            for (int i = 0; i < fish.Length; i++)
            {
                Console.WriteLine("" + (i + 1) + "." + fish[i]);
            }
            Console.ReadKey();
        }
    }
}
