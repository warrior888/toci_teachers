using System;

namespace Toci.Training.WojciechSeweryn
{
    public class QuizLogic
    {
        
        public void Load()
        {
            int score = 0;
            int wrongAnswers = 0;
            int questionCounter = 0;

            //QUESTIONS
            string[] quizQuestions = new string[]
            {
                "Whitch of the below is a loop? ", //1
                "Whitch of the below is a condition? ", //2
                "Whitch of the below is a variable? ", //3
                "Whitch of the below stars a block code? ", //4
                
            };

            //ANSWERS (LAST IS CORRECT)
            string[][] quizQuestionAnswers = new string[quizQuestions.Length][];
            
            quizQuestionAnswers[questionCounter++] = new string[] {"a) while ", "b) int ", "c) string ", "d) double ", "e) Visual Studio ", "f) Debug ", "a" };
            quizQuestionAnswers[questionCounter++] = new string[] {"a) program.cs ", "b) public ", "c) Solution Explorer ", "d) != ", "d" };
            quizQuestionAnswers[questionCounter++] = new string[] {"a) null ", "b) break ", "c) if () ", "a" };
            quizQuestionAnswers[questionCounter++] = new string[] {"a) ( ", "b) { ", "c) [ ", " d) string[] ", "b" };

            Console.Write("Please Enter Your Name: ");
            string user = Console.ReadLine();
            Console.WriteLine("Hello, {0} \nPress any key to continue...", user);
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);

                for (int j = 0; j < quizQuestionAnswers[i].Length - 1; j++)
                {
                    Console.WriteLine(quizQuestionAnswers[i][j]);
                }
                
                int temp = quizQuestionAnswers[i].Length;
                string answer = "";
                do
                {
                    Console.Write("Answer: ");
                    answer = Console.ReadLine();

                    if (answer == quizQuestionAnswers[i][temp - 1])
                    {
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer, try again.");
                        wrongAnswers++;
                    }
                }
                while (answer != quizQuestionAnswers[i][temp - 1]);
                Console.Clear();
            }
            int points = score - wrongAnswers;
            Console.WriteLine(user+" here are the results of your quiz!\n"+"Correct answers : " + score + "\nUncorrect answers: " + wrongAnswers + "\nYou scored: " + points + " points!");
        }
    }
}
