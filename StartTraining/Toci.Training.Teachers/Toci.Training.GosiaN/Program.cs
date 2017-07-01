using System;

namespace Toci.Training.GosiaN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
         
            Console.Write("Tortilla od tyłu to ");
            string word = "Tortilla";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Podaj swoje imię");
            string name = Console.ReadLine();

            //odczytanie ostatniej litery imienia jako substring

            string last = name.Substring(name.Length - 1, 1);

            //jeśli imię kończy się na -a i nie jest to "Kuba", to użytkownik jest dziewczyną
            //w innym wypadku, to chłopak

            if (last=="a" && name!="kuba" && name!="Kuba")
            {
                Console.WriteLine("Cześć, dziewczyno! ");
            } else {
                    Console.WriteLine("Cześć, chłopaku! ");
                }

            //podaje imię użytkownika od tyłu
            Console.Write("Twoje imię od tyłu to ");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }

            Console.WriteLine("\nW tablicy {11, 38, 654, 232, 908, 47, 232, 489, 232, 38}");

            //tablica
            int[] table = { 11, 38, 654, 232, 908, 47, 232, 489, 232, 38 };

            //znalezienie maksymalnej wartości
            int max = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (max < table[i])
                    max = table[i];
            }
            Console.WriteLine("- największa wartość to " + max);

            //znalezienie minimalnej wartości
            int min = table[0];

            for (int i = 0; i < table.Length; i++)
            {
                if (min > table[i])
                    min = table[i];
            }
            Console.WriteLine("- najmniejsza wartość to " + min);

            //dodanie wszystkich wyrazów
            int sum = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }
            Console.WriteLine("- suma wyrazów to " + sum);

            //wybranie liczby z tablicy i policzenie, ile razy występuje
            Console.WriteLine("Wybierz jedną z liczb w tablicy.");
            int chosenNumber = 0;
            int.TryParse(Console.ReadLine(), out chosenNumber);

            Console.WriteLine("Wybrana liczba to " + chosenNumber);
            int instance = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if(table[i] == chosenNumber)
                instance++;
            }
            Console.WriteLine(chosenNumber + " występuje w tablicy " + instance + " razy.");


        }
    }
}
