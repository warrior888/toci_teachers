using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalMytnik
{
    class ReverseWhile
    {
        static void Backboard(string[] args)
        {
            Console.WriteLine("Podaj wielkość tablicy od 0 do 20");
            string userInput = Console.ReadLine();
            int tableSize = 0;
            int.TryParse(userInput, out tableSize);


            string[] tableStrings = new string[tableSize];

            for (int i = 0; i < tableStrings.Length; i++)
            {
                Console.WriteLine("Dodaj " + (i + 1) + " znak do tablicy:");
                tableStrings[i] = Console.ReadLine();

                if (tableStrings.Length - 1 == i)
                {
                    Console.WriteLine("Tablica została uzupełniona");
                }

            }
            Console.WriteLine("Twoja tablica to:");

            for (int i = 0; i < tableStrings.Length; i++)
            {

                Console.Write(tableStrings[i]);

            }

            Console.ReadKey();

            Console.WriteLine("Napisz swoje imie i naciśnij enter");
            //string value = "";
            string value = Console.ReadLine();
            Console.WriteLine("Toje imie od tyłu to:");
            for (int i = value.Length - 1; i >= 0; i--)
            {
                Console.Write(value[i]);

            }

            Console.ReadKey();

        }
    }
}
