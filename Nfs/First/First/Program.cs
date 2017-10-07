using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            // komentarz - nie  jest zrozumialy dla kompilatora - nuie musi
            // kod zrodlowy, jego składnia, skladnia dekjlaracji zmiennej 
            // blok kodu - funkcja, kod do wykonania dla instrukcji warunkowej
            // zmienna, deklaracja zmiennej, np bool, typ zmiennej ? rzutowanie typow ?
            // instruklcja warunkowa, operatory np =,  ==, > , <
            // Debugowanie kodu ? bug  - robak ; break point
            // funkcja, metoda

            bool digitsComparison; // true, false

            bool itIsFalse = 2 > 8; // 

            int digit = 0;

            //Console.WriteLine("Podaj cyfre:");
            //string userInput = Console.ReadLine();

            //int.TryParse(userInput, out digit);

            //AdvancedExampleForPalindrom zabawazpalindromem = new AdvancedExampleForPalindrom();

            //AdvancedExampleForPalindrom.

            string nameForPalindromExample = "Bartek";
            string reversed = "";



            for (int i = nameForPalindromExample.Length - 1; i > -1; --i)
            {
                
                Console.WriteLine("i wynosi: " + i + " znaczek ze zmiennej textowej to: " + nameForPalindromExample[i]);

                //reversed = reversed + nameForPalindromExample[i];
                reversed += nameForPalindromExample[i];

                Console.WriteLine("fragment slowka to: " + reversed);
            }

            if (reversed == nameForPalindromExample)
            {
                ///
            }
            else
            {
                ///
            }

            Console.ReadKey();

            return;


            if (digit > 8) // instrukcja warunkowa
            {
                //Program.Main // statyczne wywolanie metody
                Console.WriteLine("2 jest mn od 6"); // wtf is hover // przeciazenie metody ? intelisense -> ctrl + space ?
                // new Console ?? 
            }
            else
            {

            }

           // int final;
           // Console.WriteLine("podaj ilosc obiegow petli. ");
           // string finalStr = Console.ReadLine();

           // int.TryParse(finalStr, out final);

            // tablice

            int limit = 250;

            string[] UserNames = new string[limit];

            //int = x; cout << Podaj x << x;


            Console.WriteLine("P:odaj imie:");
            string name = Console.ReadLine();

            bool isViewer;
            int licznik = 0;

            string viewer = "Viewer";

            bool test = 2 == 8;

            for (; licznik < name.Length;)
            {
                 //Console.WriteLine(name[licznik] + "\n");

                if (viewer[licznik] == name[licznik]) // 0 -> V ?  1? i  ==
                {
                    Console.WriteLine(viewer[licznik] + " rowna sie " + name[licznik] + " licznik wynoisi " + licznik);
                    isViewer = true;
                }
                else
                {
                    Console.WriteLine(viewer[licznik] + " nie rowna sie " + name[licznik] + " licznik wynoisi " + licznik);
                    isViewer = false;
                }

                licznik++;
            }

            if (name == "Viewer ")
            {
                // logika poinform i nie wpusz
            }
            else
            {
                
            }

            // ??
            Console.ReadKey();
        }
    }
}
