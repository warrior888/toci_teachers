using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maksymalnaWartośćTablicy
{
    class Program
    {
        static void Main(string[] args)           

        {
            //deklaracja zmiennych celowo na samej górze, żeby uniknąć 
            //śmieci w kodzie ( jeśli źle rozumuję, to poprawcie mnie ;) )
            int i, max;
            int[] tablica = new int[10];

            //klasa generująca liczby pseudolosowe
            Random r = new Random();
           
            
            //wypełniam tablicę liczbami pseudolosowymi
            for (i = 0;i < tablica.Length; i++)
            {
                tablica[i] =r.Next(10);
                Console.Write(tablica[i] + " ");
            }

            //Przejście do nowej linii
            Console.WriteLine();
            max = tablica[9];

            for (i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
              
            }
            Console.WriteLine("Największy element tablicy to: " + max);




            Console.ReadKey();
        }
     
    }
}
