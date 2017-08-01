using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Zadanie_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] quizQuestions = new string[] // for questions
            {" 1. Co pływa po kanale Weneckim?", // 0 ponton, gondola, galera, wodolot
            " 2. Jak nazywa się zjawisko świetlne obserwowane tylko na biegunie?", // 1  zorza polarna, tęcza, miraż, łuna
            " 3. Jak miał na imię założyciel firmy samochodowej Ford?", // 2 Henry, Harisson, Tom, Diesel
            " 4. Największe państwo świata?", //4  Rosja, Polska, USA, Kanada
            " 5. Największe słodkowodne jezioro świata?" // 5 Górne, Bajkał, Wiktorii, Wigry, Ontario
            };

            int quizIndex = 0; // replace index below in quizQuestionsAnswers

            string[][] quizQuestionsAnswers = new string[quizQuestions.Length][]; // for answers
            quizQuestionsAnswers[quizIndex++] = new string[] {"a) ponton", "b) gondola", "c) galera", "d) wodolot" };
            quizQuestionsAnswers[quizIndex++] = new string[] { "a) zorza polarna", "b) tęcza", "c) miraż", "d) łuna" };
            quizQuestionsAnswers[quizIndex++] = new string[] { "a) Henry", "b) Harisson", "c) Tom", "d) Diesel" };
            quizQuestionsAnswers[quizIndex++] = new string[] { "a) Rosja", "b) Polska","c) USA", "d) Kanada" };
            quizQuestionsAnswers[quizIndex++] = new string[] { "a) Górne", "b) Bajkał", "c) Wiktorii", "d) Wigry", "e) Ontario" };

            int totalWrongAnswerCounter = 0;

            for (int i=0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]); // shows questions and answers for them index 1 to index 1

                
                
                for (int j=0; j < quizQuestionsAnswers[i].Length; j++) //shows answers to the question
                {
                    Console.WriteLine(quizQuestionsAnswers[i][j]);

                }


                string correctAnswer = "";
                string correctLetter = "";

                //correct answers
                if (i == 0)
                {
                    correctAnswer = "gondola";
                    correctLetter = "b";
                }
                else if (i == 1)
                {
                    correctAnswer = "zorza polarna";
                    correctLetter = "a";
                }
                else if (i == 2)
                {
                    correctAnswer = "Henry";
                    correctLetter = "a";
                }
                else if (i == 3)
                {
                    correctAnswer = "Rosja";
                    correctLetter = "a";
                }
                else if (i == 4)
                {
                    correctAnswer = "Górne";
                    correctLetter = "a";
                }

                
                string answer = "";

                int wrongAnswerCounter = -1; //first enter gives +1 

                while (answer != correctAnswer && answer != correctLetter) // while is active till 'false'
                {
                    answer = Console.ReadLine();
                    wrongAnswerCounter = wrongAnswerCounter + 1;
                }


                totalWrongAnswerCounter = totalWrongAnswerCounter + wrongAnswerCounter;
                
            }

            Console.WriteLine("Liczba poprawnych odpowiedzi:" + quizQuestions.Length);
            Console.WriteLine("Liczba niepoprawnych odpowiedzi:" + totalWrongAnswerCounter);

            Console.ReadKey();
        }

    }
}
