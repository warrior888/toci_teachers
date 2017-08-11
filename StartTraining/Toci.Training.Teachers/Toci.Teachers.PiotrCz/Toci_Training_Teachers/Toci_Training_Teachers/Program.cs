using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci_Training_Teachers
{
    class Program
    {
        static void Main(string[] args)
        {
            //typy zmiennych, operatory, ins log, petle, bloki kodu
            // kod ascii - rozroznia litery male duze cyfry itp. np. 0-48ascii, a-97ascii, A-65ascii
            // ZADANIE DOMOWE DAL CHETNYCH: tran    slacja duze male litery na tablicy kodow ascii czyli musimy zamienic male litery na duze
            // ToUpper > zamienia na duze litery np Bartek > BARTEK
            //utf8 poczytaj co to jest

            // ROBIMY DOSWIADCZENIE wpisujemy do zmiennej jakas wartosc


            string costam = "Piotrek123456789";

            for (int i = costam.Length - 1; i >= 0; i--)
            {
                if(costam[i] !='i')

                Console.WriteLine(costam[i]);
            }
            

            int[] lengthOfStrings = new int[10];

            for (int i = 0; i < lengthOfStrings.Length; i--)
                
            {
                Console.WriteLine("Linijka pętli numer = " + i);
            }


            Console.ReadLine();





          //  Console.WriteLine("wpisz login");


            string valueFromUserInput = Console.ReadLine();

            Console.WriteLine("Powtorz login");


            string secondvalueFromUserInput = Console.ReadLine();

            //   Console.WriteLine("dalem rade");

            if (valueFromUserInput.Length == secondvalueFromUserInput.Length)
                {
               //     Console.WriteLine("Rejestracja przebiegla pomyslnie");
                }
                else
                {
               //     Console.WriteLine("Nieprawidłowy login");
                }   
            //else
           // {
            //    Console.WriteLine("if sie nie wykonal to wyswietlilo sie to bo nie wpisales w konsoli przepisz to");
          //  }

            


            
            int test = "Bartek" == "bartek" ? 7 :8 ;

            bool robotnik = 4 > 5;

            string name = "Bartek";

            bool thisIsATest = "Bartek" == "bartek";

            bool thisIsTrue = false;

            string letterA = "a";

            string lettera = "a";

            int countOfA = 1;

            int nameLength = 6;

           // Console.WriteLine("To juz koniec");
            Console.ReadLine();

        }
    }
}
