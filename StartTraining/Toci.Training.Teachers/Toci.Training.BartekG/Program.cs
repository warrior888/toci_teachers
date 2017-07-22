using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.BartekG
{
    class Program
    {
        static void Main(string[] args)
        {

            //QUIZ
            string[][] quizQuestions = new string[5][];
            int quizQIndexer = 0;

            string[] QuizQ =
            {
                  "1. Który typ danych jest typem logiczny?",
                 "2. Operatorem inkrementacji jest?",
                 "3. Czym jest tablica?",
                 "4. Operatorem mnożenia jest ?",
                "5. Co musi znajdować się w ifie?",

            };

            quizQuestions[quizQIndexer++] = new string[] { "a: char", "b: int", "c: long", "d: float", "e: bool", };
            quizQuestions[quizQIndexer++] = new string[] { "a: --", "b: ++", "c: ||", "d: &&", };
            quizQuestions[quizQIndexer++] = new string[] { "a: typem prostym", "b: typem pośrednim", "c: obiektem", "d: stożkiem", };
            quizQuestions[quizQIndexer++] = new string[] { "a: *", "b: /", "c: x",};
            quizQuestions[quizQIndexer++] = new string[] { "a: warunek logiczny", "b: podpis", "c: tablica", };
            char answer;
            int point = 0;
            char[] RightAnswers = { 'e', 'b', 'c', 'a', 'a', };
            char[] RightAnswers2 = { 'E', 'B', 'C', 'A', 'A', };

            Console.WriteLine("Witaj w moim quizie!");
            for (int i = 0; i < QuizQ.Length; i++)
            {

                Console.WriteLine("\n" + QuizQ[i]);

                for (int j = 0; j < quizQuestions[i].Length; j++)
                {
                    Console.WriteLine("" + quizQuestions[i][j]);

                }
               
                answer = Console.ReadKey(true).KeyChar;
                if (answer == RightAnswers[i])
                {
                    point++;

                }
                if (answer == RightAnswers2[i])
                {
                    point++;

                }

            }
            Console.WriteLine("Masz " + point + " dobrych odpowiedzi i " + (QuizQ.Length - point) + " złych w " + QuizQ.Length + " pytaniach!");


            
            // wczytywanie do tablicy
            string[] table = new string[10];
              int na = table.Length - 1;
              for (int i = 0; i < table.Length; i++)
              {
                  Console.WriteLine("Wpisz coś do indexu " + i + " na " + na);
                  table[i] = Console.ReadLine();

                  if (i==table.Length-1)
                  {
                      Console.WriteLine("Uzupełniłeś całą tablicę :)");
                  }
              }
              Console.WriteLine("Oto twoja tablica: ");
              for (int i = 0; i < table.Length; i++)
              {
                  Console.WriteLine("dla ["+i+"] = "+table[i]);




              }
             
              
              // max liczba
             int[] homework = new int[] { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };

             int max = homework[0];


             for (int i = 0; i <homework.Length ; i++)
             {
                 if (homework[i]>max)
                 {
                      max = homework[i];
                 }

             }
             Console.WriteLine(max);

             // mininmalna wartosc
             int min = homework[0];


             for (int i = 0; i < homework.Length; i++)
             {
                 if (homework[i] < min)
                 {
                     min = homework[i];
                 }

             }
             Console.WriteLine(min);

            
            // Suma wszystkich elementów
             int suma = 0;


             for (int i = 0; i < homework.Length; i++)
             {
                 suma += homework[i];

             }
             Console.WriteLine(suma);


             
            //ilosc  wystapien  

             int wystapienia = 0;
             int liczba = 78;


             for (int i = 0; i < homework.Length; i++)
             {
                 if (liczba==homework[i])
                 {
                     wystapienia ++;
                 }

             }
             Console.WriteLine("ilosc powtorzen: " + wystapienia + " dla liczby "+ liczba );
             Console.ReadKey();





          
            Console.ReadKey();
        }


        


    }
}
