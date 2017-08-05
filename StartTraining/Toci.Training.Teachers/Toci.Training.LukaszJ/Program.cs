using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LukaszJ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region materiał z lekcji o debugowaniu
            string imie = "ghostrider";
            char szukane = 'o';
            int pozycja = 0;

            for (int i = 0; i < imie.Length; i++)
            {
                if (imie[i] == szukane)
                {
                    pozycja = i;
                }
            }
            #endregion

            /* for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj element");
               
                 napisać kod, który prosi o linijke tekstu
                  wrzuca do tablicy
                      najlepiej zeby program sie nie wywalal, i wyrzuci na ekran komunikat -> dziekuje, oczekiwalem maksymalnie 10 elementow, podales wszystkie jest fajnie

              int breakpoint = 1;
          }
          */

            Console.WriteLine("Podaj słowo do odwrócenia:");
            string userWord = Console.ReadLine();

            for (int i = userWord.Length - 1; i >= 0; i--)
            {
                Console.Write(userWord[i]); 

               /* if (i == 0)
                {
                    Console.WriteLine("Dziekuje, wszystko przebieglo bez problemu.");
                }
                */
            }
            int test = 1;
        }
    }
}
