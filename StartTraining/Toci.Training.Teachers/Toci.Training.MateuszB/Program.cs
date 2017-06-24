using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MateuszB
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Podaj array[" + i + "] = ");
                array[i] = Console.ReadLine();
                if (i == array.Length - 1)
                {
                    Console.WriteLine("Wprowadziles wszystkie wartosci. Wcisnij ENTER aby kontynuowac");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Oto wprowadzone wartosci: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
