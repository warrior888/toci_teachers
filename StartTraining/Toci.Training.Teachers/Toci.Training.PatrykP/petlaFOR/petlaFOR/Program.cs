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
            //string[] wpisane = new string[5];

            //string[] wpisane = new string[5];
            //string zmienna;
            //zmienna = wpisane[0];
            //Console.WriteLine("Podaj coś: ");
            //zmienna = Console.ReadLine();

            //int limit = wpisane.Length;


            //for (int i = 1; i > wpisane.Length; i++  ) 
            //{
            //    Console.WriteLine("Podaj coś człowieku:  ") ;
            //    Console.ReadLine();
            //    Console.WriteLine("Zapisano pomyślnie" + i);




            // }

            //Console.ReadKey();
            

            string[] pamiec = new string[5];
           // pamiec[0] = "ala";
            //pamiec[1] = "kot";
            //pamiec[2] = "alamakota";
            //pamiec[3] = "kotmalae";
            //pamiec[4] = "kotek";

            //Console.WriteLine(pamiec[2]);
            for (int i = 0; i < pamiec.Length; i++ )
            {
                Console.WriteLine("Podaj " + i + " informację: " );
                pamiec[i] = Console.ReadLine();
            }
            Console.WriteLine("Dziękujemy, to już wszystkie dane których potrzebowaliśmy!");
            Console.ReadKey();
        }
    }
}
