using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
            int incorrect = 0;
            string answer = "";
            int quizindexer = 0;


            string[] FirstQuiz = new string[]
            {
                "Which of the below is a loop?",
                "Which of the below is a variable?",
                "Which of the below starts a block code?",
                "Which of the below is an array indexer ?",
                "Which of the below is a type ?",

            };
            
            string[] Answers = new string[]
            {
                "for",
                "first",
                "{}",
                "[]",
                "double",
            };

            string[][] FirstQuizAnswers = new string[FirstQuiz.Length][];
            {
                FirstQuizAnswers[quizindexer++] = new string []{"a. string","b. int","c. for", "d. class"};
                FirstQuizAnswers[quizindexer++] = new string []{"a. static","b. first","c. string", "d. Console", "e.else"};
                FirstQuizAnswers[quizindexer++] = new string []{"a. []","b. {}","c. ()",};
                FirstQuizAnswers[quizindexer++] = new string []{"a. <>","b. ==","c. --","d. ++", "e. []"};
                FirstQuizAnswers[quizindexer++] = new string []{"a. foreach","b. double","c. namespace ","d. System", "e. public"};
            };
            for (int i = 0 ; i < FirstQuiz.Length; i++)
            {
                Console.WriteLine(FirstQuiz[i]);

                for (int j =0; j < FirstQuizAnswers[i].Length; j++)
                {
                    Console.WriteLine(FirstQuizAnswers[i][j]);
                }

                Console.WriteLine("Wpisz odpowiedź:");

                answer = Console.ReadLine();

                while (answer != Answers[i])
                {
                    Console.WriteLine("Błędna odpowiedź, spróbuj ponownie");
                    incorrect++;
                    answer = Console.ReadLine();

                }
                correct++;

            }
            Console.WriteLine("Dziękuje za uzupełnienie testu poniżej Twój wynik :)");
            Console.WriteLine("Poprawnych  " + correct + "  " + "Błędnych  "+ incorrect);
            Console.ReadKey();
        }
    }
}
