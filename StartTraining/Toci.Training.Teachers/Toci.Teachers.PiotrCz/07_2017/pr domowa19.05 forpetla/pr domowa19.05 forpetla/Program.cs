using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_domowa19._05_forpetla
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userInput = Console.ReadLine();

            int userInputNumer = 0;
            
            int.TryParse(userInput, out userInputNumer);
            
           
            int[] lengthOfStrings = new int[userInputNumer];

            for (int i = 0; i <= lengthOfStrings.Length - 1; i++)

                {
                
                    Console.Write("podaj linijke tekstu numer " + (i+1) + ":" );

                    string line = Console.ReadLine();


                    if (i == lengthOfStrings.Length - 1)

                    {
                        Console.WriteLine("Dzięki za uzupełnienie " + userInputNumer + " elemntów pętli :)");
                        
                    }
                     
            }
            Console.ReadLine();
        }
    }
}
