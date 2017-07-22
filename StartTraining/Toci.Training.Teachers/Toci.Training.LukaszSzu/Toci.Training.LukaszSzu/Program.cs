using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LukaszSzu
{
    class Program
    {

        int[] content = new inf[] { 1, 35, 2, 3, 5, 6, 3, 2, 523, 5, 234, 24, 5, 435, 6345, 2, 4234 }
        
        for (int i - 0; i < content.Length; i++)
            {
                for (int j = 0; j < content.Lenght; j++)
                {
                    if (int != j)
                    {
                        if (content[i] < content[j])
                        {
                            temp = content[i];
                            content[i] = content[j];
                            content[j] = temp;
                        }
                    }
                }
            }
        
        
        int max = 0;
        for (int i = 0; i < content.Lenght; i++)
        {
            if (max < content[i])
            {
                max = content[i]; 
            }
        }   
    
    }
}
