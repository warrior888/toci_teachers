using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PawelK
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] text = new string[5];

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }


            for (int i = 0; i < text.Length;i++)
            {
                Console.WriteLine(i + 1 + ". " + text[i]);
            }
            Console.ReadKey();
        }
    }
}
