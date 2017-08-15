using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ile_wystapila_dana_liczba_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile chcesz liczb?");
            string arrayNumber = Console.ReadLine();
            int.TryParse(arrayNumber, out int arrayNumberNumber);
            
            int[] array = new int[arrayNumberNumber];
            for (int i =0 ; i < arrayNumberNumber; i++)
            {
                Console.WriteLine("wpisz liczzbe");
                string userNumber = Console.ReadLine();
                int.TryParse(userNumber, out int userNumberNumber);
                array[i] = userNumberNumber;


            }

            Console.WriteLine("jaka liczbe chcesz zbadac?");
            string examinateNumber = Console.ReadLine();
            int.TryParse(examinateNumber, out int examinateNumberNumber);
            int numberOfnumbers = 0;
                for (int i = 0; i< arrayNumberNumber; i++)
            {
                if ( array[i] == examinateNumberNumber )
                {

                    numberOfnumbers++;
                }

            }

            Console.WriteLine("jest: " + numberOfnumbers);
            Console.ReadKey();
            
        }
    }
}
