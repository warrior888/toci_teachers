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
            Console.Write("Tablica:");

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


            Console.ReadKey();
        }
    }
}
