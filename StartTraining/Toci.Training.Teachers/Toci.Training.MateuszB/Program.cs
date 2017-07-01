using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MateuszB
{
    class Program
    {
        static void Main(string[] args)
        {
            int quizAnswersIndex = 0;
            string answer = "";
            int countWrong = 0;
            int countCorrect = 0;

            string[] quizQuestions =
            {
                "W którym roku powstał klub?",
                "Jak nazywa się obecny stadion Liverpoolu?",
                "Ile mistrzostw mają na koncie The Reds?",
                "Kiedy ostatni raz zdobyli Ligę Mistrzów?",
                "Ile lat Steven Gerrard spędził w Liverpoolu",
                "I na koniec kto jest obecnym trenerem The Reds?",
            };

            string[][] quizAnswers = new string[quizQuestions.Length][];

            quizAnswers[quizAnswersIndex++] = new string[] { "a) 1905", "b) 1892", "c) 1899" };
            quizAnswers[quizAnswersIndex++] = new string[] { "a) Upton Park", "b) Stamford Bridge", "c) Anfield" };
            quizAnswers[quizAnswersIndex++] = new string[] { "a) 19", "b) 18", "c) 20" };
            quizAnswers[quizAnswersIndex++] = new string[] { "a) 1999", "b) 2007", "c) 2005" };
            quizAnswers[quizAnswersIndex++] = new string[] { "a) 17", "b) 20", "c) 13" };
            quizAnswers[quizAnswersIndex++] = new string[] { "a) Brendan Rogers", "b) Jurgen Klopp", "c) Jose Mourinho" };

            string[] correctAnswers = { "b", "c", "b", "c", "a", "b" };

            Console.WriteLine("Witaj w kursie wiedzy na temat Liverpool'u :)");
            Console.WriteLine("Odpowiadasz poprzez wybranie a, b lub c");
            Console.WriteLine("Aby zacząć wciśnij ENTER");
            Console.WriteLine("");

            Console.ReadKey();

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);
                for (int j = 0; j < quizAnswers[i].Length; j++)
                {
                    Console.WriteLine(quizAnswers[i][j]);
                }
                Console.WriteLine("");
                Console.Write("Twoja odpowiedź: ");  answer = Console.ReadLine();
                Console.WriteLine("");

                while (answer != correctAnswers[i])
                {
                    countWrong++;
                    Console.WriteLine("Niepoprawna odpowiedź! Spróbuj ponownie.");
                    Console.WriteLine("");
                    Console.Write("Twoja odpowiedź: "); answer = Console.ReadLine();
                }
                countCorrect++;
                Console.WriteLine("Brawo! Poprawna odpowiedź.");
                Console.WriteLine("");
                Console.WriteLine("Wciśnij dowolny klawisz aby przejść do następnego pytania");
                Console.ReadKey();
                Console.WriteLine("");
                Console.Clear();
            }
            Console.WriteLine("Twój wynik to: " + countCorrect + " na " + quizAnswers.Length + " możliwych");
            Console.WriteLine("Zle odpowiedzi: " + countWrong);
            Console.WriteLine("Dobre odpowiedzi: " + countCorrect);

            Console.ReadKey();


            
            
            
            /*int[] numValues = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8};
            int max = numValues[0], min = numValues[0], sum = 0, number = numValues[4], count = 0; 

            for (int i = 0; i < numValues.Length; i++)
            {
                if (numValues[i] >= max)
                {
                    max = numValues[i];
                }
                if (numValues[i] <= min)
                {
                    min = numValues[i];
                }
                sum += numValues[i];
                if (numValues[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine("Wartość maksymalna: " + max);
            Console.WriteLine("Wartosc minimalna: " + min);
            Console.WriteLine("Suma: " + sum);
            Console.WriteLine("Liczba wystapien 78: " + count);

            Console.ReadKey();
            
            /* string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Podaj array[" + i + "] = ");
                array[i] = Console.ReadLine();
                if (i == array.Length - 1)
                {
                    Console.WriteLine("Wprowadziles wszystkie wartosci. Wcisnij ENTER aby je teraz wyświetlić");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Oto wprowadzone wartosci: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            Console.ReadKey();*/
        }
    }
}
