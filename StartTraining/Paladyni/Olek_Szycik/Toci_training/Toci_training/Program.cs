using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst: ");
            string textFromUserInput = Console.ReadLine();

            //Console.WriteLine("podaj długość tablicy: ");
            //int countFromUserInput = int.Parse(Console.ReadLine());

            Console.WriteLine("długość tekstu = {0}", textFromUserInput.Length);

            //int[] example = new int[countFromUserInput];
            char mark = '-';
            for (int i = 0; i < textFromUserInput.Length; i++)
            {
                Console.Write("{0}", textFromUserInput[i]);

                if (i < textFromUserInput.Length - 1)
                {
                    Console.Write(mark);
                }
            }

            Console.ReadKey();
        }
    }
}
