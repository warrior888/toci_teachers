using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Zadanie_TablicaLiczb
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stworzyć tablicę liczb:
            //zad. 1 - znaleźć w tablicy wartość maksymalną
            //zad.2  znaleźć w tablicy wartość minimalną
            //zad. 3 zsumować wszystkie elementy tablicy
            //zad. 4 policzyć ilość wystąpień danej liczb
            //
            //** create a table
            Console.WriteLine("Podaj liczby oddzielając je ',':");
            string numbersAsString = Console.ReadLine();
            numbersAsString = numbersAsString.Replace(' ', ','); //replace ' ' into ,
            string[] tableOfNumbers = numbersAsString.Split(',');
            int size = tableOfNumbers.Length;


            int[] numbers = new int[size]; // creates table with int 

            for(int i=0;i<size;i++)
            {
                numbers[i] = int.Parse(tableOfNumbers[i]); 
            }

            //**
            //** create questions and results

            Console.WriteLine("Możesz wykonać następujące dzialania. Wpisz odpowiednia cyfrę aby uzyskać rezultat:");
            Console.WriteLine("1 - maksymalna wartość w tablicy");
            Console.WriteLine("2 - minimalna wartość w tablicy");
            Console.WriteLine("3 - zsumowanie elementów tablicy");
            Console.WriteLine("4 - policzenie występowania wskazanej liczby w tablicy");
            //**

            string result = Console.ReadLine();

            
            if ( result == "1")
            {
                int max = numbers[0];
                for(int i=0;i<size;i++)
                {
                    if(numbers[i]>max)
                    {
                        max = numbers[i]; 
                    }
                }

                Console.WriteLine("Maksymalna wartośC w tablicy wynosi: " + max);
            }
            else if ( result == "2")
            {
                int min = numbers[0];
                for (int i=0;i<size;i++)
                {
                    if(numbers[i]<min)
                    {
                        min = numbers[i];
                    }
                }

                Console.WriteLine("Minimalna wartośC w tablicy wynosi: " + min);
            }
            else if ( result == "3")
            {
                int sum = 0;
                for (int i=0;i<size;i++)
                {
                    sum = sum + numbers[i];
                }
                Console.WriteLine("Suma elementów tablicy wynosi: " + sum);
            }
            else if ( result == "4")
            {
                Console.WriteLine("Podaj wartość której występowanie chcesz zliczyć:");
                int wantedNumber = int.Parse(Console.ReadLine());

                int count = 0;
                for (int i=0;i<size;i++)
                {
                    if (numbers[i] == wantedNumber)
                    {
                        count = count + 1;
                    }
                }

                Console.WriteLine("Wskazana liczba występuje " + count + " razy.");
            }
            else
            {
                Console.WriteLine("Proszę podaj cyfrę 1-4.");
            }
            Console.ReadLine();
            
        }
    }
}
