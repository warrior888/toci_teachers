using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maksymalnaWartośćTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            Random r = new Random();
           

            for (int i = 0;i < tablica.Length; i++)
            {
                tablica[i] =r.Next(10);
                Console.Write(tablica[i] + " ");
            }
            Console.ReadKey();
        }
     
    }
}
