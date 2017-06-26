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
            

            string name = "Mi";
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

            // Console.ReadKey();

        }
    }
}
