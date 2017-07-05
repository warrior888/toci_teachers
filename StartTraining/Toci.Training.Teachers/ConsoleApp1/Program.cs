using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // zad 1&2&3. Max wartosc/ Min wartosc. Suma liczb z tablicy
            int[] parameters = { 2, 3, 5, 4, 5, 2, 1, 3, 6, 7, 9, 11, 24, 5, 12, 12, 14, 3 };
            int length = parameters.Length;
            int resultMax = int.MinValue, resultMin = int.MaxValue, sumOfNumber = 0;


            for (int i = 0; i < length; i++)
            {

                if (parameters[i] > resultMax)
                {
                    resultMax = parameters[i];
                }

                if (parameters[i ] < resultMin)
                {
                    resultMin = parameters[i];

                }

                sumOfNumber += parameters[i];


            }

            //zad 4.
            Console.WriteLine("Podaj liczbe do sprawdzenia: ");
            string par = Console.ReadLine();

            int number = Convert.ToInt32(par);

            int Occurrence = 0;

            for (int i = 0; i < length; i++)
            {
                if (number == parameters[i])
                {
                    Occurrence++;
                }

            }
            // zapytanie i wpisanie do tablicy wartosic podanych od użytkownika.

            Console.WriteLine("Podaj ilosc liczb do wpisania do tablicy: ");

            string lenghtOfTable = Console.ReadLine();

            int lenghtOfNumber =0;

            int.TryParse(lenghtOfTable, out lenghtOfNumber);

            //int[] values;

            //values = new[lenghtOfNumber];// Jak tutaj zainicjowac tablice??

            for (int j = 0; j < lenghtOfNumber; j++)
            {
                Console.WriteLine("Podaj liczbe: {0}", j + 1);
                //values[j] = Convert.ToInt32(Console.ReadLine());
                




            }

            Console.WriteLine("Max to: {0}, Min to: {1}, Wystapienia: {2}, Suma to: {3}", resultMax, resultMin,Occurrence,sumOfNumber);
            //Console.Write("Liczby od użytkownika: {0}", values); // wywala int 32, cos zle zrobilem
            //Console.ReadLine();

            // HomeWork Training 2 |ex. 1

            string string1 = "Nie jak talala";
            string example = "jak";
            string result = "";






            for (int i = 0; i < string1.Length - 1 - example.Length - 1; i++)
            {
                for (int j = string1.Length - 1 - example.Length; j >= example.Length - 1; j--)
                {
                    result = string1.Substring(i, j);

                    if (String.Equals(example, result))
                    {
                        Console.WriteLine(i + "  aaaaa znalazlem");
                    }
                }
            }


            string result2 = "";
                    int f = example.Length;
                    for (int k = 0; k < string1.Length - example.Length-1; k++)
                    {
                        result = string1.Substring(k, f);

                                if (String.Equals(example, result2))
                                {
                                    Console.WriteLine(k + "  aaaaa znalazlem");
                                }
                        

                        
                        
                        Console.WriteLine("to: {0}, {1}",k,f);
                        Console.WriteLine(result);


                    }

                

            


        }
    }
}
