using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.LeszekS
{
	class Program
	{

        static string Wieksze(string dane )
        {
            char[] cos ;
            cos = dane.ToCharArray();
            for (int i = 0; i < dane.Length; i++)
            {
                if ((int)dane[i] < 65 || (int)dane[i] > 90)
                {
                    int tmp = (int)dane[i];
                    tmp -= 32;
                    cos[i]= (char)tmp;
                }
            }
            return new string (cos);
        }

        static string Mniejsze(string dane)
        {
            char[] cos;
            cos = dane.ToCharArray();
            for (int i = 0; i < dane.Length; i++)
            {
                if (97> (int)dane[i] || (int)dane[i]> 122)
                {
                    int tmp = (int)dane[i];
                    tmp += 32;
                    cos[i] = (char)tmp;
                }
            }
            return new string(cos);
        }



        static void Main(string[] args)
		{
            

            string dane = "BArtekZ";
            //Powiększa
            Console.WriteLine(Mniejsze(dane));
            Console.WriteLine(Wieksze(dane));
            Console.ReadKey();


        }
    }
}
