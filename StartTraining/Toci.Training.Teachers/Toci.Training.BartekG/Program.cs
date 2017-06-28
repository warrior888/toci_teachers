using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.BartekG
{
    class Program
    {
        static void Main(string[] args)
        {     

            // wczytywanie do tablicy
             string[] table = new string[10];
             int na = table.Length - 1;
             for (int i = 0; i < table.Length; i++)
             {
                 Console.WriteLine("Wpisz coś do indexu " + i + " na " + na);
                 table[i] = Console.ReadLine();

                 if (i==table.Length-1)
                 {
                     Console.WriteLine("Uzupełniłeś całą tablicę :)");
                 }
             }
             Console.WriteLine("Oto twoja tablica: ");
             for (int i = 0; i < table.Length; i++)
             {
                 Console.WriteLine("dla ["+i+"] = "+table[i]);




             }
            // max liczba
            int[] homework = new int[] { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
          
            int max = homework[0];

        
            for (int i = 0; i <homework.Length ; i++)
            {
                if (homework[i]>max)
                {
                     max = homework[i];
                }
            
            }
            Console.WriteLine(max);

            // mininmalna wartosc
            int min = homework[0];


            for (int i = 0; i < homework.Length; i++)
            {
                if (homework[i] < min)
                {
                    min = homework[i];
                }

            }
            Console.WriteLine(min);

            // Suma wszystkich elementów
            int suma = 0;


            for (int i = 0; i < homework.Length; i++)
            {
                suma += homework[i];

            }
            Console.WriteLine(suma);

          
            //ilosc  wystapien  

            int wystapienia = 0;
            int liczba = 78;


            for (int i = 0; i < homework.Length; i++)
            {
                if (liczba==homework[i])
                {
                    wystapienia ++;
                }

            }
            Console.WriteLine("ilosc powtorzen: " + wystapienia + " dla liczby "+ liczba );
            Console.ReadKey();

        }






    }
}
