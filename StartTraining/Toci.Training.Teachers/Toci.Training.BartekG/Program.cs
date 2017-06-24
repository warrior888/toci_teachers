using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.BartekG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] table = new string[10];
            int na = table.Length - 1;
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine("Wpisz coś do indexu " + i + " na " + na);
                table[i] = Console.ReadLine();

                if (i==table.Length-1)
                {
                    Console.WriteLine("Uzupełniłeś całą tablicę :)");
                }
            }
            Console.WriteLine("Oto twoja tablica: ");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine("dla ["+i+"] = "+table[i]);




            }
            Console.ReadLine();

        }






    }
}
