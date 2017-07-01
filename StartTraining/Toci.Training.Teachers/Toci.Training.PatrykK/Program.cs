using System;
namespace Toci.Training.PatrykK
{
    class Program
    {
        static void Main(string[] args)
        {
            // DOWOLNA MACIERZ I WPISYWANIE W NIĄ WARTOŚCI 
            int size = 4;
            string[] nameFourCorners= new string[size];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj cztery wartości dla macierzy:");
                string nameYourCorner = Console.ReadLine();
                nameFourCorners[i] = nameYourCorner;
                Console.Clear();
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write($" {nameFourCorners[i]} ");
            }
            Console.WriteLine();
            // MACIERZ 18-STO ELEMENTOWA Z WYLOSOWANYMI WARTOŚCIAMI
            int max = 17;
            int min = 0;

            int[] theGreatArray = new int[max];
            Random tryRanndomRandom = new Random();
            for (int i = min; i < max; i++)
            {
                theGreatArray[i] = tryRanndomRandom.Next(min, max);
                Console.Write($" {theGreatArray[i]} ");
            }
            Console.WriteLine();
            // MACIERZ ODWROTNA
            for (int j = theGreatArray.Length - 1; j >= min; j--)
            {
                Console.Write($" {theGreatArray[j]} ");
            }

            // MINIMALNA WARTOSC
            int minimum = theGreatArray[min];

            for (int k = min + 1; k < theGreatArray.Length; k++)
            {
                if (minimum > theGreatArray[k])
                {
                    minimum = theGreatArray[k];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Najmniejsza wartość w macierzy to {minimum}");
            // MAKSYMALNA WARTOŚĆ
            int maximum = theGreatArray[min];
            for (int l = min + 1; l < theGreatArray.Length; l++)
            {
                if (maximum < theGreatArray[l])
                {
                    maximum = theGreatArray[l];
                }
            }
            Console.WriteLine($"Największa wartość w macierzy to {maximum}"); 

            // SUMA WARTOŚCI W MACIERZY
            int addAll = 0;
            for (int m = min; m < theGreatArray.Length; m++)
            {
                addAll += theGreatArray[m];
            }
            Console.WriteLine($"Suma wartości to {addAll}");

            // ILOŚĆ POWTÓRZEŃ W MACIERZY 
            Console.WriteLine("Podaj twoją cyfrę");
            string numberInput = Console.ReadLine();
            int yourNumber;
            bool isString = int.TryParse(numberInput, out yourNumber);
            int numberOfTurns = 0;
            for (int n = min; n < theGreatArray.Length; n++)
            {
                if (yourNumber == theGreatArray[n])
                {
                    numberOfTurns += 1;
                }
            }
            Console.WriteLine($"Dla liczby {yourNumber} ilość powtórzeń w macierzy wynosi {numberOfTurns}. " +
                              $"Naciśnij ENTER aby zakończyć.");
            Console.ReadLine();
        }
    }
}
