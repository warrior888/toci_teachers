using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MirekSz
{
    class Program
    {
        static void Main(string[] args)
        {


            //homework

            //jest tablica a w niej elementy, by znalezc w tablicy maksymalna wartość
            //(za pomoca petli, bez gotowych      funkcji)

            Console.Write("Ile elementów ma mieć tablica?\n");

            string rozmiarTablicy = Console.ReadLine();
            
            int x = int.Parse(rozmiarTablicy);  // rzutowanie zmiennej string na int

            string[] kolory = new string[x];


            Console.Clear();

            Console.WriteLine("Rozmiar tablicy: " + rozmiarTablicy);

            for (int i = 0; i < x; i++)
            {
                int pom = i + 1;
                Console.Write("Podaj wartość tablicy nr " + pom + ":   ");

                string wartosc = Console.ReadLine();
               // i = int.Parse(i);
                kolory[i] = wartosc;

               
                

            }

            Console.WriteLine("\nwyświetlenie tablicy: ");

            for (int j = 0; j < x; j++)
            {
                int pom = j + 1; ;
                Console.WriteLine(pom + " - element tablicy: " + kolory[j]);
            }


            //minimalna wartość

            
            

            int[] e = new int[kolory.Length];

            for (int f = 0; f < e.Length; f++)
            {
                
            }



            /* int calkowita = int.Parse(kolory[0]);
             int min = calkowita;
             for (int k = 1; k < kolory.Length; k++)
             {
                 int calkowita1 = int.Parse(kolory[k]);
                 if (calkowita1 < min)
                 {
                     min = kolory[k];
                     Console.WriteLine("Minimalna wartość tablicy kolory wynosi: " + min);

                 }
             }*/


            
/*
            string test1 = kolory[0];
            string test2 = kolory[1];
            int testint1 = int.Parse(test1);
            int testint2 = int.Parse(test2);

            if (testint1 < testint2)
            {
                Console.WriteLine("1 jest mniejsze od 2");
            } else
            {
                Console.WriteLine("dwa jest wieksze");
            }
            */











            //**************************************************************************************************
            //tablice






            //Console.WriteLine("adaa");


            /*string surname = "Nowak";

            for (int i = 0; i < surname.Length; i++)
            {
                //Console.WriteLine(surname[i]);
                Console.Write(surname[i]);
            }*/




            /*string name = "Mi";
            Console.Write(name + " ");
            Console.Write("Sz\n");

            if (name.Length > 3)
            {
                Console.Write("Twoje imię ma wiecej niż 3 litery");
            } else
            {
                Console.Write("Twoje imię ma mniej niż 4 litery");
            }

            Console.ReadLine();






            //string name = "MirekSz".ToLower();
            //int variabelLength = 7;
            //int x = 5;
            //int y = 60;
            //bool test = x == y;

            
            */

            Console.ReadKey();
        }
    }
}
