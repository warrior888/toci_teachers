using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.DamianB
{
    class Program
    {
        static void Main(string[] args)
        {

            String NumberOfEntries;
            Console.WriteLine("Ile wpisów?");
            NumberOfEntries = Console.ReadLine();
            String[] DataTable = new String[int.Parse(NumberOfEntries)];
            for (int i = 0; i < int.Parse(NumberOfEntries); i++)
            {
                Console.WriteLine("Podaj wpis: ");
                DataTable[i] = Console.ReadLine();
                //poniżej sprawdzałem czy sie uzupełnia tablica i co zostało wpisane
                // Console.WriteLine("Wpisano " + DataTable[i]);

            }
            Console.WriteLine("Osiągnięto maksymalną ilość wpisów: {0}", NumberOfEntries);
            Console.WriteLine("wciśnij enter...");
            Console.ReadLine();

        }
    }
}
