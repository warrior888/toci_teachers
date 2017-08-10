using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cwiczenie_skladni_while.tablica;

namespace cwiczenie_skladni_while
{
    class Program
    {
        static void Main(string[] args)
        {
            var mytablica = new tablica55();

            int question1;
            String answear1 = "good";
            String quizAnswear1 = "in my kitchen";
            String quizAnswear2 = "Lorii";
            String quizAnswear3 = "Ronaldo";
            String quizAnswear4 = "Rodwailer";
            do
            {
                Console.WriteLine("What questions do you like?");
                question1 = int.Parse(Console.ReadLine());

                string[] quizquestions = new string[]
                {
                    "",
                    "1. Where is my money?",
                    "2. What is your name?",
                    "3. What is your surname?",
                    "4. What is favorite dog?",
                };
                
                var mylast = new last();
            }
            while (answear1 == "good" && quizAnswear1 == "in my kitchen" && quizAnswear2 == "Lorii" && quizAnswear2 == "Ronaldo" && quizAnswear4 == "Rodwailer");

            Console.ReadLine();
            }
        }
    }






