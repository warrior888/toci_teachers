using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_domowa_quiz_19_05
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] questions = new string[]
            {
                "questions 1"

            };

            for (int i = 0; i < questions.Length; i++)

            {

                Console.WriteLine(questions[i]);
                do
                {
                    string[][] ansQuest = new string[questions.Length][];

                    ansQuest[0] = new string[]
                    {
                        "cos1"
                    };

                    for (int j = 0; j < ansQuest[i].Length; j++)

                    {
                        string valueFromUserInput;
                        valueFromUserInput = Console.ReadLine();

                        Console.WriteLine("wpisz login");

                        if (valueFromUserInput.Length == ansQuest[i].Length)

                        {
                            Console.WriteLine("poprawna odpowiedz ");
                        }
                        else if (valueFromUserInput.Length != ansQuest[i].Length)
                        {
                            Console.WriteLine("zla odpowiedz ");

                        }
                        
                        Console.ReadLine();
                    }

                } while ();// co z tym zrobic :/

                }

            }
        }
    }






