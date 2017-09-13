using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LukaszJ_Spotkanie1_Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Różne informacje

            /* 
                Programowanie to umiejętność zastosowania: typu, zmiennej, operatora, tablicy, instrukcji logicznej, pętli i pisanie bloków kodu, debugowanie
                Zmienna - przetwarza dane jakiegoś typu.
                Litery operują na kodach Ascii, np. 0 = 48(ascii), a = 97 (ascii), A = 65 (ascii)
                Wielkość liter w zmiennych ma znaczenie.
                Nazwy zmiennych, metod, komentarzy itd. piszemy po angielsku, nie używamy polskich znaków
                Układ klawiatury może wpływać na kody ascii (np. angielski lub polski programisty)
                zmienne lądują do RAM-u a instrukcje i pętle (np. if) do procesora
                Jak zmienna powstanie z deklaracją typu to potem używanie tej zmiennej już nie może być poprzedzone nazwą typu, bo to jest deklaracja zmiennej, i deklaracja zmiennej odbywa się tylko raz w skali budowania kodu, np. int elchu = 0;    elchu += 9;
            */

            #endregion

            #region Najważniejsze typy danych

            /*  
                Typy zmiennych:
                string - przetwarza tekst
                bool - przetwarza wartości logiczne- coś co przyjmuje albo true albo false
                int - wartości liczbowe całkowite, czyli również ujemne
            */

            string name = "Bartek";
            string letterA = "a";

            string źródło = ""; // niezalecana forma nazewnictwa zmiennych, kod musi być międzynarodowy

            int countOfA = 1; // ile jest wystąpień litery a""
            int nameLength = 6; // z ilu liter składa się imię

            bool thisIsTrue = !false; // 0 -> false, 1 -> true, ! -> operator negacji (zaprzeczenia), w tym przykładzie wartość zmiennej thisIsTrue ma wartość true
            bool thisIsATest = "Bartek" == "bartek"; // false
            bool robotnik = 4 > 5; // zwraca wartość bool

            #endregion

            #region Działanie na stringach

            // string name = "Łukasz".ToLower; // zamieni napis w zmiennej na małe litery (łukasz)
            // string name = "Łukasz".ToUpper; // zamieni napis w zmiennej na duże litery (ŁUKASZ)

            #endregion

            #region Rodzaje operatorów

            /*
                = operator przypisania
                == operator porównania
                ! operator negacji (zaprzeczenia)
                + operator dodawania
                - operator odejmowania
                * operator mnożenia
                / operator dzielenia
                % operator dzielenia z resztą
                ^ operator potęgi
                != operator nierówna się, zaprzeczenia, że się równa coś czemuś
                ? : Ternary Operator (przed dwukropkiem jest wartość dla prawda, po dwukropku dla fałsz), np. int test = "Bartek" == "bartek" ? 7 : 8; // da wynik 8
                pozostałe operatory: ++ -- += -= *= /= &&->(and) ||->(or) > < >= <= 
                int test = "Bartek" == "bartek" ? 7 : 8; // jeśli Bartek = bartek to zwraca false. Przed dwukropkiem jest miejsce dla wartości prawda a po dwukropku wartość dla false. W tym przypadku wynik to 8
            */

            #endregion

            #region Instrukcje warunkowe: IF, ELSE IF, ELSE

            // Wypisujemy komunikat w konsoli dla użytkownika
            Console.WriteLine("Podaj coś człowieku: ");
            // wczytujemy do zmiennej jakąś wartość wpisaną przez użytkownika w konsoli
            string valueFromUserInput = Console.ReadLine(); // wczyta się jakaś wartość wpisana przez użytkownika w konsoli z klawiatury i zakończone będzie enterem. W zmiennej valueFromUserInput pojawi się wartość wpisana w konsoli
            //valueFromUserInput = ""; // ponowne użycie zmiennej i wyczyszczenie jej wartości

            Console.WriteLine("Podaj drugie coś człowieku");
            string secondValueFromUserInput = Console.ReadLine();

            if (valueFromUserInput.Length == secondValueFromUserInput.Length) // jeżeli obie wpisane wartości przez użytkownika mają taką samą ilość znaków to poniższy kod się wykona
            {

                Console.WriteLine("Pierwszy if sie wykonuje bo zmienna valueFromUserInput ma taką samą ilość znaków jak zmienna secondValueFromUserInput");
                int ofCourse = 6;

                if (valueFromUserInput.Length > 3)
                {
                    // ten kod się nie wykona, bo warunek logiczny ma wartość false
                    int w = 5;
                }
            }
            /*
            else if (valueFromUserInput.Length == 5)
            {

            }
            else if (secondValueFromUserInput == 12)
            {

            }
            else
            {

            }
            */

            if (valueFromUserInput == "cos") // jeżeli użytkownik wpisze w konsoli "cos" to równa się true
            {

                Console.WriteLine("Drugi if sie wykonuje bo zmienna valueFromUserInput ma zadeklarowaną wartość.");
                int ofCourse = 6;

                if (valueFromUserInput.Length > 3)
                {
                    // ten kod się nie wykona, bo warunek logiczny ma wartość false
                    int w = 5;
                }
            }
            // ten kod nigdy się nie wykona, bo warunek logiczny ma wartość false
            if (4 > 5)
            {

                int ofCourse = 6;

                if (4 > 6)
                {
                    // ten kod też się nie wykona
                }
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            #endregion

            #region Tablice

            int[] lengthsOfStrings = new int[10]; //deklarowanie 10-elementowej tablicy intów
            // lengthsOfStrings[0] = 2; -> deklaracja wartości pierwszego elementu w tablicy z indeksem tablicowym o wartości 0, wartość tego elementu teraz wynosi 2

            // int j = 0;
            // j = j + 1; // j++

            /* Pętla for ze szkolenia */
            int limit = lengthsOfStrings.Length;

            for (int i = 0; i < limit; i++) // pętla długości tablicy
            {
                Console.WriteLine("I w tablicy lengthsOfStrings wynosi: " + i); // wyświetla komunikat przy każdym podbiciu pętli wypisując nową wartość zmiennej i

                lengthsOfStrings[i] = ("I wynosi: " + i).Length; // bierze każdy element tablicy i liczy jego długość wraz z tekstem w nawiasie,np "I wynosi: 9" daje 11 znaków długości (liczymy od 1 a nie od 0)

                if (i > 5)
                {

                }
            }

            Console.ReadKey();
            Console.WriteLine();

            #endregion

            #region Pętla FOR - przykłady użycia

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine("Krok: " + index);
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            for (int index = 5; index < 15; index++)
            {
                Console.WriteLine("Krok: " + index);
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Nie będę przeszkadzał na lekcji: po raz " + i);
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            #endregion

            #region Pętla która odwraca wpisane przez użytkownika słowo

            Console.WriteLine("Podaj słowo do odwrócenia: ");
            string userWord = Console.ReadLine();

            for (int i = userWord.Length - 1; i >= 0; i--)
            {
                Console.Write(userWord[i]); // pętla która czyta słowo od tyłu 
            }

            Console.ReadKey();
            Console.WriteLine("\n");

            #endregion

            #region Pętla która odwraca zadeklarowane w zmiennej słowo przez użytkownika

            string example = "Bartłomiej";

            for (int i = example.Length - 1; i >= 0; i--)
            {
                Console.Write(example[i]); // pętla która czyta słowo od tyłu //jeimołtraB
            }

            Console.WriteLine("\n");

            #endregion

            #region Pętla która czyta słowo od tyłu z pominięciem wszystkich liter i

            string example2 = "Bartłomiej";
            //jemołtraB
            for (int i = example2.Length - 1; i >= 0; i--)
            {
                if (example2[i] != 'i')
                {
                    Console.Write(example2[i]);
                }
            }

            Console.WriteLine("\n");
            #endregion

            #region Konsola - komendy

            Console.WriteLine("Skonczylem"); // Wypisanie tekstu w konsoli
            Console.ReadKey(); // dzięki temu okno konsoli nie przepada po skończeniu debugowania. ReadKey czeka na jakieś zdarzenie klawiatury, wczytanie jakiegoś znaczka.

            #endregion
        }
    }
}
