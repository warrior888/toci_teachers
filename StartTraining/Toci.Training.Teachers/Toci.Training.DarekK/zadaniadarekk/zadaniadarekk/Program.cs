using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadaniadarekk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = new int[] {1, 5, 10, 40, 80, 2, 4, -1, 15, 100, 12, 10, 0};
            int max = 0;
            int min = 0;
            int suma = 0;
            int naj = 0;
            int tech = 0;
            for (int i = 0; i < dane.Length; i++)
            {
                if (max < dane[i])
                {
                    max = dane[i];
                }
                if (min > dane[i])
                {
                    min = dane[i];
                }
                suma += dane[i];
                
            }

            Console.WriteLine("Maksymalna liczba to: " + max);
            Console.WriteLine("Minimalna liczba to: " + min);
            Console.WriteLine("Suma: " + suma); 
            Console.WriteLine("Powtarzają się "+ naj + " razy");
            Console.ReadLine();
            
        }
    }
}
