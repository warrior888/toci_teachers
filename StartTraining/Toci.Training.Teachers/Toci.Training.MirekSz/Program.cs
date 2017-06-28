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
            int x = Int32.Parse(rozmiarTablicy);

            //string[] kolory = new string[rozmiarTablicy];
        
            
            //Console.Clear();
                       
            Console.WriteLine("Rozmiar tablicy: " + rozmiarTablicy);
            
            for (int i = 0; i < x; i++)
            {
                int pom = i + 1;
                Console.Write("Podaj wartość tablicy nr: " + pom);
            }












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
