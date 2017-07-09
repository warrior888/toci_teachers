using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // zad 1&2&3. Max wartosc/ Min wartosc. Suma liczb z tablicy
            int[] parameters = { 2, 3, 5, 4, 5, 2, 1, 3, 6, 7, 9, 11, 24, 5, 12, 12, 14, 3 };
            int length = parameters.Length;
            int resultMax = int.MinValue, resultMin = int.MaxValue, sumOfNumber = 0;


            for (int i = 0; i < length; i++)
            {

                if (parameters[i] > resultMax)
                {
                    resultMax = parameters[i];
                }

                if (parameters[i ] < resultMin)
                {
                    resultMin = parameters[i];

                }

                sumOfNumber += parameters[i];


            }

            //zad 4.
            Console.WriteLine("Podaj liczbe do sprawdzenia: ");
            string par = Console.ReadLine();

            int number = Convert.ToInt32(par);

            int Occurrence = 0;

            for (int i = 0; i < length; i++)
            {
                if (number == parameters[i])
                {
                    Occurrence++;
                }

            }
            // zapytanie i wpisanie do tablicy wartosic podanych od użytkownika.

            Console.WriteLine("Podaj ilosc liczb do wpisania do tablicy: ");

            string lenghtOfTable = Console.ReadLine();

            

            int wow = Convert.ToInt32(lenghtOfTable);

            //int.TryParse(lenghtOfTable, out lenghtOfNumber);

            int[] values;

            values= new int[wow];

            for (int j = 0; j < values.Length; j++)
            {
                Console.WriteLine("Podaj liczbe: {0}", j + 1);
                values[j] = Convert.ToInt32(Console.ReadLine());
                




            }

            Console.WriteLine("Max to: {0}, Min to: {1}, Wystapienia: {2}, Suma to: {3}", resultMax, resultMin,Occurrence,sumOfNumber);
             
            

            // HomeWork Training 2 |ex. 1

            string string1 = "Nie jak talala";
            string example = "jak";
            




            /*

            for (int i = 0; i < string1.Length - 1 - example.Length - 1; i++)
            {
                for (int j = string1.Length - 1 - example.Length; j >= example.Length - 1; j--)
                {
                    result = string1.Substring(i, j);

                    if (String.Equals(example, result))
                    {
                        Console.WriteLine(i + "  aaaaa znalazlem");
                        break;
                    }
                }
            }
            */

                    string result2 = "";
                    int f = example.Length;
                    for (int k = 0; k < string1.Length - example.Length; k++)
                    {
                        result2 = string1.Substring(k, f);

                        if (String.Equals(example, result2))
                        {
                           Console.WriteLine("IndexOf to: "+k);
                           break;

                        }
                    }

            // Quiz zad
            string[] quizQuestions =
            {
                "Brazylia pod wodzą Dungi odniosła już 10 kolejnych zwycięstw. Z kim wygrała ostatni mecz?",
                "FC Barcelona po raz drugi w historii wywalczyła potrójną koronę. Kiedy uczyniła to pierwszy raz?",
                "Która z wymienionych reprezentacji nigdy nie wygrała Copa America?",
                "Ile występów w reprezentacji Polski A ma Łukasz Szukała?",
                "W którym z krajów w minionym sezonie nie grał Łukasz Gikiewicz?",
            };

            string[][] quizQuestionsAnswers = new string[quizQuestions.Length][];

            int quizQIndexer = 0;

            quizQuestionsAnswers[quizQIndexer++] = new string[] { "z Jamajką", "z Kostaryką", "z Hondurasem"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "w 2006 roku", "w 2009 roku", "w 2011 roku"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "Peru", "Kolumbia", "Chile"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "8", "10", "11"};
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "Cypr", "Bułgaria", "Rumunia" };


            char[] quizAnswers= {'c','b','a','c','c'};
            char answerTheUser;
            int correctAnswer = 0;
            int inCorrectAnswer = 0;


            //Console.WriteLine(quizQuestions);

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);

                for (int j = 0; j < quizQuestionsAnswers[i].Length; j++)
                {
                    Console.WriteLine(quizQuestionsAnswers[i][j]);
                }

                Console.WriteLine("Podaj odpowiedz : ");
                answerTheUser =Console.ReadKey().KeyChar;
                Console.ReadLine();
                    if (quizAnswers[i] == answerTheUser)
                    {
                        correctAnswer++;
                    }
                    else
                    {
                        inCorrectAnswer++;
                    }

                Console.WriteLine();

            }
                Console.WriteLine("Liczba poprawnych odpowiedzi to: "+correctAnswer);
                Console.WriteLine("Liczba blednych odpowiedzi to: "+inCorrectAnswer);



        }
    }
}
