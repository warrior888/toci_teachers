using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] table = new string[10];
            int number = table.Length;


            for(int i=0;i<number;i++)
            {
                Console.Write("Podaj wyraz nr "+(i+1)+":");
                table[i] = Console.ReadLine();

                if(number - 1 == i)
                {
                    Console.WriteLine("\nUzupelniles swoja tablice!");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Twoja tablica to:");

            for(int i=0;i<number;i++)
            {
                Console.Write(" "+table[i]);
            }
           

            Console.ReadKey();
        }
    }
}
