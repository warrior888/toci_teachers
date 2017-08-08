using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.KarolB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mój pierwszy program");
            Console.ReadLine();

            string Name = "Karol";
            int stringLength= Name.Length;

            if (stringLength > 4)
            {
                Console.WriteLine("If sie spełnił");
                Console.ReadLine();
            }

            for (int i= 0; i < Name.Length; i++)
            {
                Console.Write(Name[i]);
            }
           
            Console.WriteLine("\n \n" + stringLength);
            Console.ReadLine();
           
        }
    }
}