using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzanie_poprawnosci_lo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("wpisz login");

            string valueFromUserInput = Console.ReadLine();

            Console.WriteLine("Powtorz login");

            string secondvalueFromUserInput = Console.ReadLine();

            if(valueFromUserInput != secondvalueFromUserInput)
            {
                Console.WriteLine("Podaj prawidlowy login ");
            }

            else if (valueFromUserInput.Length == secondvalueFromUserInput.Length)
           
            {
                Console.WriteLine("Rejestracja przebiegla pomyslnie");
            }
            Console.ReadLine();
        }
    }
}
