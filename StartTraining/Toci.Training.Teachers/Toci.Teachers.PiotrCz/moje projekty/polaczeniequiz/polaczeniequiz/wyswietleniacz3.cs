using System;

namespace polaczeniequiz
{
    public class wyswietlenia 
    {
        public int question1 = 1;
        public string quizquestions = "quizquestions";


        public wyswietlenia()
        {



            Console.WriteLine("What questions do you like?");

            question1 = int.Parse(Console.ReadLine());


            string[] quizquestions = new string[]
            {
                "0",
                "1. Where is my money?",
                "2. What is your name?",
                "3. What is your surname?",
                "4. What is favorite dog?",
            };


            string[][] quizAnswear = new string[quizquestions.Length][];
            quizAnswear[0] = new string[]
            {
                "0"
            };
            quizAnswear[1] = new string[]

            {
                "1",
                "in my bedroom",
                "in my living room"
            };
            quizAnswear[2] = new string[]
            {
                "Kate",
                "Marchal",
                "Piter",
                "Lorii",
                "Jamal"
            };
            quizAnswear[3] = new string[]
            {
                "Podolski",
                "Janicki",
                "Rrentowki",
                "Ronaldo"
            };
            quizAnswear[4] = new string[]
            {
                "Pers",
                "Rodwailer",
                "Entlebusher"
            };
        }
    }
}
    