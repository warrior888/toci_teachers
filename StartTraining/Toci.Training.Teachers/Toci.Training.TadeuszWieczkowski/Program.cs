using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.TadeuszWieczkowski
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tab = new int[] {10, 5, 1,5,8,7,4,0,1,1,1};
            int max = tab[0];
            int min = tab[0];
            int suma = 0;
            

            for (int i = 0; i < tab.Length; i++)
                
            {
                if (min > tab[i])
                    min = tab[i];
            }
            Console.WriteLine("Min : " + min);

            for (int i = 0; i < tab.Length; i++)
            {
                if (max < tab[i])
                    max = tab[i];
            }
            Console.WriteLine("Max: " + max);

            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            Console.WriteLine("Suma: " + suma);


            for (int i = 0; i < tab.Length; i++)
            {
                int find = 1;
                int counter = 0;
                foreach (int ele in tab)
                {
                    if (ele == find)
                        counter++;
                    
                }
                Console.WriteLine("Szukany element: " + find + " Znaleziono ilosc : " + counter );
            }

            









            string someString = "Ala ma kota";

         // Console.WriteLine(someString);

           
            for (int i = 0; i < someString.Length; i++)
            {
           

                if ((int)someString[i] >= 65 && (int)someString[i] <= 90)
                  
                {
                   
                    Console.Write((char)((int)(someString[i] + 32)));

                }
                else
                {
                    Console.Write((char)((int)(someString[i] - 32)));
                }
            }




            Console.ReadLine();


        }
    }
}
