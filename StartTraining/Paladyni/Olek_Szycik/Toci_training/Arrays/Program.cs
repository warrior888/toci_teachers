using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // zrób tablicę, znajdź najw. wartość i minimalną, suma
            // zliczyć ilość wystąpień przykładowego elementu

            int[] arr = new int[] {10, 55, 84, 11, 77, 17, 84, 56, 78};

            Console.Write("liczby w tablicy: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}", arr[i], " ");
            }

            
            for (int i = 0; i < arr.Length; i++)
            {
                int min = arr[i];
                int k = i;
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        k = j;
                    }
                arr[k] = arr[i];
                arr[i] = min;
                }
            }

            Console.WriteLine("\nposortowane: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}",arr[i], " ");
            }

            
            
            //http://blog.przemyslawsobolewski.com/sortowanie-w-c-dwa-sposoby/





            Console.ReadKey();
        }
    }
}
