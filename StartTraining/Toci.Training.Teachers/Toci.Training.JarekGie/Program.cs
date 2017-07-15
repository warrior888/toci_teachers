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
            ///*
            ////zadanie 1.1 - Dodawanie stringów do tablicy

            //string[] tablicaStringow = new string[10];


            //Console.WriteLine("Napisz coś :");

            //for (int i = 0; i < tablicaStringow.Length; i++)
            //{

            //    tablicaStringow[i] = Console.ReadLine();
            //    Console.WriteLine("Dodano :" + tablicaStringow[i]);
            //    if (i == tablicaStringow.Length - 1)
            //    {
            //        Console.WriteLine("Koniec tablicy");
            //    }
            //}


            //for (int i = 0; i < tablicaStringow.Length; i++)
            //{
            //    Console.Write(tablicaStringow[i] + " ");
            //}

            //for (int i = tablicaStringow.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(tablicaStringow[i] + " ");
            //}



            ////Zadanie 2.1 - Największy element tablicy


            //int max;
            //int[] tablica1 = new int[10];

            ////klasa generująca liczby pseudolosowe
            //Random r = new Random();


            ////wypełniam tablicę liczbami pseudolosowymi
            //for (int i = 0; i < tablica1.Length; i++)
            //{
            //    tablica1[i] = r.Next(10);
            //    Console.Write(tablica1[i] + " ");
            //}

            ////Przejście do nowej linii
            //Console.WriteLine();
            //max = tablica1[9];

            //for (int i = 0; i < tablica1.Length; i++)
            //{
            //    if (tablica1[i] > max)
            //    {
            //        max = tablica1[i];
            //    }

            //}
            //Console.WriteLine("Największy element tablicy to: " + max);

            ////Zadanie 3.1 - Najmniejszy element tablicy

            //int min;
            //int[] tablica2 = new int[10];

            ////klasa generująca liczby pseudolosowe
            //Random _r = new Random();


            ////wypełniam tablicę liczbami pseudolosowymi
            //for (int i = 0; i < tablica2.Length; i++)
            //{
            //    tablica2[i] = _r.Next(10);
            //    Console.Write(tablica2[i] + " ");
            //}

            ////Przejście do nowej linii
            //Console.WriteLine();
            //min = tablica2[9];

            //for (int i = 0; i < tablica2.Length; i++)
            //{
            //    if (tablica2[i] < min)
            //    {
            //        min = tablica2[i];
            //    }

            //}
            //Console.WriteLine("Najmniejszy element tablicy to: " + min);

            ////Zadanie 4.1 - Suma elementów tablicy

            //int wynik = 0;

            ////inicjalizacja tablicy
            //int[] tab = new int[10];

            ////inicjalizacja losowania
            //Random r_ = new Random();

            ////wypełnienie tablicy
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = r_.Next(10);
            //    Console.Write(tab[i] + " ");
            //}

            ////Pusta linijka
            //Console.WriteLine();

            ////suma tablicy
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    wynik += tab[i];
            //}
            //Console.WriteLine("Suma elementów to: " + wynik);
            //*/


            ////Zadanie 5.1 - zliczanie wystąpień elementów w tablicy

            //int suma,
            //    szukam;

            int[] elementy = new int[] { 2, 15, 56,78, 45, 3, 7, 8, 9, 11 };


            //for (int i = 0; i < elementy.Length; i++)
            //{
            //    Console.Write(elementy[i] + " ");
            //}
            //suma = 0;
            //szukam = 2;
            //for (int i = 0; i < elementy.Length; i++)
            //{
            //    if (elementy[i] == szukam)
            //    {
            //        suma = suma + 1;
            //    }

            //}
            //Console.Write("Szukana wartość występuje " + suma + " razy ");


            //sortowanie bąbelkowe



            //int temp;
            //for (int i = 0;i < elementy.Length; i++)
            //{
            //    for (int j = 0;j < elementy.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (elementy[i] < elementy[j])
            //            {
            //                temp = elementy[i];
            //                elementy[i] = elementy[j];
            //                elementy[j] = temp;
            //            }
            //        }

            //    }

            //}

            //for (int i = 0; i < elementy.Length; i++)
            //{
            //    Console.Write(elementy[i] + " ");
            //}

            /*
            //sub string

            string imie = "Jarek";

            for (int i = imie.Length - 1; i >= 0;i--)
            {
                Console.Write(imie[i]);

            }
            */
            //Quiz

            string[] quizQuestions = new string[]
            {
                "Czy język C# jest językiem .Net",
                "Który typ jest typem logicznym?",
                "Co przechowuje zmienna o typie int?"
            };
            string[][] quizAnswers = new string[quizQuestions.Length][];
            int quizIndexer = 0;
            quizAnswers[quizIndexer++] = new string[] { "a) tak", "b)nie" };
            quizAnswers[quizIndexer++] = new string[] { "a) int", "b)bool","c)double","float" };
            quizAnswers[quizIndexer++] = new string[] { "a) liczby dodatnie", "b)liczby całkowite","c)łańcuchy znaków",
                                                        "d)pojedynczy znak" };


            Console.ReadKey();



        }//main
    }//class
}//namespace
