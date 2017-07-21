using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortbdk
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Darek lubi programować";
            int start = 5;
            int wyc = 6;
            string dowyc = "";
            for (int i = start; i < start + wyc; i++)
            {
                dowyc += tekst[i];
            }

            int[] dane = new int[] { 4, 5, 15, 21, 3, 123, 80, 725, 1, 14 };
            int temp;
            for (int i = 0; i < dane.Length; i++)
            {
                for (int j = 0; j < dane.Length; j++)
                {
                    if (i != j)
                    {
                        if (dane[i] < dane[j])
                        {
                            temp = dane[i];
                            dane[i] = dane[j];
                            dane[j] = temp;
                        }
                    }
                }
            }
        }
    }
 }
