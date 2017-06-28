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
            int[] numValues = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8};
            int max = numValues[0], min = numValues[0], sum = 0, number = numValues[4], count = 0; 

            for (int i = 0; i < numValues.Length; i++)
            {
                if (numValues[i] >= max)
                {
                    max = numValues[i];
                }
                if (numValues[i] <= min)
                {
                    min = numValues[i];
                }
                sum += numValues[i];
                if (numValues[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine("Wartość maksymalna: " + max);
            Console.WriteLine("Wartosc minimalna: " + min);
            Console.WriteLine("Suma: " + sum);
            Console.WriteLine("Liczba wystapien 78: " + count);

            Console.ReadKey();
            
            /* string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Podaj array[" + i + "] = ");
                array[i] = Console.ReadLine();
                if (i == array.Length - 1)
                {
                    Console.WriteLine("Wprowadziles wszystkie wartosci. Wcisnij ENTER aby je teraz wyświetlić");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Oto wprowadzone wartosci: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            Console.ReadKey();*/
        }
    }
}
