using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_task_Pętla_w_Pętli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Zdanie:");
            string basic = Console.ReadLine();
            Console.WriteLine("Podaj słowo, które mam znaleźć:");
            string simple = Console.ReadLine();
            int start = 0;
            int positionBasic;
            int positionSimple;
            int positionToCatch=0;
            bool isChanged = false;
            for (int i = 0; i < basic.Length; i++)
            {
                if (basic[i] == simple[start])
                {
                    isChanged = true;
                    positionBasic = i;
                    positionSimple = start;
                    for (int j = 0; j < simple.Length; j++, positionSimple++, positionBasic++)
                    {
                        if (basic[positionBasic]!=simple[positionSimple])
                        {
                            isChanged = false;
                            break;
                        }
                    }
                    if (positionSimple==simple.Length)
                    {
                        positionToCatch = i;
                        break;
                    }
                }
            }

            if (isChanged)
            {
                Console.WriteLine(positionToCatch+1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nic nie znaleziono!");
                Console.ReadKey();
            }
            
        }
    }
}
