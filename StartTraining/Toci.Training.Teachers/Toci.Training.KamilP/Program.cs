using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.KamilP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dataTable = new string[12];

            Console.WriteLine("Twoja tablica posiada " + dataTable.Length + " miejsc. Uzupełnij ją!");

            for (int i = 0; i < dataTable.Length; i++)
            {
                Console.Write("Podaj wyraz na pozycję " + (i+1) + ": ");
                dataTable[i] = Console.ReadLine();

                if (dataTable.Length == i + 1)
                {
                    Console.WriteLine("\nUzupełniłeś swoją tablicę danych!");
                }
                
            }

            Console.WriteLine("\nTwoja tablica danych prezentuje się następująco: ");

            for (int i = 0; i < dataTable.Length; i++)
            {
                Console.WriteLine("Na pozycji " + (i + 1) + " znajduje się: " + dataTable[i]);
            }

            Console.ReadKey();

        }
    }
}
