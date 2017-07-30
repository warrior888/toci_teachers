using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Zadanie_MaleDuzeLitery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zmieniajacy wielkość małych i dużych liter. Aby zakończyć program wpisz 'zakończ'.");

            string wyraz = "";

            Console.WriteLine("Wpisz literę:");
            while (wyraz != "zakończ")
            {
                wyraz = Console.ReadLine();

                if (wyraz.Length > 1)
                {
                    Console.WriteLine("Podaj pojedyńczą literę!");
                }
                else if (wyraz.Length == 0)
                {
                    Console.WriteLine("Pole nie może zostać puste");
                }
                else
                {
                    char litera = wyraz.ElementAt(0); //first element from my string wyraz

                    int asciiValue = (int)litera; // change char into int

                    char wynik;

                    if (65 <= asciiValue && asciiValue <= 90)
                    {
                        wynik = (char)(asciiValue + 32);
                        Console.WriteLine(wynik);
                    }
                    else if (97 <= asciiValue && asciiValue <= 122)
                    {
                        wynik = (char)(asciiValue - 32);
                        Console.WriteLine(wynik);
                    }
                    else
                    {
                        Console.WriteLine("Wpisz literę!");
                    }

                }
            }

            
            
        }
    }
}
