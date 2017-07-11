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
            //Petla FOR
            string[] pamiec = new string[5];

            for (int i = 0; i < pamiec.Length; i++)
            {
                Console.WriteLine("Podaj " + i + " informację: ");
                pamiec[i] = Console.ReadLine();
            }
            Console.WriteLine("Dziękujemy, to już wszystkie dane których potrzebowaliśmy!");
            Console.ReadKey();

            //Translator Kodu ASCII

            Console.WriteLine("Podaj coś człowieku");
            string tekst = Console.ReadLine();

            foreach (char znak in tekst)
            {
                int i = znak;

                if (znak < 97)
                {
                    Przelicz(i);
                    char c = Convert.ToChar(Przelicz(i));

                    Console.WriteLine(c);
                }
                if (znak > 97)
                {
                    Przelicz2(i);
                    char a = Convert.ToChar(Przelicz2(i));
                    Console.WriteLine(a);
                }

                Console.ReadKey();
            }




            //Zadanie domowe tydzień 1
            int[] tablica = new int[10] {17, 18, 39, 20, 30, 16, 14, 32, 65, 10 };
            int max = 0;
                for(int i=0; i<tablica.Length; i++)
            {
                tablica[i]  = max;
                Console.WriteLine(max);
               // if (max < tablica(i))
                //{

                //}
            }
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



   
