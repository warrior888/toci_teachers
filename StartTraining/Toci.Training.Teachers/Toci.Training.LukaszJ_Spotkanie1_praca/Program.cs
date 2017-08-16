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

            #region Dodatkowe zadania domowe

            // tablica o wartości: { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 }
            // 1. Znaleźć w tej tablicy maksymalną wartość
            // 2. znaleźć minimalną wartość
            // 3. Zrobić sumę wszystkich elementów tablicy
            // 4. Zliczyć ilość wystąpień przykładowego elementu, np. szukamy 78 to ma wyskoczyć 2, bo tyle mamy wystąpień w tablicy


            int[] liczby = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };

            // Ad. 1
            int max = liczby[0]; // tymczasowe maximum

            for (int i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] > max)
                {
                    max = liczby[i];
                }
            }
            Console.WriteLine("Maksymalna liczba w tablicy wynosi: {0}", max);
            Console.ReadKey();

            //Ad. 2
            int min = liczby[0]; // tymczasowe minimum

            for (int i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] < min)
                {
                    min = liczby[i];
                }
            }
            Console.WriteLine("Minimalna liczba w tablicy wynosi: {0}", min);
            Console.ReadKey();
            #endregion
        }
    }
}
