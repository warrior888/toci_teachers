using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.DamianG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] content = new int [] { 4, 56, 3, 2, 6, 8, 78, 54, 45, 54, 756, 78, 54, 3, 2, 1, 6 };
        
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }

            
            
            /* Console.WriteLine("Zmienna długość tablicy. Podaj długość jaką chcesz otrzymać:"); // To LEARN
            string input = Console.ReadLine();
            int inputNumbers = 0;
            int.TryParse(input, out inputNumbers);
            Console.WriteLine("Twoja tablica ma długosć " + inputNumbers);
            string [] arrayNumbers = new string [inputNumbers];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(i + 1); //dodanie liczb przed każdym słowem
                string arrayWord = Console.ReadLine(); // dodanie do tablicy słów 

                arrayNumbers[i] = arrayWord; // up
            }

            Console.WriteLine("\nDziękuję za podanie informacji");

            Console.WriteLine("\nTwoje informacje w tablicy to:");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write((i + 1) + "." + arrayNumbers[i] + " "); // wyświetlenie danych z tablicy (liczba + . + dana + spacja
            }



            string[] lengthOfStrings = new string[10];

            int limitS = lengthOfStrings.Length;

            Console.WriteLine("Podaj swoje informacje do tablicy");

            for (int i = 0 ; i < limitS ; i++)
            {
                Console.Write(i+1); //dodanie liczb przed każdym słowem
                string stringWord = Console.ReadLine(); // dodanie do tablicy słów 

                lengthOfStrings[i] = stringWord; // up
            }

            Console.WriteLine("\nDziękuję za podanie informacji");

            Console.WriteLine("\nTwoje informacje w tablicy to:");

            for (int i = 0; i < limitS; i++)
            {
                Console.Write( (i+1) + "." + lengthOfStrings[i] + " " ); // wyświetlenie danych z tablicy (liczba + . + dana + spacja
            }


            Console.WriteLine("Podaj słowo do odwórcenia");
            string name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
                
            }
            


            int[] lengthOfStrings = new int[10];
            int limit = lengthOfStrings.Length;
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Wpisz cokolwiek by pokazało się kilka razy");


            }

            Console.WriteLine("Podaj słowo do odwrócenia");
            string yourName = Console.ReadLine();
            for (int i = yourName.Length - 1; i >= 0; i--)
            {
                Console.Write(yourName[i]);
            }


            Console.WriteLine("Wpisz swoje imie");
            //string name;
            string name = Console.ReadLine();
            //string letterA = "a";
            string upperString = name.ToUpper();
            Console.WriteLine(upperString);

            Console.WriteLine("4 > 5 Prawda czy fałsz?");
            Console.ReadLine();
            bool value = 4 > 5;
            Console.WriteLine(value);

            int trueValue = "Damian " == "damian " ? 7 : 8;

            Console.WriteLine("Podaj wyraz a oblicze Ci jego długość");
            string word = Console.ReadLine();
            int count = word.Length;
            Console.WriteLine(count);

            Console.WriteLine("Czy twoje hasło jest wystarczająco długie?");
            string pass = Console.ReadLine();
            if (pass.Length >= 8)
            {
                Console.WriteLine("Hasło jest wspaniale długie");
            }
            else 
            {
                Console.WriteLine("Popracuj nad swoją długością hasła");
            }*/



            Console.ReadKey();
        }
    }
}
