using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalW
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------------------------------------------------------------------
             //Zadanie 0 : Zamiana małych liter na duże
              
             Console.WriteLine("Podaj słowo : ");

             string InputWord = Console.ReadLine();

             ASCIIEncoding ascii = new ASCIIEncoding();

             Byte[] ASCIIValues = ascii.GetBytes(InputWord);
            int One = 0;
            foreach (byte Number in ASCIIValues)
            {
                byte a = 0; // zmiana zmiennej int na byte
                if (Number >= 97 && Number <= 122)
                {
                    a = Number;
                    a -= 32;
                }
                else
                {
                    a = Number;
                }
                //Console.WriteLine("Mala litera: [{0}]", Number);
                //Console.WriteLine("Duza litera: [{0}]", a);
                ASCIIValues[One] = a;
                One ++;
            }
            String decoded = ascii.GetString(ASCIIValues);
                     Console.WriteLine("Decoded string : " + decoded);

                    
             Console.ReadKey();   */

            /* ---------------------------------------------------------------------------------------------
             * Zad 1 : Tablica i pokazanie jej elementów
             *
             * Console.Write("Ilu elementowa ma być Twoja tablica : ");
             string InputUser = Console.ReadLine();
             int UserInputNumber = 0;
             int.TryParse(InputUser, out UserInputNumber);
             int[] example = new int[UserInputNumber];

             string[] Table = new string[UserInputNumber];
             int number = Table.Length;

             for (int i = 0; i < number; i++)
             {
                 Console.Write("\nPodaj element nr " + (i + 1) + ": ");
                 Table[i] = Console.ReadLine();

                 if (number - 1 == i)
                 {
                     Console.WriteLine("\nUzupełniłeś swoją tablicę !");
                 }
             }
             Console.WriteLine("\nElementy Twojej tablicy :");

             for (int i = 0; i < number; i++)
             {
                 Console.Write(" " + (i + 1) + "." + Table[i]);
             }
             Console.ReadKey();  */

            /*------------------------------------------------------------------------------------------------
int[] Tablle = new int[11];
Tablle[0] = 3;
Tablle[1] = 56;
Tablle[2] = 3;
Tablle[3] = 5;
Tablle[4] = 78;
Tablle[5] = 9;
Tablle[6] = 78;
Tablle[7] = 4;
Tablle[8] = 3;
Tablle[9] = 567;
Tablle[10] = 8; 

//int[] Tablle = new int[] {3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8};   << Można też tak w 1 linii

// 1. Pokazanie najwyższej wartości z tej tabeli :

//  int Max = Tablle.Max();  << Metoda szybka z funkcji wbudowanej

int Biggest = Tablle[0];
for (int i = 1; i < Tablle.Length; i++)
{
    if (Biggest < Tablle[i])
    {
        Biggest = Tablle[i];

    }
}
Console.WriteLine("Najwyższa wartość z tej tablicy to : " + Biggest);

//----------------------------------------------------------------------------------------------------------
// 2. Pokazanie najniższej wartości z tej tabeli :

//  int Min = Tablle.Min(); << Metoda szybka z funkcji wbudowanej

int Smallest = Tablle[0];

for (int i = 1; i < Tablle.Length; i++)
{
    if (Smallest > Tablle[i])
    {
        Smallest = Tablle[i];
    }
}

Console.WriteLine("Najmniejsza wartość z tej tablicy to : " + Smallest);

//-------------------------------------------------------------------------------------------
// 3. Pokazanie sumy wartości z tablicy :

// int Total = Tablle.Sum();  << Metoda szybka z funkcji wbudowanej

int Total = 0;

for (int i = 0; i < Tablle.Length; i++)
{
    Total += Tablle[i];
}

Console.WriteLine("Suma wartości z tej tablicy to : " + Total);

// ---------------------------------------------------------------------
// 4. Pokazanie ilości wystąpień danego elementu :

Console.WriteLine("\nElementy Twojej tablicy :");

for (int i = 0; i < Tablle.Length; i++)
{
    Console.Write(" " + (i + 1) + "." + Tablle[i]);
}
Console.Write("\nIlość którego elementu pokazać : ");
string UserNumber = Console.ReadLine();
int NumberOfAppearances = 0;
int.TryParse(UserNumber, out NumberOfAppearances);

int Result = 0;

for (int i = 0; i < Tablle.Length; i++)
{
   if (NumberOfAppearances == Tablle[i])
    {
        Result ++;
    }
}
Console.WriteLine("Element " + UserNumber + " pojawił się : " + Result + " raz(y)");

Console.ReadKey(); */
            /*------------------------------------------------------------------------------------------------------------------
                        // Zadania z dnia 01.07 2 lekcja

                        int[] content = new int[] {4, 56, 3, 2, 6, 8, 78, 54, 756, 78, 54, 3, 2, 1, 6};
                        int temp;
                        for (int i = 0; i < content.Length; i++)
                        {
                            for (int j = 0; j < content.Length; j++)
                            {
                                if (i != j)
                                {
                                    if (content[i] < content[j])
                                    {
                                        temp = content[i];
                                        content[i] = content[j];
                                        content[j] = temp;
                                    }
                                }    
                            }
                        } */

            /* // Zadania domowe nr 1 (Lekcja nr 2 01.07.2017)  Podać pozycję słowa ze stringa
             string Lesson2 = "Bartek szkoli programistów";

             Console.WriteLine(Lesson2);
             Console.WriteLine("Który wyraz Cię interesuje : ");
             string UserAnswerToCut = Console.ReadLine();


             char CharOfUserAnswerToCuT = UserAnswerToCut[0];
             char CharOfUserAnswerToCuT2 = UserAnswerToCut[1];

             int NumberStartOf = 0;

             for (int i = 0; i < Lesson2.Length; i++)
             {
                 if (CharOfUserAnswerToCuT == Lesson2[i] && CharOfUserAnswerToCuT2 == Lesson2[i+1])
                 {
                    NumberStartOf = i + 1;  // Dziwnie, żeby na pozycji 0 się zaczynało ;)
                 }
             }
             Console.WriteLine("Wybrane przez Ciebie słowo zaczyna się na pozycji nr : " + NumberStartOf);
             Console.ReadKey(); */

            // -----------------------------------------------------------------------------------------------
            // Zadania domowe nr 2 (Lekcja nr 2 01.07.2017) Quiz

            string[] QuizQuestion = new string[]
            {
                "1. Kto stworzył 'Gwiezdne Wojny ?",
                "2. W którym roku odbyła się premiera 'Star Wars Episode IV: A New Hope' ?",
                "3. Najbardziej znany droid naprawczy z serii 'Star Wars' to ?",
                "4. Kto był odpowiedzialny za utrzymywanie pokoju w Republice Galaktycznej ?",
                "5. Najbardziej znany czarny charakter ze świata 'Star Wars' to ?"
            };

            string[][] QuizQuestionAnswer = new string[QuizQuestion.Length][];

            int QuizIndexer = 0;
            int PlayerScore = 0;
            int GoodAnswer = 0;
            int BadAnswer = 0;
            char AnswerQuiz;
            char[] RightAnswer = new char[] {'a', 'b', 'c', 'c', 'b'};

            QuizQuestionAnswer[QuizIndexer++] = new string[] {"a) George Lucas", "b) Steven Spielberg", "c) Tom Hanks", "d) Christopher Nolan"};
            QuizQuestionAnswer[QuizIndexer++] = new string[] {"a) 1998", "b) 1977", "c) 2001", "d) 1971"};
            QuizQuestionAnswer[QuizIndexer++] = new string[] {"a) R4-P17", "b) C-3PO", "c) R2-D2", "d) Jabba the Hutt"};
            QuizQuestionAnswer[QuizIndexer++] = new string[] {"a) Ewoki", "b) Sithowie", "c) Zakon rycerzy Jedi", "d) Huttowie"};
            QuizQuestionAnswer[QuizIndexer++] = new string[] {"a) Mace Windu", "b) Darth Vader", "c) Han Solo", "d) Luke Skywalker"};

            for (int i = 0; i < QuizQuestion.Length; i++)
            {
                Console.WriteLine("\n" + QuizQuestion[i] + "\n");

                for (int j = 0; j < QuizQuestionAnswer[i].Length; j++)
                {
                    Console.WriteLine(QuizQuestionAnswer[i][j]);
                }
                
                    Console.Write("\nTwoja odpowiedź : ");
                    AnswerQuiz = Console.ReadKey().KeyChar;

                if (AnswerQuiz == RightAnswer[i])
                    {
                        PlayerScore++;
                        GoodAnswer++;
                    }
                        else
                    {
                        BadAnswer++;
                    }
                
                
                Console.WriteLine("");
                
            }
            Console.WriteLine("");
            Console.WriteLine("Twój wynik : " + PlayerScore + " punktów");
            Console.WriteLine("Poprawne odpowiedzi : " + GoodAnswer);
            Console.WriteLine("Błędne odpowiedzi : " + BadAnswer);
            Console.ReadKey();
        }
    }
}
