using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toci_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst: ");
            string textFromUserImput = Console.ReadLine();

            Console.WriteLine("długość tekstu = {0}", textFromUserImput.Length);



            Console.ReadKey();
        }
    }
}
