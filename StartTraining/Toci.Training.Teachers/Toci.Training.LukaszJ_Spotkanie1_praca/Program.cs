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
            Console.WriteLine("\n");

            #endregion

            #region Zadanie 2a. Tworzy tablicę ileś elementową (określoną przez użytkownika) z wpisanych słów przez użytkownika i wypisuje ją w konsoli

            // Kod któy prosi użytkownika o zadeklarowanie wielkości tablicy, wpisanie wartości i wypisanie ich na ekran przy użyciu TryParse

            Console.WriteLine("Ile chcesz umieścić wpisów w tablicy?");
            string userInput = Console.ReadLine();
            int userInputNumber = 0;
            int.TryParse(userInput, out userInputNumber);

            string[] tableDeclaredValueFromUser = new string[userInputNumber];
            int tableLength = tableDeclaredValueFromUser.Length;

            for (int i = 0; i < tableLength; i++)
            {
                Console.WriteLine("Wprowadź do tablicy wpis nr " + (i + 1) + ":");
                tableDeclaredValueFromUser[i] = Console.ReadLine();

                if (tableLength - 1 == i)
                {
                    Console.WriteLine("\n" + "Dziękuję. Uzupełniłeś swoją tablicę {0} elementami.", i + 1);
                }
            }

            Console.ReadKey();
            Console.WriteLine("\n" + "Tablica została wypełniona następującymi wpisami:");

            for (int i = 0; i < tableLength; i++)
            {
                Console.WriteLine((i + 1) + ". " + tableDeclaredValueFromUser[i]);
            }

            Console.ReadKey();
            Console.WriteLine("\n");

            #endregion

            #region Zadanie 2b. Tworzy tablicę ileś elementową (określoną przez użytkownika) z wpisanych słów przez użytkownika i wypisuje ją w konsoli

            // Kod któy prosi użytkownika o zadeklarowanie wielkości tablicy, wpisanie wartości i wypisanie ich na ekran przy użyciu Convert.ToInt32

            Console.WriteLine("Ile chcesz wpisać imion?");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            string[] imiona = new string[rozmiar];

            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("Podaj {0} imię", i + 1);
                imiona[i] = Console.ReadLine();
            }
            Console.WriteLine("Imiona, które zostały zapisane: ");
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + imiona[i]);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
