using System;

namespace Toci.Training.GosiaN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Tortilla od tyłu to ");
            string word = "Tortilla";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Podaj swoje imię");
            string name = Console.ReadLine();

            Console.Write("Twoje imię od tyłu to ");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }




        }
    }
}
