using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersMasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            string toci = "dowolna 8";
            int Digit = 9;
            double quotient = 8.8;
            bool logicalValue = true;

            // cpu - computer
            int[] mastermindCpu = new int[4];
            Action[] test = new Action[8];

            int countOfAttempts = 10;
            //test[0] = Main;

            mastermindCpu[3] = 9;

            //mastermindCpu[3]


            // if  - instrukcja warunkowa
            // for - petla
            // [] - tablica

// et1 goto

            string taktezmozna;

            for (;;)
            {
                Console.WriteLine("Czlowieku !!  napisz cokolwiek !! : ");
                taktezmozna = Console.ReadLine();

                if (toci == taktezmozna) // always true
                {
                    Console.WriteLine("Toci :) \n");
                    // tu konczymy
                    break;
                }
                else
                {
                    Console.WriteLine("Jarek dobrze gada \n");


                    /// wrqacamy do wczytania wartosci
                    // goto Et1
                }
            }

            /*
            if (countOfAttempts < ??) // jesli przekroczylismy ilosc prob koniec !! ? true ? false : 1 : 0 ? null  10 bin  2 dec
            {
                // 1
            }
            else
            {
                if ()
                {
                    // 2
                    if ()
                    {
                        //3
                    }
                }
                else
                {
                    // 4
                }
            }
            */
            // czy trafione czy nie ??

            Console.WriteLine("Program exituje - konczy sie :) .");
            taktezmozna = Console.ReadLine();
            // ??
        }
    }
}
