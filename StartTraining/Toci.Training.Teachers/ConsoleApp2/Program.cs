using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ile chcesz wpisać liczb");
            string userInput = Console.ReadLine();
            int userInputNumber = 0;
             int.TryParse(userInput, out userInputNumber);

            int[] tablica = new int[userInputNumber];

            for (int i = 0; i < userInputNumber ; i++)
            {
                Console.WriteLine("Wpisz jakas liczbe");
                string secondInput = Console.ReadLine();
                int secondInputNumber = 0;
                int.TryParse(secondInput, out secondInputNumber);
                tablica[i] = secondInputNumber;
            }

            Console.WriteLine("Okej tyle wystarczy");

            int bigger = tablica[1];

            for ( int i = 0; i < userInputNumber; i++)
            {
                if ( bigger < tablica[i])
                {
                    bigger = tablica[i];
                
                }
              
                
            }

            Console.WriteLine(" Maksymalna wartość to: " + bigger);

            Console.ReadKey();


        }
    }
}
