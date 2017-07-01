using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            int[] parameters = {2, 3, 5, 4, 5, 2, 1, 3, 6, 7, 9, 11, 24, 5, 12, 12, 14, 3};
            int length = parameters.Length;
            int resultMax = 0, resultMin=0, sumOfNumber=0;


            for (int i = 0; i < length; i++)
            {
                
                if (parameters[i]> resultMax)
                {
                    resultMax = parameters[i];
                }

                    if (parameters[i+1] < resultMin)
                    {
                        resultMin = parameters[i];

                    }

                sumOfNumber += parameters[i];


            }

            //zad 4.
            Console.WriteLine("Podaj liczbe do sprawdzenia: ");
            string par = Console.ReadLine();

            int number= Int32.Parse(par);

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

            int lenghtOfNumber;

            int.TryParse(lenghtOfTable, out lenghtOfNumber);

            int[] values;

            values = new Int32 [10];

                    for (int j = 0; j < lenghtOfNumber; j++)
                    {
                        Console.WriteLine("Podaj liczbe: {0}", j +1);
                        values[j] = int.Parse(Console.ReadLine()) ;
                        //Nie mam pojęcia jak zrobic aby po wpisaniu wartosci przez uzytkownika wprowadzilo kolejno  do elementu talicy
                        // wartosc 0,1,2,3,4,5,6,7,8 itd




                    }

            Console.WriteLine("Max to: {0} Min to: {1}", resultMax, resultMin);
            Console.Write("Liczby od użytkownika: {0}",values); // wywala int 32, cos zle zrobilem
            Console.ReadLine();


        }



            

            





        
    }
}
