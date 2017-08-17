using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Task_TABLICE
{
    class Program
    {
        static void Main(string[] args)
        {
            string ourSubstringexample = "Karol i Natalia";

            int start = 5;
            int lettertocut = 3;

            string cuttingletters = "";

            for (int i = start; i < start + lettertocut; i++)
            {
                cuttingletters += ourSubstringexample[i];
            }
            Console.WriteLine(cuttingletters);




            int[] tablicapierwsza = new int[] {3, 4, 67, 45, 43, 90, 86, 75, 47, 86, 93, 24, 67, 86};

            int temp;

            for (int i = 0; i < tablicapierwsza.Length; i++)
            {
                for (int j = 0; j < tablicapierwsza.Length; j++)
                {
                    if (i != j)
                    {
                        if (tablicapierwsza[i] < tablicapierwsza[j])
                        {
                            temp = tablicapierwsza[i];
                            tablicapierwsza[i] = tablicapierwsza[j];
                            tablicapierwsza [j] = temp;
                        }
                    }
                }
            }




            int[] losoweliczby = new int[] {3, 4, 67, 45, 43, 90, 86, 75, 47, 86, 93, 24, 67, 86};
            int max =0;

            for (int i = 0; i < losoweliczby.Length; i++)
            {
                if (max < losoweliczby[i])
                {
                    max = losoweliczby[i];
                }

            }
            Console.WriteLine(max);
            Console.ReadKey();
            int min = int.MaxValue;
            for (int i = 0; i < losoweliczby.Length; i++)
            { 
                if (min > losoweliczby[i])
                {
                    min = losoweliczby[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();

            int sum = 0;
            for (int i = 0; i < losoweliczby.Length; i++)
            {
                sum += losoweliczby[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            int number = 86;
            int countofnumber = 0;
            for (int i = losoweliczby.Length - 1; i >= 0; i--)
            {
                if (losoweliczby[i] == number)
                {
                    countofnumber++;
                }
            }
            Console.WriteLine("ilość wystąpień"+"  " + countofnumber);
            Console.ReadKey();

        }
    }
}
