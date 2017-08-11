using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace praca_domowa_cz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] content3 = new int[] {1,2,3,4,5,4,3,2,1};

            int suma = 0;

            for (int i = 0; i < content3.Length; i++)

            {
                suma += content3[i];
                
            }
            Console.WriteLine("suma to :" + suma);
          
            // int finish3 = suma; - braekpoint

            Console.ReadLine();
        }
    }
}
