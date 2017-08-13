using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile chcesz liczb");
            string userInput = Console.ReadLine();
            int userInputNumber = 0;
            int.TryParse(userInput, out userInputNumber);

            int[] tablica = new int[userInputNumber];

            for (int i =0; i<userInputNumber; i++)
            {
                Console.WriteLine("jaka chcesz liczbe?");
                string number = Console.ReadLine();
                int numberChanged = 0;
                int.TryParse(number, out numberChanged);

                tablica[i] = numberChanged;

            }
            int smaller = tablica[0];

            for (int i = 0 ; i< userInputNumber; i++)
            {
                if ( tablica[i] < smaller)
                {
                    smaller = tablica[i];
                }
            }
            Console.WriteLine("najmniejsza to:" + smaller);

            Console.ReadKey();

        }
    }
}
