using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Edwin
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------Zadanie 1 ---------------
            Console.Write("Podaj ilość elementów tablicy: ");
            int numberOfTableElements = Convert.ToInt32(Console.ReadLine());

            string[] myTable = new string[numberOfTableElements];



            for (int i = 0; i < numberOfTableElements; i++)
            {
                Console.Write("Dla elementu [{0}] podaj wartość: ", i);
                myTable[i] = Console.ReadLine();

            }
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfTableElements; i++)
            {
                Console.Write("Dla elementu [{0}] wartość zapisana wynosi: {1}\n", i, myTable[i]);
            }

            // -------------------------------------

            //-----------Zadanie 2-----------------
            // stwórz i uzupełnij tablice
            Console.WriteLine("\n\n\nPodaj ilość elementów tablicy: ");

            int numbOfTableElement = Convert.ToInt32(Console.ReadLine());


            int[] tableOfElements = new int[numbOfTableElement];

            for (int i = 0; i < numbOfTableElement; i++)
            {
                Console.Write("Podaj {0} liczbę: ", i + 1);
                tableOfElements[i] = Convert.ToInt32(Console.ReadLine());
            }

            string tabElements = "";
            Console.WriteLine("\nTwoja tablica to: ");
            for (int i = 0; i < numbOfTableElement; i++)
            {
                Console.Write(" {0} ", tableOfElements[i]);
            }

            //-------------------------------------


            //-----------Zadanie 3-----------------
            // posortuj tablicę i znalezienie min i max
            Console.WriteLine("\n\nPosortowana tablica malejąco: ");

            int tymczasowaZmienna;

            for (int j = 0; j < numbOfTableElement; j++)
            {
                for (int i = 0; i < numbOfTableElement - 1; i++)
                {
                    if (tableOfElements[i] < tableOfElements[i + 1])
                    {
                        tymczasowaZmienna = tableOfElements[i + 1];
                        tableOfElements[i + 1] = tableOfElements[i];
                        tableOfElements[i] = tymczasowaZmienna;
                    }
                }
            }


            for (int i = 0; i < numbOfTableElement; i++)
            {
                Console.Write(" {0} ", tableOfElements[i]);
            }

            Console.WriteLine("\n\nPosortowana tablica rosnąco: ");



            for (int j = 0; j < numbOfTableElement; j++)
            {
                for (int i = 0; i < numbOfTableElement - 1; i++)
                {
                    if (tableOfElements[i] > tableOfElements[i + 1])
                    {
                        tymczasowaZmienna = tableOfElements[i + 1];
                        tableOfElements[i + 1] = tableOfElements[i];
                        tableOfElements[i] = tymczasowaZmienna;
                    }
                }
            }


            for (int i = 0; i < numbOfTableElement; i++)
            {
                Console.Write(" {0} ", tableOfElements[i]);
            }
            Console.WriteLine("\nWartość minimalna to: {0}\nWartość maksymalna to: {1}", tableOfElements[0], tableOfElements[numbOfTableElement - 1]);

            //-------------------------------------

            //-----------Zadanie 4-----------------
            // suma tablicy

            int sumOfElements = 0;
            for (int i = 0; i < numbOfTableElement; i++)
            {
                sumOfElements += tableOfElements[i];
            }

            //
            Console.WriteLine("Suma tablicy to: {0}", sumOfElements);

            Console.ReadKey();
        }
    }
}
