using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.DamianG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoje imie");
            //string name;
            string name = Console.ReadLine();
            //string letterA = "a";
            string upperString = name.ToUpper();
            Console.WriteLine(upperString);

            Console.WriteLine("4 >5 Prawda czy fałsz?");
            Console.ReadLine();
            bool value = 4 > 5;
            Console.WriteLine(value);

            int trueValue = "Damian " == "damian " ? 7 : 8;
            Console.ReadKey();
        }
    }
}
