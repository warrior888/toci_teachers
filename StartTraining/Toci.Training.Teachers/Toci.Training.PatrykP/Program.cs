using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Petla FOR
            //string[] pamiec = new string[5];

            //for (int i = 0; i < pamiec.Length; i++)
            //{
            //    Console.WriteLine("Podaj " + i + " informację: ");
            //    pamiec[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Dziękujemy, to już wszystkie dane których potrzebowaliśmy!");
            //Console.ReadKey();

            ////Translator Kodu ASCII

            //Console.WriteLine("Podaj coś człowieku");
            //string tekst = Console.ReadLine();

            //foreach (char znak in tekst)
            //{
            //    int i = znak;

            //    if (znak < 97)
            //    {
            //        Przelicz(i);
            //        char c = Convert.ToChar(Przelicz(i));

            //        Console.WriteLine(c);
            //    }
            //    if (znak > 97)
            //    {
            //        Przelicz2(i);
            //        char a = Convert.ToChar(Przelicz2(i));
            //        Console.WriteLine(a);
            //    }

            //    Console.ReadKey();
            //}




            //Zadanie domowe tydzień 1
          
            int[] tablica = new int[] {10,11,11,42,12,15,12,51,12,25,43,13,251,45,3,2,234,32,1,2};
            int max = 0;
            int min = 0;
            int suma = 0;
            int powtorzenie = 0;
                for(int i=0; i<tablica.Length; i++)
            {
               
                if (max < tablica[i])
                {
                    max = tablica[i];
                }
                if (max > tablica[i])
                {
                    min = tablica[i];
                }
                suma = tablica[i] + suma; 

                if (tablica[i] == 11)
                {
                    powtorzenie++;
                }
                
            }
            Console.WriteLine("Maksymalna wartość to: " + max);
            Console.WriteLine("Minimalna wartość to:" + min);
            Console.WriteLine("Suma wszyskich elementów wynosi: " + suma);
            Console.WriteLine("Powtórzeń liczby 11: " + powtorzenie);
            Console.ReadKey();
        }

        private static int Przelicz(int i)
        {
            return (i + 32);

        }
        private static int Przelicz2(int i)
        {
            return (i - 32);
        }



    }
}



   
