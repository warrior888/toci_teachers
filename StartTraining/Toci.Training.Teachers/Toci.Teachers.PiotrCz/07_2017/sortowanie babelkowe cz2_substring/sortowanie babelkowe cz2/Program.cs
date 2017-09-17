using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_babelkowe_cz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = "piotrek to fajny chłopak"; // KOD WYCINAJACY FRAGMENT TEKSTU,
                                                            // DZIEKI TEMU PETLA POJDZIE MNIEJ RAZY I 
                                                            //PROGRAM BEDZIE DZIALAL CIUTKE KRÓCEJ

            int start = 7;

            int legthToCut = 10;

            string cutSubstring = "";

            for (int i = start; i < start + legthToCut; i++)
            {
                cutSubstring += substring[i];
            }

          //  int[] hellow = new int[] {1, 2};
            Console.Write("wyciety fragment to :" + cutSubstring);

            Console.ReadLine();
        }
    }
}
