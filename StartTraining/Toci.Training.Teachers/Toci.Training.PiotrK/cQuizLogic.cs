using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PiotrK
{
    class cQuizLogic
    {
        public static void quiz()
        {
            Console.WriteLine("\nZadanie z quizem\n");
            string[] quizQuestions = new string[]
             {
                "W którym roku miała miejsce bitwa pod Kłuszynem?",
                "Stanisław Żółkiewski był:",
                "Nazwa \"Dymitriady\" pochodzi od:",
                "Lata 1598 - 1613 w historii Rosji określa się jako"

             };

            // tablica pomocnicza z dobrymi odpowiedziami
            string[] arrayOfGoodAnswers = new string[] { "b", "a", "c", "b" };

            //bool warunek = true; // czy odpowiedź prawidłowa
            int goodAnswers, badAnswers; // liczniki dobrych i złych odpowiedzi
            goodAnswers = badAnswers = 0;
            string answer = "";

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
            }

            string[][] quizQuestionsAnswers = new string[5][];

            quizQuestionsAnswers[0] = new string[] { "a) 1410", "b) 1610", "c) 1772", "d) 1921", "e) 1939", "f) 1945" };
            quizQuestionsAnswers[1] = new string[] { "a) hetmanem", "b) królem", "c) biskupem", "d) pisarzem" };
            quizQuestionsAnswers[2] = new string[] { "a) Dymitra Dońskiego", "b) Dymitra Suzdalskiego", "c) Dymitra Samozwańca I" };
            quizQuestionsAnswers[3] = new string[] { "a) Złoty Wiek", "b) Wielką Smutę", "c) Augustjadę" };

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine("Pytanie: {0}", quizQuestions[i]);
                Console.WriteLine("Lista odpowiedzi:");

                for (int j = 0; j < quizQuestionsAnswers[i].Length; j++)
                {
                    Console.WriteLine(quizQuestionsAnswers[i][j]);
                }

                Console.WriteLine("Wskaż poprawną odpowiedź");
                answer = Console.ReadKey().KeyChar.ToString().ToLower();
                //Console.WriteLine("\n{0}", answer);
                if (answer == arrayOfGoodAnswers[i].ToString())
                {
                    Console.WriteLine("\nOdpowiedź poprawna\n");
                    goodAnswers++;
                }
                else
                {
                    Console.WriteLine("\nOdpowiedź niepoprawna\n");
                    badAnswers++;
                    i--;
                }
            }


            for (int i = 0; i < 10; i++)
                Console.Write("***");
            Console.WriteLine("Podsumowanie:");
            Console.WriteLine("Liczba prób odpowiedzi poprawnych:\t{0}" +
                "\nLiczba prób odpowiedzi niepoprawnych:\t{1}", goodAnswers, badAnswers);
        }
    }
}
