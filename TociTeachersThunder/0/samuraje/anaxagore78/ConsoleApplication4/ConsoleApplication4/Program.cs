using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    /*
      Napisać program pobierający od użytkownika dwie liczby całkowite, następnie wypełniający tablicę dwuwymiarową 
      o rozmiarze 500x500 losowymi wartościami całkowitymi z przedziału [-100, 200], z wyjątkiem elementów znajdujących się na przekątnej,
      które w ok. 50% przypadków mają otrzymać wartość 1, w pozostałych -1. Po wypełnieniu całej tablicy należy policzyć,
      ile jej elementów posiada wartość taką samą, jak jedna z liczb podanych przez użytkownika. Wynik wypisać na ekran.
        
         
         */

    class Program
    {
        static int[,] array { get; } = new int[500, 500];
        static int? Number1 { get; set; }
        static int? Number2 { get; set; }
        static int Counter { get; set; }

        static void Main(string[] args)
        {
            ReadUserInput();
            FillArray();
            DisplayArray();
            CheckArray();
            Console.ReadLine();
        }



        private static void ReadUserInput()
        {
            do
            {
                if (Number1 == null)
                {
                    Console.WriteLine("Podaj pierwszą liczbę całkowitą");
                    Number1 = CheckIfNumber(Console.ReadLine());
                }
                if (Number2 == null)
                {
                    Console.WriteLine("Podaj drugą liczbę całkowitą");
                    Number2 = CheckIfNumber(Console.ReadLine());
                }
            }
            while (Number1 == null || Number2 == null);
        }



        private static void FillArray()
        {
            Random rnd1 = new Random();
            for (int x = 0; x < 500; x++)
            {
                for (int y = 0; y < 500; y++)
                {
                    array[x, y] = (x == y) ? ((x % 2 == 0) ? 1 : -1) : rnd1.Next(-100, 200);
                }
            }
        }

        private static void DisplayArray()
        {
            for (int i = 0; i < 500; i++)
            {
                for (int m = 0; m < 500; m++)
                {
                    Console.Write("{0, 5}", array[i, m]);
                    if ((m + 1) % 500 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }


        private static int? CheckIfNumber(string tempInt)
        {
            int tempNo;
            if (int.TryParse(tempInt, out tempNo))
            {
                return tempNo;
            }

            Console.WriteLine(tempInt + " - nie jest liczbą całkowitą");
            return null;

        }
        private static void CheckArray()
        {
            foreach (var item in array)
            {
                if (item.Equals(Number1) || item.Equals(Number2))
                {
                    Counter++;
                }
            }
            Console.WriteLine("Ilość wystąpień Twoich liczb w wygenerowanej losowo tablicy wynosi: " + Counter);
        }
    }
}
