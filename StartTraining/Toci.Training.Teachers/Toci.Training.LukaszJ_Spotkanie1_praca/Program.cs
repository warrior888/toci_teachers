using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LukaszJ_Spotkanie1_praca
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Zadanie 1. Tworzy tablicę 10 elementową z wpisanych słów przez użytkownika i wypisuje ją w konsoli

            // Napisać kod w pętli for, który prosi o linijkę tekstu w bloku kodu i zapamiętuje (wrzuca) ją w tablicy i na koniec wyrzuci podziękowanie za podanie np. 10 elementów do tablicy

            string[] tableValueFromUser = new string[10];
            int number = tableValueFromUser.Length;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Wprowadź do tablicy wyraz nr " + (i + 1) + ":");
                tableValueFromUser[i] = Console.ReadLine();

                if (number - 1 == i)
                {
                    Console.WriteLine("\n" + "Dziękuję. Uzupełniłeś swoją tablicę 10 elementami.");
                }
            }

            Console.ReadKey();
            Console.WriteLine("\n" + "Tablica została wypełniona następującymi wartościami:");

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine((i + 1) + ". " + tableValueFromUser[i]);
            }

            Console.ReadKey();

            #endregion

        }
    }
}
