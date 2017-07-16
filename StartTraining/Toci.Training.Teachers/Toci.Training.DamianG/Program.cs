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
            }



            Console.ReadKey();
        }
    }
}
