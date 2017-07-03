using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PawelKielkowski
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            string[] QuizQuestions = 
            {
                 "1. What is the longest river in the Poland: ",
                 "2. Which of this town is a capital city of Poland: ",
                 "3. What is the bigest mountain top in Poland: ",
                 "4. How many people live in Poland: ",
                 "5. Who is actually a president of Poland:",

            };

            string[][] QuizAnswers = new string[QuizQuestions.Length][];

            QuizAnswers[0] = new string[] { "a) Wisla", "b) Odra", "c) Warta" };
            QuizAnswers[1] = new string[] { "a) Warszawa", "b) Zielona Gora", "c) Malbork","d) Krakow" };
            QuizAnswers[2] = new string[] { "a) Sniezka", "b) Kasprowy Wierch", "c) Rysy", "d) Kozi Wierch", "e) Morskie Oko " };
            QuizAnswers[3] = new string[] { "a) fourty mln", "b) nine hundred thousand ", "c) more than hundred mln" };
            QuizAnswers[4] = new string[] { "a) Zbigniew Stonoga", "b) Andrzej Duda", "c) Pawel Kukiz" };

            char[] RightAnswers = { 'a', 'a', 'c', 'a', 'b', };
            char answer;
            int point=0;
            bool goodanswer = false;

            Console.WriteLine("Welcome in my quiz.Please choose a,b,c,d or e to answer the question.");
            for (int i=0;i<QuizQuestions.Length;i++)
            {

                Console.WriteLine("\n" + QuizQuestions[i]);

                for (int j = 0; j < QuizAnswers[i].Length; j++)
                {
                    Console.WriteLine("" + QuizAnswers[i][j]);

                }

                answer=Console.ReadKey(true).KeyChar;
                if (answer == RightAnswers[i])
                {
                    point++;
                    goodanswer = true;
                }
               
                }



            

            Console.WriteLine("Congratulations! You  have "+point+" good answers and "+ (QuizQuestions.Length - point)+ " wrong in "+ QuizQuestions.Length+  " questions!");
            
               
           
            Console.ReadKey();

        }
    }
}
