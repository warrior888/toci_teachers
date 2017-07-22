using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaElementów
{
    class Program
    {
        static void Main(string[] args)
        {
            //tradycyjnie zmienne na samym początku
            int i,
                wynik = 0;

            //inicjalizacja tablicy
            int[] tab = new int[10];

            //inicjalizacja losowania
            Random r = new Random();

            //wypełnienie tablicy
            for (i = 0;i < tab.Length;i++)
            {
                tab[i] = r.Next(10);
                Console.Write(tab[i] + " ");
            }

            //Pusta linijka
            Console.WriteLine();

            //suma tablicy
            for (i = 0;i < tab.Length; i++)
            {
                wynik += tab[i]; 
            }
            Console.WriteLine("Suma elementów to: " + wynik);




            Console.ReadKey(); 
        }
    }
}
