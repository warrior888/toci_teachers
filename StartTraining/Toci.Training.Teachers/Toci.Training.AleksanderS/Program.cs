using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.AleksanderS
{
    class Program
    {
        static string letterSwitch()
        {

            Console.WriteLine("Podaj tekst do zamiany.");
            string input = Console.ReadLine();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                //duża litera
                if (input[i] > 64 && input[i] < 90)
                {
                    output += input[i] + 32;
                }
                //mała liera

                else if (input[i] > 96 && input[i] < 123)
                {
                    output += input[i] - 32;
                }

                //inny znak
                else
                {
                    output += input[i];
                }
            }
            return output;
        }

        static int takeN()
        {
            int result;
            string input = Console.ReadLine();
            int.TryParse(input, out result);
            return result;
        }

        static string[] stringTable()
        {
            int size = 0;
            do
            {
                Console.WriteLine("Podaj ilość linijek tekstu.");
                size = takeN();
                //sprawdzanie błędu 
                if (size == 0)
                {
                    Console.WriteLine("Błędna ilość linii.");
                }
            }
            while (size == 0);

            string[] table = new string[size];
            Console.WriteLine("Podaj " + size + " linii kodu.");
            for (int i = 0; i < size; i++)
            {
                table[i] = Console.ReadLine();
            }
            // Dla estetyki
            Console.WriteLine();
            return table;
        }

        static int max(int[] input)
        {
            int high = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (high < input[i])
                {
                    high = input[i];
                }
            }
            return high;
        }

        static int min(int[] input)
        {
            int low = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (low > input[i])
                {
                    low = input[i];
                }
            }
            return low;
        }

        static int add(int[] input)
        {
            int sum = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }

        static int seek(int[] input, int needle)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (needle == input[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void ActionTable()
        {
            int[] table = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
            int needle = 0;
            Console.WriteLine("Przykładowa tablica :" + table);
            Console.WriteLine("Maksymalna wartość to :" + max(table));
            Console.WriteLine("Minimalna wartość to :" + min(table));
            Console.WriteLine("Suma elementów to :" + add(table));
            //Można wszystkie polecenia wbić w 1 pętle, ale to utrudni potem modyfikację
            Console.WriteLine("Podaj element którego chcesz szukać");
            needle = takeN();
            Console.WriteLine("Szukana wartość występuje " + seek(table, needle) + " razy.");
            return;
        }


        /*static void saper()
        {
            int axisX = 0;
            int axisY = 0;
            int bombs = 0;
            Console.WriteLine("Podaj wielkość osi x:");
            axisX = takeN();
            Console.WriteLine("Podaj wielkość osi y:");
            axisY = takeN();
            int[ , ] table = new int[axisX, axisY];
            Console.WriteLine("Podaj ilość bomb:");
            bombs = takeN();
            if (bombs + 1 > axisY*axisX)
            {
                Console.WriteLine("Ha ha ha. Przegrałeś walkowerem.");
                return;
            }

        }
        */

        static void Main(string[] args)
        {
            //interfejs
            Console.WriteLine("Wybierz zadanie:");
            Console.WriteLine("1.Zamiana małe - duże litery");
            Console.WriteLine("2.Wrzucanie stringów do tablicy");
            Console.WriteLine("3.Działania na tablicach.");
            Console.WriteLine("4.Saper");
            Console.WriteLine("Wpisanie end kończy działanie programu :-(");
            string nrZadania = Console.ReadLine();
            switch (nrZadania)
            {
                case "1":                                           // Zamiana liter małe - duże
                    Console.WriteLine(letterSwitch());
                    break;

                case "2":
                    Console.WriteLine(stringTable());
                    break;

                case "3":
                    ActionTable();
                    break;

                /*case "4":
                    saper();
                    break;*/
                case "end":
                    break;

                default:
                    Console.WriteLine("Podano zły numer. Sprubuj jeszcze raz.");
                    return;
            }

        }
    }
}
