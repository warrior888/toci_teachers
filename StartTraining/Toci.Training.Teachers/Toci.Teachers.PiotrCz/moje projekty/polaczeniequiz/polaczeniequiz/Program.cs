using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polaczeniequiz
{
    class Program
    {
        static void Main(string[] args)
        {

            //wykonuje sue juz wpiisanie numeru pytania nastepnie wpisujemy odpowiedz ale przechodzi nam po calym
            // stringu np po stringu quizAnswear1 do poki nie wpiszesz tego wiersza o ktory pyta

            int question1;
            
            string answear1 = "good";
            string quizAnswear1 = "1";
            string quizAnswear2 = "Lorii";
            string quizAnswear4 = "Ronaldo";
            string quizAnswear5 = "Rodwailer";

          


            do
            {
                Console.WriteLine("What questions do you like?");
                question1 = int.Parse(Console.ReadLine());


                string[] quizquestions = new string[]
                {
                    "0",
                    "1. Where is my money?",
                    "2. What is your name?",
                    "3. What is your surname?",
                    "4. What is favorite dog?",
                };


                string[][] quizAnswear = new string[quizquestions.Length][];
                quizAnswear[0] = new string[]
                {
                    "0"
                };
                quizAnswear[1] = new string[]

                {
                    "1",
                    "in my bedroom",
                    "in my living room"
                };
                quizAnswear[2] = new string[]
                {
                    "Kate",
                    "Marchal",
                    "Piter",
                    "Lorii",
                    "Jamal"
                };
                quizAnswear[3] = new string[]
                {
                    "Podolski",
                    "Janicki",
                    "Rrentowki",
                    "Ronaldo"
                };
                quizAnswear[4] = new string[]
                {
                    "Pers",
                    "Rodwailer",
                    "Entlebusher"
                };


                for (int i = 0; i < quizquestions.Length; i++)

                    if (question1 == i)

                    {

                        Console.WriteLine(quizquestions[i]);
                        string goodanswear1 = Console.ReadLine();



                        for (int j = 0; j < goodanswear1.Length; j++)

                            if (quizAnswear[j].Length == goodanswear1.Length)

                            {
                                
                                Console.WriteLine("You have one point");
                            }
                            else if (quizAnswear[j].Length != goodanswear1.Length)
                            {
                                Console.WriteLine("Inncorect answear, please try agin");
                                string exelent = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You have five point");
                            }
                    }

               

            } while (answear1 == "good" || quizAnswear1 == "1" || quizAnswear2 == "Lorii" || quizAnswear4 == "Ronaldo" || quizAnswear5 =="Rodwailer");

            Console.ReadLine();
        }
    }
}
    

                    
                
            
       
    


                

            
        
    

        




