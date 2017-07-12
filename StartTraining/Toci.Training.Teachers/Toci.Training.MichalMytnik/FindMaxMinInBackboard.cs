using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalMytnik
{
    class FindMaxMinInBackboard
    {

        static void MaxMin(string[]args)
        {
            int[] element = new int[] { 100, 34, 64, 23, 27, 112, 34, 545, 64, 43, 27 };
            int maxValuue = element[0];
            int minValue = element[0];
            int numberOfRepetitions = element[0];
            int sumValue = 0;

            for (int i = 0; i < element.Length; i++)
            {


                if (maxValuue < element[i])
                {
                    maxValuue = element[i];
                    // Console.WriteLine("Przypisz nową wartość: " + maxValuue);
                }
                if (minValue > element[i])
                {
                    minValue = element[i];
                }
                sumValue += element[i];
                //if (numberOfRepetitions == element[i])
                //{


                //}
            }
            Console.WriteLine("Max wartość w tablicy to: " + maxValuue);
            Console.WriteLine("Min wartość w tablicy to: " + minValue);
            Console.WriteLine("Suma tablicy: " + sumValue);
            Console.ReadKey();

        }



    }
}
