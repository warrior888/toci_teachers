using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Teachers.Lekcja1
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ, zmienna, operator, ins log, petla, bloki kodów
            //ZAD 1 - Translacja duże małe litery na tablicy kodów ascii

            for (;true;)
            {


            }

            string example = "Bartłomiej";

            for(int i = example.Length -1; i >= 0; i--)
            {
                if (example[i] !='i')
                Console.Write(example[i]);

            }

            int[] lengthsOfStrings = new int[20];

            int j = 0;
            j = j + 1;
            int limit = lengthsOfStrings.Length;

            for (int i = 0; i < limit; i++) //i++ to i+1
            {
                Console.WriteLine("I wynosi: " + i);

                lengthsOfStrings[i] = ("I wynosi: " + i).Length;

            }











            Console.WriteLine("Podaj coś");
            string valueFromUserInput = Console.ReadLine();
            //Console.WriteLine("Podaj coś 2")
            //string secondvalueFromUserInput = Console.ReadLine();


            //string letterA = "a";

            //string lettera = "a";

            //int countOfA = 1;

            //int nameLength = 6;
            //if (valueFromUserInput == secondvalueFromUserInput.Length)
            {
                Console.WriteLine("pirwszy if sie wykonuje");
                int ofCourse = 6;

                if (valueFromUserInput.Length > 3)
                {
                    int w = 5;

                }
            }
            
            Console.WriteLine("Skonczylem");
            Console.ReadKey();
        }
}   }