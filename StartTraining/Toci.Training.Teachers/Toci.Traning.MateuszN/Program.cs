using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Traning.MateuszN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quizQuestions = new string[]
            {
                "ile penisow ma paweł",
                "ile penisow ma kamil",
                "ile penisow ma adam",
                "ile penisow mam ja"

            };

            string[][] quizQuestionsAnswers = new string[4][];
            quizQuestionsAnswers[0]= new string[]{"a", "b", "c", "d"};
            quizQuestionsAnswers[1]= new string[]{"a", "b", "c",};
            quizQuestionsAnswers[2]= new string[]{"a", "b", };
            quizQuestionsAnswers[3]= new string[]{"a", "b", };

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine(quizQuestions[i]);

                for (int j = 0; j < quizQuestionsAnswers[i].Length; j++)
                {
                    Console.WriteLine(quizQuestionsAnswers[i][j]);
                }
            }









            int[] dupa = new int[] {3,5,6,32,3,523,42,42,422,1234};

            int temp;

           

            for (int i = 0; i < dupa.Length; i++)
            {
                for (int j = 0; j < dupa.Length; j++)
                {
                    if (i != j)
                    {
                        if (dupa[i] < dupa[j])
                        {
                            temp = dupa[i];
                            dupa[i] = dupa[j];
                            dupa[j] = temp;
                        }
                    
                    }
                       
                }
            }


            int max = int.MinValue;
          
           

           







            
            Console.ReadKey();
        }
    }
}
