using System;

namespace cwiczenie_skladni_while.tablica
{
    public class tablica55
    {
        public static string tablica1;

        public tablica55()
        {
            string[] quizquestions = new string[]
            {
                "",
                "1. Where is my money?",
                "2. What is your name?",
                "3. What is your surname?",
                "4. What is favorite dog?",
            };
            for (int i = 0;i < quizquestions.Length;i++)
            {
                Console.WriteLine(quizquestions[i]);
            }

        }
    }
}



        


