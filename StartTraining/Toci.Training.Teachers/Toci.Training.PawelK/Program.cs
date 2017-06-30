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
             int maxValue (int [] tabfun )
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
           Console.WriteLine($"Suma elementow zbioru: {count(tab,userInputNumber)}");
            
            /*string [] text = new string[5];

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }


            for (int i = 0; i < text.Length;i++)
            {
                Console.WriteLine(i + 1 + ". " + text[i]);
            }*/
            Console.ReadKey();
        }
    }
}
