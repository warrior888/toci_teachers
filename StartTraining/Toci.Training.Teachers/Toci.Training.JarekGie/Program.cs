using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  zadanie     - translacja liter duże/małe na tablicy kodów ascii
    zadanie 1.1 - Dodawanie stringów do tablicy
    Zadanie 2.1 - Największy element tablicy
    Zadanie 3.1 - Najmniejszy element tablicy
    Zadanie 4.1 - Suma elementów tablicy
    Zadanie 5.1 - zliczanie wystąpień elementów w tablicy
     */
namespace Toci.Training.JarekGie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1.1 - Dodawanie stringów do tablicy
/*
            string[] tablica = new string[10];

            Console.WriteLine("Wpisz swoją liczbę: ");

            for(int i = 0; i < tablica.Length; i++)
            {
                
                tablica[i] = Console.ReadLine();

                Console.WriteLine("Dodano :" + tablica[i]);

                if (i == tablica.Length -1 )
                {
                    Console.WriteLine("Koniec Tablicy");
                }
            }
            for(int i = 0; i < tablica.Length; i++)
            { 
                Console.WriteLine(tablica[i] + " ");
            }
            */

            // Zadanie 2.1 - Największy element tablicy

            int min;
            int[] tablicaInt = new int[10];

            //klasa generująca liczby pseudolosowe
            Random r = new Random();


            //wypełniam tablicę liczbami pseudolosowymi
            for (int i = 0; i < tablicaInt.Length; i++)
            {
                tablicaInt[i] = r.Next(10);
                Console.Write(tablicaInt[i] + " ");
            }

            //Przejście do nowej linii
            Console.WriteLine();
            min = tablicaInt[9];

            for (int i = 0; i < tablicaInt.Length; i++)
            {
                if (tablicaInt[i] < min)
                {
                    min = tablicaInt[i];
                }

            }
            Console.WriteLine("Najmniejszy element tablicy to: " + min);
            Console.ReadKey();



        }//main
    }//class
}//namespace
