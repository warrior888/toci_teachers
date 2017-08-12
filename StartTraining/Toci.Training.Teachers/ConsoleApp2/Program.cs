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
            int.TryParse(userInput, out int userInputNumber);

            int[] example = new int[userInputNumber];


        }
    }
}
