using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pamiec = new string[5];

            for (int i = 0; i < pamiec.Length; i++)
            {
                Console.WriteLine("Podaj " + i + " informację: ");
                pamiec[i] = Console.ReadLine();
            }
            Console.WriteLine("Dziękujemy, to już wszystkie dane których potrzebowaliśmy!");
            Console.ReadKey();
        }
    }
}
