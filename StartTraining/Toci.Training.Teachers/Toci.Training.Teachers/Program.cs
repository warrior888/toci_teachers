using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Teachers
{
    class Program
    {
        static void Main(string[] args)
        {
            // typ, zmienna tablica , operator, debugowanie, ins log, blokow kodu, petli, kawa, zakres
            // kody ascii
            // 0 - 48ascii
            //a - 97
            // A - 65
            // translacje duze male litery na tabloicy kodow ascii 
            // utf8

            string example = "Bartłomiej"; 

            for (int i = example.Length - 1; i >= 0; i--)
            {
                if (example[i] != 'i')
                {
                    Console.Write(example[i]);
                }
            }

            int[] lengthsOfStrings = new int[20];
            //lengthsOfStrings[0] = 2;

            int j = 0;
            j = j + 1; // j++
            int limit = lengthsOfStrings.Length;

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("I wynosi: " + i);

                lengthsOfStrings[i] = ("I wynosi: " + i).Length;

                if (i > 5)
                {
                    
                }

//                i++;
            }

            Console.WriteLine("Podaj cos czlowieku: ");
            string valueFromUserInput = Console.ReadLine();
            Console.WriteLine("Podaj drugie cos czlowieku: ");
            string secondValueFromUserInput = Console.ReadLine();

            if (valueFromUserInput.Length == secondValueFromUserInput.Length) // whatever -> true
            {
                //Debug.WriteLine();
                Console.WriteLine("pierwszy if sie wykonuje");
                int ofCourse = 6;

                if (valueFromUserInput.Length > 3) // 0 a 1
                {
                    int w = 5;
                    Console.WriteLine(ofCourse + w); // dodane przez Kafar, żeby wyeliminować warningi
                }
            }
            else if (valueFromUserInput.Length == 5)
            {
                
            }
            else if (secondValueFromUserInput.Length == 12)
            {
                
            }
            else
            {
                
            }

            //valueFromUserInput = "";

            string name = "źródło"; // ToUpper -> BARTEK
            //name.Length 
            // + - * / ++ -- += -= *= /= && || % ^ != == > < >= <=  ? :
            int test = "Bartek " == "Bartek" ? 7 : 8;

            bool robotnik = 4 > 5;

            int elchu = 0;

            //elchu =+ 9;

            //  x -> 

            bool thisIsTrue = false; // 0 true -> 1
            

            //string źródło = "";

            string letterA = "a";

            string lettera = "a";

            int countOfA = 1;
            int nameLength = 6;

            Console.WriteLine(name + test + robotnik + elchu + thisIsTrue + letterA + lettera + countOfA + nameLength); // dodane przez Kafar, żeby wyeliminować warningi
            Console.WriteLine("Skonczylem");
            Console.ReadKey();
        }
    }
}
