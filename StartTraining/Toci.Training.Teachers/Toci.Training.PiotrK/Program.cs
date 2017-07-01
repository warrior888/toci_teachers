using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PiotrK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wypelniajacy tablice podanym tekstem.");

            string[] text = new string[5];

            int lengthOfTextArray = text.Length;
            int whichElement;

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

            // wyświetlenie żądanego elementu tablicy
            Console.WriteLine("Podaj numer elementu tablicy, który chcesz wyświetlić (zakres od 0 do {0}", lengthOfTextArray - 1);


            try
            {
                whichElement = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n{0}", text[whichElement]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Wystąpił wyjątek: {0}", ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Wystąpił wyjątek: {0}", ex.Message);
            }

            // zamiana na duże litery
            Console.WriteLine("\nZamiana na duże litery");

            for(int i = 0; i < lengthOfTextArray; i++)
            {
                Console.WriteLine(myUpperCase(text[i]));
            }
            // zamiana na małe litery
            Console.WriteLine("\nZamiana na małe litery");

            for (int i = 0; i < lengthOfTextArray; i++)
            {
                Console.WriteLine(myLowerCase(text[i]));
            }

            // zadania z poniedziałku
            // Deklaracje zmiennych
            int sizeOfArray = 100;
            int[] tab = new int[sizeOfArray];
            int tempMinValue;
            int tempMaxValue;
            int suma;
            int ileRazy = 0;
            int liczba;
            string liczbaStr;

            // Wypełnianie tablicy liczbami losowymi
            Random rnd = new Random();
            for (int i = 0; i < sizeOfArray; i++)
            {
                tab[i] = rnd.Next(-1000, 1000);
            }

            tempMinValue = tab[0];
            tempMaxValue = tab[0];
            suma = 0;

            // Wyszukiwanie wartości minimalnej
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (tab[i] < tempMinValue)
                    tempMinValue = tab[i];
            }

            // Wyszukiwanie wartości maksymalnej
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (tab[i] > tempMaxValue)
                    tempMaxValue = tab[i];
            }

            // Sumowanie
            for (int i = 0; i < sizeOfArray; i++)
            {
                suma += tab[i];
            }


            // Wypisanie tablicy
            Console.Write("\nTablica liczb:");

            for (int i = 0; i < sizeOfArray; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write(tab[i] + "\t");
            }

            // Wypisuję wyniki
            Console.WriteLine();
            Console.WriteLine("Wartość min: {0}", tempMinValue);
            Console.WriteLine("Wartość max: {0}: ", tempMaxValue);
            Console.WriteLine("Suma: {0}", suma);

            // Zliczanie wystąpień liczby
            Console.WriteLine("Podaj liczbę do wyszukania");
            liczbaStr = Console.ReadLine();
            liczba = Int32.Parse(liczbaStr);

            for (int i = 0; i < sizeOfArray; i++)
            {
                if (tab[i] == liczba)
                    ileRazy++;
            }
            Console.WriteLine("Szukana liczba występuje {0} raz(y)", ileRazy);

            Console.ReadKey();
        }

        public static string myUpperCase(string word)
        {
            char[] example;
            example = word.ToCharArray();
            int tmp;
            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] < 65 || (int)word[i] > 90)
                {
                    tmp = (int)word[i];
                    tmp -= 32;
                    example[i] = (char)tmp;
                }
            }

            return new string(example);
        }


        public static string myLowerCase(string word)
        {
            char[] example;
            example = word.ToCharArray();
            int tmp;
            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] < 97 || (int)word[i] > 122)
                {
                    tmp = (int)word[i];
                    tmp += 32;
                    example[i] = (char)tmp;
                }
            }

            return new string(example);
        }
    }
}
