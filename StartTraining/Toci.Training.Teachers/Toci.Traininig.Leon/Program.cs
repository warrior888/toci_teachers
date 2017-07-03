using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Treining.Leon
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            string text = "TO CI dopiero";

            Byte[] encodeBytes = ascii.GetBytes(text);
            Console.WriteLine(text);
            Console.WriteLine("The encoding: ");

            int k = 0;
            foreach (byte b in encodeBytes)
            {
                byte a = 0; // zmienilem zmienna INT na BYTE
                if (b >= 97 && b <= 122)
                {
                    a = b;
                    a -= 32;
                    //a = Convert.ToByte(a); // to juz nie potrzebne
                }
                else
                {
                    a = b;
                }
                Console.WriteLine("Mala litera: [{0}]", b);
                Console.WriteLine("Duza litera: [{0}]", a);
                encodeBytes[k] = a; // dzieki Kafar!!!!
                k++;
                //string decodestring = ascii.GetString(a); // to w ogole nie jest potrzebne
            }
            Console.WriteLine();

            string decodeString = ascii.GetString(encodeBytes);
            Console.WriteLine("Decodeing: ");
            Console.WriteLine(decodeString);

            // zadanie z tablica - wpisac dane z forem

            int[] TablicaFor = new int[10];

            Console.WriteLine(TablicaFor.Length);

            for (int i = 0; i < TablicaFor.Length; i++)
            {
                Console.WriteLine("Podaj numer dla tablicy {0}", i + 1);
                string Input = Console.ReadLine();
                int InputToInt = 0;
                int.TryParse(Input, out InputToInt);
                TablicaFor[i] = InputToInt;
            }

            for (int i = 0; i < TablicaFor.Length; i++)
            {
                Console.WriteLine("Tablica od {0} ma numer {1}", i + 1, TablicaFor[i]);
            }

            // summa wszystkich elementow

            int Summa = 0;
            for (int i = 0; i < TablicaFor.Length; i++)
            {
                Summa += TablicaFor[i];
            }
            Console.WriteLine(Summa);

            // znalezc maksymalna wartosc

            int NajwiekszaLiczba = 0;
            for (int i = 0; i < TablicaFor.Length; i++)
            {
                if (NajwiekszaLiczba < TablicaFor[i])
                {
                    NajwiekszaLiczba = TablicaFor[i];
                }
            }
            Console.WriteLine(NajwiekszaLiczba);

            // znalezc minimalna wartosc

            int NajmniejszaLiczba = TablicaFor[0];
            for (int i = 0; i < TablicaFor.Length; i++)
            {
                if (NajmniejszaLiczba > TablicaFor[i])
                {
                    NajmniejszaLiczba = TablicaFor[i];
                }
            }
            Console.WriteLine(NajmniejszaLiczba);

            // ilosc wystapien

            Console.WriteLine("Podaj jaka liczbe bedziemy sprawdzac: ");
            string FromUser = Console.ReadLine();
            int IntFromUser = 0;
            int.TryParse(FromUser, out IntFromUser);
            int occurence = 0;

            for (int i = 0; i < TablicaFor.Length; i++)
            {
                if (IntFromUser == TablicaFor[i])
                {
                    occurence++;
                }
            }
            Console.WriteLine("Liczba {0} wystepuje w tej tablicy {1} razy", IntFromUser, occurence);

            // sortowanie babelkowe

            int[] BabbleSortTable = new int[] { 9, 2, 4, 7, 36, 6, 5 };

            foreach (int elementarny in BabbleSortTable)
            {
                Console.WriteLine(elementarny);
            }

            int ToReplace = 0;
            for (int i = 0; i < BabbleSortTable.Length; i++)
            {
                for (int j = 0; j < BabbleSortTable.Length; j++)
                {
                    if (BabbleSortTable[i] < BabbleSortTable[j])
                    {
                        ToReplace = BabbleSortTable[i];
                        BabbleSortTable[i] = BabbleSortTable[j];
                        BabbleSortTable[j] = ToReplace;
                    }
                }
            }

            Console.WriteLine("nowa tablica");
            foreach (int elementarny in BabbleSortTable)
            {
                Console.WriteLine(elementarny);
            }
            
            // DRUGI TYDZIEN
            // check for index

            

            Console.WriteLine(IndedexOf("latem chce sie na morze", "sie"));
            
            // Quize 

            string[] QuizeQuestions =
            {
                "Which of the below is a loop?",
                "Which of the below is a variable?",
                "Which of the below is a condition?",
                "Which of the below starts a block code?",
                "Which of the below is an array indexer?",
            };

            string[][] QuizeAnswers = new string[QuizeQuestions.Length][];

            QuizeAnswers[0] = new string[] {"  a) for", "  b) int", "  c) class", "  d) Console" };
            QuizeAnswers[1] = new string[] {"  a) string", "  b) int Number", "  c) 1;", "  d) foreache" };
            QuizeAnswers[2] = new string[] {"  a) Console.WriteLine('...');", "  b) [1]", "  c) 1 < 2", "  d) i++", "  e) return" };
            QuizeAnswers[3] = new string[] {"  a) ||", "  b) [", "  c) (", "  d) {", "  e) ." };
            QuizeAnswers[4] = new string[] {"  a) string[1]", "  b) string(1)", "  c) string{1}" };

            string[] UserAnswers = new string[QuizeQuestions.Length];

            string[] CorrectAnswers = {"a", "b", "c", "d", "a"};

            int score = 100;
            int wrongAnswers = 0;

            Console.WriteLine("PREPARE YOURSELF FOR A QUIZE!");

            for(int i = 0; i < QuizeQuestions.Length; i++)
            {
                Console.WriteLine(QuizeQuestions[i]);

                for(int j = 0; j < QuizeAnswers[i].Length; j++)
                {
                    Console.WriteLine(QuizeAnswers[i][j]);
                }
                do
                {
                    Console.Write("Please put your answer here: ");
                    UserAnswers[i] = Console.ReadLine();
                    if (UserAnswers[i] != CorrectAnswers[i])
                    {
                        score -= 10;
                        wrongAnswers++;
                    }
                }
                while (UserAnswers[i] != CorrectAnswers[i]);
            }

            Console.WriteLine("Your score is " + score + "%. You have " + wrongAnswers + " uncorrect answers.");

            Console.ReadLine();
        }

        // index of 

        public static string IndedexOf(string candidate, string needle)
        {
            string result = "";
            for (int i = 0; i < candidate.Length; i++)
            {
                if ((needle.Length + i) < candidate.Length && candidate.Substring(i, needle.Length) == needle)
                {
                    result = Convert.ToString(i);
                    break;
                }
            }
            return result;
        }
    }
}
