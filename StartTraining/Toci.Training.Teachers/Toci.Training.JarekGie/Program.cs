using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.JarekGie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaStringow = new string[10];


            Console.WriteLine("Napisz coś :");

            for (int i = 0; i < tablicaStringow.Length; i++)
            {
                
                tablicaStringow[i] = Console.ReadLine();
                Console.WriteLine("Dodano :" + tablicaStringow[i]);
                if (i == tablicaStringow.Length - 1)
                {
                    Console.WriteLine("Koniec tablicy");
                }
            }
         
          
            for (int i = 0; i < tablicaStringow.Length; i++)
            {
                Console.Write(tablicaStringow[i] + " ");
            }

            for (int i = tablicaStringow.Length - 1; i >= 0; i--)
            {
                Console.Write(tablicaStringow[i] + " ");
            }
            
            Console.ReadKey();

        }
    }
}
