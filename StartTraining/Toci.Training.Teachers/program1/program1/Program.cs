using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cztery zadania z tablicami

            Console.WriteLine("Zadanie domowe z tablicami");
            int[] tablica = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
            Console.WriteLine("Zadania na min i max z tablicy");

            // Ustalenie wartości minimalnej
            int min = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (min > tablica[i])
                {
                    min = tablica[i];
                }
            }
            Console.WriteLine("Wartosc minimalna to: " + min);
            Console.ReadKey();

            // Ustalenie wartości maksymalnej
            int max = tablica[0];
            for (int j = 1; j < tablica.Length; j++)
            {
                if (max < tablica[j])
                {
                    max = tablica[j];
                }

            }
            Console.WriteLine("Wartosc maksymalna to: " + max);
            Console.ReadKey();

            // Ustalenie sumy elementów tablicy
            int suma = 0;
            for (int k = 0; k < tablica.Length; k++)
            {
                suma = suma + tablica[k];
            }
            Console.WriteLine("Suma elementów tablicy to " + suma);
            Console.ReadKey();

            // Ustalenie zliczeń występowania podanej liczby w tablicy
            Console.WriteLine("Zliczanie wystąpień elementu w tablicy");
            Console.WriteLine("Wprowadz dowolna liczbe");
            string exampleElement = Console.ReadLine();
            int example = int.Parse(exampleElement);
            int countofexample = 0;
            for (int l = 0; l < tablica.Length; l++)
            {
                if (tablica[l] == example)
                    countofexample++;
            }
            Console.WriteLine("Podana wartość miała następującą liczbę wystąpień: " + countofexample);
            Console.ReadKey();


            //wpisywanie tekstu do tablicy

            string[] tekst = new string[10];
            for (int i = 0; i < tekst.Length; i++)
            {
                int x = i + 1;
                Console.WriteLine("Wpisz słowo nr " + x);
                tekst[i] = Console.ReadLine();
            }
            for (int j = 0; j < tekst.Length; j++)
            {
                Console.WriteLine(tekst[j]);
            }
            Console.WriteLine("Chyba sie udalo xd");
            Console.ReadKey();


        }
    }
}
