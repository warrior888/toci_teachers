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

            // petla tablice algorytmika

            string[] quizQuestions = 
            {
                "Which of the below is a loop ?",
                "Which of the below is a condition ?",
                "Which of the below is a variable ?",
                "Which of the below starts a block code ?",
                "Which of the below is an array indexer ?",
            };

            string[][] quizQuestionsAnswers = new string[quizQuestions.Length][];

            int quizQIndexer = 0;

            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d", "e", "f"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c" };

            //Console.WriteLine(quizQuestions);

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);

                for (int j = 0; j < quizQuestionsAnswers[i].Length; j++)
                {
                    Console.WriteLine(quizQuestionsAnswers[i][j]);
                }
            }
            
            string ourSubstringCandidate = "beatka lubi programowac";
            
            int start = 6;
            int lengthToCut = 6;

            string cutString = "";

            for (int i = start; i < start + lengthToCut; i++)
            {
                cutString += ourSubstringCandidate[i];
            }


            int[] content = new int[] { 4,56,3,2,6,8,78,54,45,54,756,78,54,3,2,1,6 };

            int temp;

            for (int i = 0; i < content.Length; i++)
            {
                // 0
                for (int j = 0; j < content.Length; j++)
                {
                    // 0 1 2 3 4
                    if (i != j)
                    {
                        if (content[i] < content[j])
                        {
                            temp = content[i];
                            content[i] = content[j];
                            content[j] = temp;
                        }
                    }
                }
            }

            int max = int.MinValue;

            for (int i = 0; i < content.Length; i++)
            {
                if (max < content[i])
                {
                    max = content[i];
                }
            }

            int result = max;


            int min = int.MaxValue;

            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (min > content[i])
                {
                    min = content[i];
                }
            }


            int sum = 0;

            for (int i = content.Length - 1; i >= 0; i--)
            {
                sum += content[i];
            }

            int exampleElement = 78;
            int countOfExampleElement = 0;

            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (content[i] == exampleElement)
                {
                    countOfExampleElement++;
                }
            }


            string userInput = Console.ReadLine();
            int userInputNumber = 0;
            int.TryParse(userInput, out userInputNumber);

            int.Parse(userInput);

            int[] exampl = new int[userInputNumber];

            string example = "Bartłomiej"; 

            for (int i = example.Length - 1; i >= 0; i--) // i = 15 i -> 0 length = 16
            {
                if (example[i] != 'i')
                {
                    Console.Write(example[i]);
                }
            }

            int[] lengthsOfStrings = new int[20];
            //lengthsOfStrings[0] = 2;

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


            // [3,56,3,5,78,9,78,4,3,567,8]
            // 1. znalezc w tej tablkicy maxymalna wartosc
            // 2. xznalezc minimlna
            // 3. suma wszystkich elementow tablicy
            // 4. zliczyc ilosc wystapien przykladowego elementu 78 -> 2

            //   1  1  1
            //   1 -1  1
            //   1  1  1
        }
    }
}
