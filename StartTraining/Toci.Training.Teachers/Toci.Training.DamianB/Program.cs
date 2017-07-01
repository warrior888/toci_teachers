using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.DamianB
{
    class Program
    {
        static void Main(string[] args)
        {
            // z1. Uzupełnianie tablicy z ilosci deklarowanej przez usera
            String NumberOfEntries;
            Console.WriteLine("Ile wpisów?");
            NumberOfEntries = Console.ReadLine();
            String[] DataTable = new String[int.Parse(NumberOfEntries)];
            for (int i = 0; i < int.Parse(NumberOfEntries); i++)
            {
                Console.WriteLine("Podaj wpis: ");
                DataTable[i] = Console.ReadLine();
                //poniżej sprawdzałem czy sie uzupełnia tablica i co zostało wpisane
                // Console.WriteLine("Wpisano " + DataTable[i]);

            }
            Console.WriteLine("Osiągnięto maksymalną ilość wpisów: {0}", NumberOfEntries);
            Console.WriteLine("wciśnij enter...");
            Console.ReadLine();
            //koniec z1.

            //Zad 2
            // tablica i operacje +, max, min, przeszukiwanie ilosc wystapien
            //deklaracja tablicy
            int[] intDataTable = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };

            //deklaracja zmiennych
            int maxValue = 0;
            int minValue = 0;
            int sumOfElements = 0;

            for (int i = 0; i < intDataTable.Length; i++)
            {
                minValue = intDataTable[0];
                //hmmm >= ??
                if (minValue > intDataTable[i])
                {
                    minValue = intDataTable[i];
                }
                //Console.WriteLine("przebieg wartość i: {0}", i);
                //Console.WriteLine("wartość tabeli nr: {0}", IntDataTable[i]);
                //Console.WriteLine("wartość testmnin: {0}", minValue);
            }

            for (int i = 0; i < intDataTable.Length; i++)
            {
                if (maxValue < intDataTable[i])
                {
                    maxValue = intDataTable[i];
                }
                //Console.WriteLine("przebieg wartość i: {0}", i);
                //Console.WriteLine("wartość tabeli nr: {0}", IntDataTable[i]);
                //Console.WriteLine("wartość maxValue: {0}", maxValue);
            }

            Console.WriteLine("Najwyższa wartość z tablicy to: {0}", maxValue);
            Console.WriteLine("Najniższa wartość z tablicy to: {0}", minValue);

            for (int i = 0; i < intDataTable.Length; i++)
            {
                sumOfElements += intDataTable[i];
             
            }

            Console.WriteLine("Suma elementów tablicy: {0}", sumOfElements);
            Console.WriteLine("Podaj liczbę do przeszukania tablicy: ");

            int UserInputValue = int.Parse(Console.ReadLine());

            int counter = 0;
            foreach (var input in intDataTable)
            {
                if (UserInputValue == input)
                {
                    counter += 1;
                }
            }
            Console.WriteLine("Ilość wystąpień poszukiwanej wartości {0} w tablicy to: {1}", UserInputValue, counter);
            Console.WriteLine("Naciśnij enter aby zakończyć pracę.");
            Console.ReadLine();
            //koniec zad 2.





        }
    }
}
