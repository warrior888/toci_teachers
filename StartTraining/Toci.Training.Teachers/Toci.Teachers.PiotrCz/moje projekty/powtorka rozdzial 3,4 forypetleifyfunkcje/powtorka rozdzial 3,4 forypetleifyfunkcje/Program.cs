using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace powtorka_rozdzial_3_4_forypetleifyfunkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaIomn = new string[10];

            tablicaIomn[0] = "Piotr";
            tablicaIomn[1] = "Ola";
            tablicaIomn[9] = "Paulina";

            int index = FindIndex(tablicaIomn, "Paulina");

            Console.WriteLine("Index : " + index);
            Console.ReadLine();
        }

        public static int FindIndex(string[] table, string value)
        {
            for (int i = table.Length - 1; i >= 0; i--)
            {
                if (table[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
 
               
    


