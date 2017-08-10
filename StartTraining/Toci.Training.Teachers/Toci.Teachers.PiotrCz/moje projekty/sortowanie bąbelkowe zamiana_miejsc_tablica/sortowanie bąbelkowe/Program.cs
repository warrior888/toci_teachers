using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_bąbelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] content = new int[] {4,56,3,2,6,8,78,4};

            int temp;
            for (int i = 0; i < content.Length; i++) 
            {
                for (int j = 0; j < content.Length; j++)
                {
                    if (i != j)
                    {
                        if (content[i] < content[j])
                        {
                            temp = content[i];
                            content[i] = content[j];
                            content[j] = temp;
                            
                         //  Console.WriteLine("sortowanie bąbelkowe : " + content[j]);
                        }
                      
                    }
                }
            }
            int nerd = 1;
            Console.ReadLine();
        }
    }
}
