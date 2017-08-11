using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_domowa_cz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] content4 = new[] {1, 2, 3, 4, 1, 4, 3, 2, 1,};

            int exampleElement = 1;

            int tableExampleElement = 0;

            for (int i = content4.Length -1; i >=0 ; i--)

                if (content4[i] == exampleElement) 
            {
                tableExampleElement++; // przeprowadzilismy inkrementacje czyli po kazdym obejscciu petli
                    //sprawdzana jest kolejna wartosc tablicy
            }

            //int summary4 = tableExampleElement;

            Console.WriteLine("ilosc liczby 1 to : " + tableExampleElement);

            Console.ReadLine();



        }
    }
}
