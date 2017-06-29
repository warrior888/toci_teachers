using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadania_z_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            // [3,56,3,5,78,9,78,4,3,567,8]
            // zad.1 znalezc w tej tablicy maxymalna wartosc
            // zad.2 znalezc minimalna
            // zad.3 suma wszystkich elementow w tablicy
            // zad.4 zliczyc ilosc wystapien przykladowego elementu

            int[] table = {3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8};

            int wielkosc = table.Length;

            for (int i = 0; i < wielkosc; i++)
            {
                Console.WriteLine(i+1 + ". wartosc: " + table[i]);
            }

            Console.WriteLine();

            Console.ReadKey();

            // zad.1

            int max = table[0];

            for (int j = 1; j < wielkosc; j++)
            {
                if (max < table[j])
                {
                     max = table[j];
                }
            }
            
            Console.WriteLine("Najwieksza wartosc w tablicy to: " + max);

            // Console.WriteLine($"Najwieksza wartosc to: " + table.Max());
            // Console.WriteLine();

            Console.ReadKey();

            // zad.2

            int min = table[0];

            for (int j = 1; j < wielkosc; j++)
            {
                if (min > table[j])
                {
                    min = table[j];
                }
            }

            Console.WriteLine("Najmniejsza wartosc w tablicy to: " + min);

            // Console.WriteLine("Najwieksza wartosc w tablicy to: " + max);
            // Console.WriteLine($"Najmniejsza wartosc to: " + table.Min());
            // Console.WriteLine();

            Console.ReadKey();

            // zad.3

            int x = table[0];
            int y = x;

            for (int m = 1; m < wielkosc; m++)
            {
                if (y == table[0])
                {
                    y = x + table[1];
                }
                else
                {
                 y = y + table[m];
                }
            }

            Console.WriteLine("Suma wartosci z tablicy jest rowna: " + y);
            Console.WriteLine();

            Console.ReadKey();

            // zad.4

            for (int g = 0; g < wielkosc; g++)
            {
                int value = table[g];
                int ilosc = 0;

                foreach (int item in table)
                {
                    if (item == value)
                    {
                        ilosc++;
                    }
                }

                Console.WriteLine("Wartosc " + value + " wystepuje w tablicy " + ilosc + " razy");
            }
           
            Console.ReadKey();

        }
    }
}
