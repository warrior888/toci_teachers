using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimalnaWartoscTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracja zmiennych celowo na samej górze, żeby uniknąć 
            //śmieci w kodzie ( jeśli źle rozumuję, to poprawcie mnie ;) )
            int i, min;
            int[] tablica = new int[10];

            //klasa generująca liczby pseudolosowe
            Random r = new Random();


            //wypełniam tablicę liczbami pseudolosowymi
            for (i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(10);
                Console.Write(tablica[i] + " ");
            }

            //Przejście do nowej linii
            Console.WriteLine();
            min = tablica[9];

            for (i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < min)
                {
                    min = tablica[i];
                }

            }
            Console.WriteLine("Najmniejszy element tablicy to: " + min);




            Console.ReadKey();
        }
    }
}
