using System;

namespace cwiczenie_skladni_while.tablica
{
    public class last
    {
        public static string last1;

        public last()
        {
            int question1;
            String answear1 = "good";
            String quizAnswear1 = "in my kitchen";
            String quizAnswear2 = "Lorii";
            String quizAnswear3 = "Ronaldo";
            String quizAnswear4 = "Rodwailer";

            string[][] quizAnswear = new string[5][];
            quizAnswear[0] = new string[]
            {
                ""
            };
            quizAnswear[1] = new string[]

            {
                "in my kitchen",
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

            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine(quizAnswear[i]);
                string answera1 = Console.ReadLine();

                for (int j = 0; j < quizAnswear[i].Length; j++)
                {
                    Console.WriteLine(quizAnswear[i][j]);

                }
                if (answera1 == "good" && quizAnswear1 == "in my kitchen" && quizAnswear2 == "Lorii" && quizAnswear2 == "Ronaldo" && quizAnswear4 == "Rodwailer") 
                {
                        Console.WriteLine("You have one point");
                    }
                    else
                    {
                        Console.WriteLine("Inncorect answera");
                    }
            }
        }
    }
    }
