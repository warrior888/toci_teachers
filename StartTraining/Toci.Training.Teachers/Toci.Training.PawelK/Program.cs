using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PawelK
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            //quiz_start
            char A = 'a';
            string[] quizQuestions =
            {
                "Qusetion 1 ?",
                "Qusetion 2 ?",
                "Qusetion 3 ?",
                "Qusetion 4 ?",
                "Qusetion 5 ?",
            };

            string[][] quizQuestionsAnswers = new string[quizQuestions.Length][];

            int quizQIndexer = 0;

            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d", "e", "f" };
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d" };
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d" };
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c", "d" };
            quizQuestionsAnswers[quizQIndexer++] = new string[] { "a", "b", "c" };

            

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);

                for (int j = 0; j < quizQuestionsAnswers[i].Length; j++)
                {
                    Console.WriteLine(Char.ConvertFromUtf32(A+j) + "." + quizQuestionsAnswers[i][j]);
                }
            }


         






            //quiz_stop

            int IndexOf(string text,char index)
            {
                int indexOf = 0;
                for(int i = 0 ;i< text.Length; i++ )
                {
                    
                    if (text[i] == index)
                    {
                        indexOf = i;
                    }
                }


                return indexOf;
            }


            Console.WriteLine(IndexOf("ala ma kota", 'a'));

            /*int maxValue (int [] tabfun )
           {
               int tmp = tabfun[0];
               for(int i = 1; i < tabfun.Length; i++)
               {

                   if ( tmp < tabfun[i])
                        tmp = tabfun[i];

               }
               return tmp;
           }

           int minValue(int[] tabfun)
           {
               int tmp = tabfun[0];
               for (int i = 1; i < tabfun.Length; i++)
               {

                   if (tmp > tabfun[i])
                       tmp = tabfun[i];

               }
               return tmp;
           }

           int sumOfAll(int[] tabfun)
           {
               int tmp = tabfun[0];
               for (int i = 1; i < tabfun.Length; i++)
               {


                       tmp += tabfun[i];

               }
               return tmp;
           }

           int count(int[] tabfun, int value)
           {
               int tmp = 0;
               for (int i = 1; i < tabfun.Length; i++)
               {
                   if (tabfun[i] == value)
                       tmp++;



               }
               return tmp;
           }



           int[] tab = new int[] { 3, 56, 3,5,78,9,78,4,3,567,8 };

          Console.WriteLine($"Najwieksza wartosc ze zbioru: {maxValue(tab)}");
          Console.WriteLine($"Najmniejsza wartosc ze zbioru: {minValue(tab)}");
          Console.WriteLine($"Suma elementow zbioru: {sumOfAll(tab)}");
          Console.WriteLine("Podaj wartosc: ");
          string userInput = Console.ReadLine();
          int userInputNumber = 0;
          int.TryParse(userInput, out userInputNumber);
          Console.WriteLine($"Ilosc wystąpien podanego elementu: {count(tab,userInputNumber)}");

           string [] text = new string[5];

           for (int i = 0; i < text.Length; i++)
           {
               text[i] = Console.ReadLine();
           }


           for (int i = 0; i < text.Length;i++)
           {
               Console.WriteLine(i + 1 + ". " + text[i]);
           }
           //saper_start
           /*const int mine = -1;

           int [,] createMinefield (int x, int y, int bombsQuantity)
           {
               int[,] minefield = new int[x, y];

               int randomX = 0;
               int randomY = 0;

               Random rnd = new Random(DateTime.Now.Millisecond);
               while (bombsQuantity > 0)
               {
                   randomX = rnd.Next(0, x - 1);
                   randomY = rnd.Next(0, y - 1);

                   if (minefield[randomX, randomY] != mine)
                   {
                       minefield[randomX, randomY] = mine;

                       for (int k = -1; k < 2; k++)
                           for (int l = -1; l < 2; l++)
                           {
                               if ((randomX + l) < 0 || (randomY + k) < 0) continue; //wyjdz bo krawedz
                               if ((randomX + l) > minefield.GetLength(0) - 1 || (randomY + k) > minefield.GetLength(1) - 1) continue; //wyjdz bo krawedz

                               if (minefield[randomX + l, randomY + k] == mine) continue; //wyjdz bo mina
                               minefield[randomX + l, randomY + k] += 1; //zwieksz o 1
                           }

                      bombsQuantity--;
                   }
               }




           return minefield;
           }




           void print (int [,] minefield)
           {
               for(int i = 0; i < minefield.GetLength(0) - 1; i++)
               {
                   for(int j = 0; j < minefield.GetLength(1) - 1; j++)
                   {
                       Console.Write(" {0} ", minefield[i, j]);
                   }
                   Console.WriteLine("");
               }
           }


           int xCord, yCord,minesQuantity;
           Console.WriteLine("Podaj wielkość pola minowego(W postaci x,y ):");
           string corrdinates = Console.ReadLine();
           int.TryParse(corrdinates.Substring(0, 1),out xCord);
           int.TryParse(corrdinates.Substring(2, 1), out yCord);
           Console.WriteLine("Podaj ilosc min:");
           string minesQ = Console.ReadLine();
           int.TryParse(minesQ, out minesQuantity);


               print(createMinefield(xCord, yCord, minesQuantity));
          //saper_end 
           */


            Console.ReadKey();
        }
    }
}
