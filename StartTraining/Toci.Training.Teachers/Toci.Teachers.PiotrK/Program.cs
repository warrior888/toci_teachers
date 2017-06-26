using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wypelniajacy tablice podanym tekstem.");

            string[] text = new string[5];

            int lengthOfTextArray = text.Length;

            Console.WriteLine("Podaj słowo: ");

            for (int i = 0; i < lengthOfTextArray; i++)
            {
                Console.Write(i + 1 + ": ");
                text[i] = Console.ReadLine();
            }

            Console.WriteLine("\nWpisane teksty to:\n");

            for (int j = 0; j < lengthOfTextArray; j++)
            {
                Console.WriteLine(j + 1 + ". " + text[j]);
            }


            Console.ReadKey();
        }
    }
}