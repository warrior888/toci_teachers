using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_kodu_ascii
{
    class Program
    {
         
          
        
        

            static void Main()
            {
            Console.WriteLine("Podaj coś człowieku");
                string tekst = Console.ReadLine();

                foreach (char znak in tekst)
                {
                    int i = znak;



                
                
                     if (znak < 97)
                     {
                    Przelicz(i)  ;
                   char c = Convert.ToChar(Przelicz(i));

                    Console.WriteLine(c) ; 
                        }
                        if (znak > 97)
                        {
                    Przelicz2(i);
                    char a = Convert.ToChar(Przelicz2(i));
                    Console.WriteLine(a);
                        }

                Console.ReadKey();
                }
                

            }

        private static int Przelicz(int i)
        {
            return (i + 32);
           
            
        }
        private static int Przelicz2(int i)
        {
            return (i - 32);
        }
    }   
}

