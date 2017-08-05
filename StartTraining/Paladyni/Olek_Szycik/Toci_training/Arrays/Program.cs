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
            // zrób tablicę, znajdź wartości min i max, sumę
            // zliczyć ilość wystąpień przykładowego elementu

                        
            int[] arr = {70, 55, 11, 32, 58, 73, 48, 61, 88, 99};

            Console.Write("liczby w tablicy: \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}", arr[i], " ");
            }

            
            for (int i = 0; i < arr.Length; i++)
            {
                int min, k;

                min = arr[i];
                k = i;
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

            Console.WriteLine("\n\nposortowane: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}",arr[i], " ");
            }

            
            Console.WriteLine("\n\nposortowane metodą Array.Sort");
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}", arr[i], " ");
            }


            Console.WriteLine();

            Array.Reverse(arr);

            Console.WriteLine("\n\nposortowane odwrotnie metodą Array.Reverse");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {1}", arr[i], " ");
            }




            Console.ReadKey();
        }
    }
}
