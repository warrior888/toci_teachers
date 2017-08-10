using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_08_2017_1_1_jazda
{
    class Program
    {
        static void Main(string[] args)
        {
            int licz = 6;
            string imie = "piotr";
            licz = 9;
            Console.WriteLine("liczba calkowita, zmiena licz rowna sie {0}, {1}", licz, imie);
            int liczbaCalkowita = 10;
            bool zmiennaLogiczna = liczbaCalkowita == 10;
           
            for (int i = 0, j = 9; i < j || j < i; i++, j++)

            {
                Console.WriteLine("wartosc i = {0} j = {1}",i,j);
                string text =  Console.ReadLine();
                
            }

            //Console.WriteLine("wprowadziles : {0}",text);
            Console.ReadLine();

        }
    }
}
