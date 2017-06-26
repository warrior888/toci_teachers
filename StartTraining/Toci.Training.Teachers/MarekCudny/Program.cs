using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarekCudny
{
    class Program
    {
        static void Main(string[] args)
        {
            // napisac translacje z malych na duze litery kozystajac z tablicy kodow ASCI
            string TextToChange = "";
            TextToChange = Console.ReadLine();
            ChangeCaseToOpposite(TextToChange);
        }

        private static void ChangeCaseToOpposite(string s)
        {
            foreach (char c in s)
            {
                if ((int)c >= 65 && (int)c <= 90)
                {
                    Console.Write((char)((int)c + 32)); //change to lower case
                }
                else
                {
                    Console.Write((char)((int)c - 32)); //change to upper case
                }

            }
            Console.ReadKey();
        }
    }
}
