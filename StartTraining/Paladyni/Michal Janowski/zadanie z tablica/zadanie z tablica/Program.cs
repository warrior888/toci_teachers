using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_z_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program wypelniajacy tablice podanym tekstem.");

            string[] text = new string[5];

            int tablica = text.Length;

            for (int i = 0; i < tablica; i++)
            {
                Console.WriteLine();
                System.Console.WriteLine("Podaj tekst: ");
                string tekscik;
                tekscik = Console.ReadLine();
                text[i] = tekscik;
            }

            Console.WriteLine();
            System.Console.WriteLine("Wpisane teksty to:");
            Console.WriteLine();

            for (int j = 0; j < tablica; j++)
            {
                Console.WriteLine(j+1 + ". " + text[j]);
                Console.WriteLine();
            }
                System.Console.ReadKey();
        }
    }
}
