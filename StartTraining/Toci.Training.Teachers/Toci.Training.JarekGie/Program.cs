using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  zadanie     - translacja liter duże/małe na tablicy kodów ascii
    zadanie 1.1 - Dodawanie stringów do tablicy
    Zadanie 1.2 - Największy element tablicy
    Zadanie 1.3 - Najmniejszy element tablicy
    Zadanie 1.4 - Suma elementów tablicy
    Zadanie 1.5 - zliczanie wystąpień elementów w tablicy
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



                       for (int i = 0;i < tablica.Length; i++)
                       {
                           Console.Write("Podaj swój tekst: ");
                           tablica[i] = Console.ReadLine();
                           Console.WriteLine("Wpisałeś :" + tablica[i]);

                           if(i == tablica.Length -1)
                           {
                               Console.WriteLine("Koniec tablicy, dziękuję.");
                           }
                       }
                       for ( int i = 0; i < tablica.Length; i++)
                       {
                           Console.WriteLine("Do tablicy wpisano: " + tablica[i]);
                       }



                       // Zadanie 1.2 - Najmniejszy element tablicy

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
                      
                 // Zadanie 1.3 - Największy element tablicy

                       int max;
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
                       max = tablicaInt[0];

                       for (int i = 0; i < tablicaInt.Length; i++)
                       {
                           if (tablicaInt[i] > max)
                           {
                               max = tablicaInt[i];
                           }

                       }
                       Console.WriteLine("Największy element tablicy to: " + max);
                       

            //Zadanie 1.4 - Suma elementów tablicy

            int wynik = 0;
            int[] tablica = new int[10];
            Random r = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(10);
            }
            for (int i = 0; i < tablica.Length; i++)
            {
               
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
           
            for (int i = 0; i < tablica.Length; i++)
            {
                wynik += tablica[i];
                
            }


            Console.Write("Suma elementów tablicy, wynosi :" + wynik);
            

            //Zadanie 1.5 - zliczanie wystąpień elementów w tablicy

            int seek = 7;
            int count = 0;
            int[] tablica = new int[10];

            Random r = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(10);
                Console.Write(tablica[i] + " ");
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == seek)
                {
                    count = count + 1;

                }
               
            }
            Console.WriteLine();
            Console.Write("Liczba " + seek + " pojawia się w tablicy " + count + " razy.");
             */

            //string userInput = Console.ReadLine();
            //int userInputNumber = 0;
            //int.TryParse(userInput, out userInputNumber);


            //Zadanie 2.1 - Sortowanie bąbelkowe

            // int[] tablica = new int[] { 2, 32, 12, 43, 23, 456, 34, 36 };


            int[,] sudokuArray = new int[9, 9];
            Random line = new Random();
            
            for (int i = 0; i < sudokuArray.GetLength(0); i++)
            {
                for (int j = 0; j < sudokuArray.GetLength(1); j++)
                {
                    sudokuArray[i, j] = line.Next(9);
                }
            }
            for (int i = 0; i < sudokuArray.GetLength(0); i++)
            {
                for (int j = 0; j < sudokuArray.GetLength(1); j++)
                {
                    Console.Write(sudokuArray[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();



        }//main
    }//class
}//namespace
