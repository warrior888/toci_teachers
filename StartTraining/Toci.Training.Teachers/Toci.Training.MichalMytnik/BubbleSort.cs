using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalMytnik
{
    class BubbleSort
    {
        static void sortBubble (string[] args)
        {
            int[] element = new int[] { 100, 34, 64, 23, 27, 112, 34, 545, 64, 43, 27 };

            int oldI = 0;

            for (int i = 0; i < element.Length; i++)
            {

                for (int j = 0; j < element.Length; j++)
                {
                    if (i != j)
                    {
                        if (element[i] < element[j])
                        {
                            oldI = element[i];
                            element[i] = element[j];
                            element[j] = oldI;

                        }


                    }


                }


            }
            Console.WriteLine(element);
        }

    }
}
