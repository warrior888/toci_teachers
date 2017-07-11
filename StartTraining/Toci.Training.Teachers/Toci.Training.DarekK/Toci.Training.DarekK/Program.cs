using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.DarekK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new String[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj wyraz:");
                string zconsoli = Console.ReadLine();
                tablica[i] = zconsoli;
            }
            Console.WriteLine("Dziekuje za podanie czterech wyrazów");
            Console.ReadKey();


            string przyklad = "Darek";
            for (int i = przyklad.Length - 1; i >= 0; i--)
            {
                if (przyklad[i] != 'i')
                {
                    Console.Write(przyklad[i]);
                }
            }
            Console.WriteLine();
            int[] dlugoscstring = new int[10];
            for (int i = 0; i < dlugoscstring.Length; i++)
            {
                Console.WriteLine("I wynosi :" + i);
                dlugoscstring[i] = ("I wynosi :" + i).Length;
            }
            // typ, zmienna, operator, 
            string name = "Darek";
            int nameLenght = 5;
            int test = "darek" == "Darek" ? 7 : 8;
            Console.WriteLine("Napisz coś człowieku :");
            string zconsoliwpisane = Console.ReadLine();
            if (zconsoliwpisane == "tak")
            {
                Console.WriteLine("Weszło");
                int zmienna = 7;
                if (zconsoliwpisane.Length > 2)
                {
                    Console.WriteLine("Weszło do drugiego if");

                }
            }
            else
            {
                Console.WriteLine("Nie weszło do pierwszego if");
            }

            Console.WriteLine("Koniec");
            Console.ReadKey();
        }
    }
}
