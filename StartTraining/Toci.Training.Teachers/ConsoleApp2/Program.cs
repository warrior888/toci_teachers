using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string toLowerCase(string text)
            {
                char[] result = new char[text.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    int charInAsci = (int)text[i];

                    if (charInAsci >= 65 && (charInAsci <= 90))
                    {
                        charInAsci += 32;
                    }
                    result[i] = (char)charInAsci;
                }
                return new string(result);
            }

            string toUpperCase(string text)
            {
                char[] result = new char[text.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    int charInAsci = (int)text[i];

                    if (charInAsci >= 97 && (charInAsci <= 122))
                    {
                        charInAsci -= 32;
                    }
                    result[i] = (char)charInAsci;
                }
                return new string(result);
            }


            string[] tableOfStrings(int size)
            {
                string[] table = new string[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write(i+1 + ": ");
                    table[i] = Console.ReadLine();
           
                }
                
                Console.WriteLine("Table full:");
                foreach (string s in table)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
                return table;
            }

            Console.WriteLine(toLowerCase("toLOWERcaseEXAMPLE"));
            Console.WriteLine(toUpperCase("toUppercaseEXAMPLE"));

            tableOfStrings(5);

            Console.ReadLine();
        }
    }
}
