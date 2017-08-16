using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.KarolB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] losoweliczby = new int[] {3, 4, 67, 45, 43, 90, 86, 75, 47, 86, 93, 24, 67, 86};

            int temp;

            for (int i = 0; i < losoweliczby.Length; i++)
            {
                for (int j = 0; j < losoweliczby.Length; j++)
                {
                    if (i != j)
                    {
                        if (losoweliczby[i] < losoweliczby[j])
                        {
                            temp = losoweliczby[i];
                            losoweliczby[i] = losoweliczby[j];
                            losoweliczby[j] = temp;
                        }
                    }
                }
            }

        Console.WriteLine("Mój pierwszy program");
            Console.ReadLine();

            int position = Letterposition("Tygrys", 'g');
            string Name = "Karol i  Natalia ";
            int stringLength = Name.Length;

            if (stringLength < 4)
            {
                Console.WriteLine("If sie spełnił");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Spełnia sie else");
            }

            for (int i = 0; i < Name.Length; i++)
            {
                Console.Write(Name[i]);
            }

            Console.WriteLine("\n \n" + stringLength);
            Console.ReadLine();

            string animal = "tygrys";

            for (int i = animal.Length - 1; i >= 0; i--)
            {
                Console.Write(animal[i]);
            }
            Console.ReadLine();

            string[] animals = new string[5];
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("Wpisz zwierze {0}", i);
                animals[i] = Console.ReadLine();

            }

        }

        public static int Letterposition(string animal, char needle)
        {
            for (int i = 1; i < animal.Length; i++)
            {
                Console.WriteLine(animal[i]);
                if (animal[i] == needle)
                {
                    return i;
                }

            }
            return 4;


        }

    }

}