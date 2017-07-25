using System;
namespace Toci.Training.PatrykK
{
    class Program
    {
        static void Main()
        {
            string myInputString = "szkoli";
            int count = 0;
            //  ZADANIE 1. PART 1 ROZBICIE NA TABLICE
            string myStringForCheck = "Bartek szkoli programistów.";
            string[] separators = { " ", ".", ",", ":", ";" };

            string[] separatedString = myStringForCheck.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string simplestring in separatedString)
            {
                Console.WriteLine(simplestring.ToLower());
            }

            for (int m = 0; m < separatedString.Length; m++)
            {
                for (int n = 0; n < myInputString.Length; n++)
                {
                    if (separatedString[m] == myInputString)
                    {
                        Console.WriteLine(myStringForCheck.IndexOf("s"));
                        Console.WriteLine(myStringForCheck.IndexOf("z"));
                        Console.WriteLine(myStringForCheck.IndexOf("k"));
                        Console.WriteLine(myStringForCheck.IndexOf("o"));
                        Console.WriteLine(myStringForCheck.IndexOf("l"));
                        Console.WriteLine(myStringForCheck.IndexOf("i"));
                    }
                }
            }
            /*for (int k = 0; k < separatedString[k].Length; k++)
            {
                Console.WriteLine(separatedString[k].IndexOf());
            }*/

            //  USUNIĘCIE PUSTYCH MIEJSC
            //string connectedString = myStringForCheck.Substring(" ");



            string searching = myStringForCheck;
            //string[] foundString;

            // ZADANIE - WYŚWIETLENIE POZYCJI W TABLICY
            int index = 0;
            for (int i = 0; i < myInputString.Length; i++)
            {
                for (int j = 0; j < myStringForCheck.Length; j++)
                {
                    if (myInputString[i] == myStringForCheck[j])  //&& myInputString[i+1]!=myStringForCheck[j+1]) 
                    {
                        Console.Write($"For {myStringForCheck[j]}, postion in '{myStringForCheck}' is {j}.");
                        Console.WriteLine();
                    }

                }

            }

            Console.ReadKey();




            // ZADANIE 2 TEST ABCDEF
            // DANE 
            int pointsInSurvey = 0;
            string yourAnswer;

            //MACIERZ PYTAŃ
            string[] surveyQuestions = new string[]
            {
                "Which of the following does not store a sign?",
                "Which of the following is an 8-byte Integer?",
                "Which of the following is NOT an Integer?",
                "Which of the following is the correct size of a Decimal datatype?",
                "What is the size of a Decimal?",
                "Which of the following is the correct default value of a Boolean type?"
            };

            //MACIERZ WYBIERANIA ODPOWIEDZI
            string[][] answersToChoose = new string[surveyQuestions.Length][];
            answersToChoose[0] = new[] { "a. Short", "b. Integer", "c. Long", "d. Byte", "e. Single", "f. None" };
            answersToChoose[1] = new[] { "a. Char", "b. Long", "c. Short", "d. Byte", "e. Integer", "f. None" };
            answersToChoose[2] = new[] { "a. Char", "b. Byte", "c. Integer", "d. Long", "e. Short", "f. None" };
            answersToChoose[3] = new[] { "a. 4 bytes", "b. 8 bytes", "c. 16 bytes", "d. 32 bytes", "e. none", "f. 1 megabyte" };
            answersToChoose[4] = new[] { "a. 4 bytes", "b. 8 bytes", "c. 16 bytes", "d. 32 bytes", "e. 64 bytes", "f. 1 megabyte" };
            answersToChoose[5] = new[] { "a. 0", "b. 1", "c. True", "d. False", "e. -1", "f. null" };

            //MACIERZ ODPOWIEDZI
            string[] rightAnswer = new string[]
                {"d", "b", "a", "c", "c", "d"};

            //PĘTLE 
            for (int i = 0; i < surveyQuestions.Length; i++)
            {
                Console.WriteLine(surveyQuestions[i]);

                for (int j = 0; j < answersToChoose[i].Length; j++)
                {
                    Console.WriteLine(answersToChoose[i][j]);
                }
                yourAnswer = Console.ReadLine(); Console.Write(".");
                {
                    if (yourAnswer == rightAnswer[i])
                    {
                        pointsInSurvey = pointsInSurvey + 1;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
            Console.WriteLine($"Twój wynik końcowy to: {pointsInSurvey}/6  punktów.");
            Console.ReadLine();
        }
    
    }
}
