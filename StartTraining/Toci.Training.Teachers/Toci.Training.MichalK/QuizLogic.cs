using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalK
{
     class QuizLogic
    {
        public static void quizLogic() //<--- Metoda stworzona w klasie QuizLogic.
        {
            Console.WriteLine();
            Console.WriteLine("Pytania do QUIZ'u");
            Console.WriteLine();

            string[] questTable = new string[]
            {
                 "1.W którym roku powstał język C?",
                 "2.W którym roku powstał PHP?",
                 "3.Jaki skrót oznacza programowanie obiektowe?",
                 "4.Który język jest ściśle powiązany z platformą .NET Framework?",
                 "5.Jakie wartości zwraca zmienna typu INT?"
            };

            string[][] answerTable = new string[questTable.Length][];
            answerTable[0] = new string[] { "a.1900", "b.1969", "c.1939", "d.2001" };
            answerTable[1] = new string[] { "a.1885", "b.2005", "c.1995" };
            answerTable[2] = new string[] { "a.OBP", "b.OOB", "c.OPO", "d.OOP" };
            answerTable[3] = new string[] { "a.Ruby", "b.C#", "c.C", "d.Pascal" };
            answerTable[4] = new string[] { "a.Liczby całkowite", "b.Liczby zmiennoprzecinkowe", "c.Wartości typu STRING" };

            string[] goodAnswers = new string[] { "b", "c", "d", "b", "a" }; //<-- tablica poprawnych odpowiedzi!!

            string answer;
            int goodAnswerPoints = 0;
            int badAnswerPoints = 0;
            int scores = 0;


            for (int i = 0; i < questTable.Length; i++)//<-- petla wyswietla tablice-tablic 
            {
                Console.WriteLine(questTable[i]);

                for (int j = 0; j < answerTable[i].Length; j++)
                {
                    Console.WriteLine(answerTable[i][j]);
                }

                Console.WriteLine();
                Console.Write("Twoja odpowiedz do pytania nr " + (i + 1) + ": ");
                answer = Console.ReadLine();

                if (answer == goodAnswers[i]) //<-- warunek jesli odpowiedzi pokrywa sie z tablcia odpowiedzi to dobra odp. jezeli nie to zla odp.
                {
                    Console.WriteLine("Dobra odpowiedz!Zdobywasz punkt!");
                    goodAnswerPoints++;
                    scores++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedz!");
                    badAnswerPoints++;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Liczba poprawnych odpowiedzi: " + goodAnswerPoints);
            Console.WriteLine("Liczba niepoprawnych odpowiedzi: " + badAnswerPoints);
            Console.WriteLine("Liczba zdobytych punktow za poprawne odpowiedzi: " + scores);
        }

    }
}
