using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] dane = new int[] { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
            int dlugosc = dane.Length;
            int suma = 0;
            int max = 0;
            int min = 0;
            int szukaj = 78;
            int zlicz = 0;

            for (int k = 0; k < dlugosc; k++)
            {
                for (int i = 0; i < dlugosc - 1; i++)
                {
                    min = dane[0];
                    if (dane[i] < min)
                    {
                        min = dane[i];
                    }
                    suma = suma + dane[i];
                    if (dane[i] > max)
                    {
                        max = dane[i];
                    }
                    if (dane[i] >= dane[i + 1])
                    {
                        int temp = dane[i + 1];
                        dane[i + 1] = dane[i];
                        dane[i] = temp;
                    }
                }
            }
            for(int j = 0; j < dlugosc; j++)
            {
                Console.Write(dane[j] + ",");
                if (dane[j] == szukaj)
                {
                    zlicz++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("najmniejsza wartosc: " + min);
            Console.WriteLine("najwieksza warotsc: " + max);
            Console.WriteLine("suma wszystkich wartosci: " + suma);
            Console.WriteLine("ilosc wystapienia " + szukaj + ": " + zlicz);
            Console.Read();
        }
    }
}
