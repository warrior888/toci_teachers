using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Zadanie_TablicaWywolywanieTekstu
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //**create table of given size
            Console.WriteLine("Proszę podaj słowa, które mają znależć się w słowniku oddzielone od siebie ',' bez spacji:");
            string slowa = Console.ReadLine();
            string[] slownik = slowa.Split(',');
            int size = slownik.Length;
            //**

            Console.WriteLine("Co chcesz uzyskać? Wpisz numer słowa, wpisz zakres numer-numer lub wpisz 'wszystko'.");
            string wynik = Console.ReadLine();

            string[] zakres = wynik.Split('-');

            if (wynik == "wszystko")
            {
                for (int i = 0; i < size; i = i + 1)
                {
                    Console.Write(slownik[i] + ",");
                }
            }
            //wynik = "5"
            //zakres[0]="5"
            else if (zakres.Length == 1 && slownik.Length > int.Parse(zakres[0]))
            {
                Console.WriteLine(slownik[int.Parse(zakres[0])-1]); //slownik["5"] -> int.Parse("5") - > slownik[5] 
            }
            //wynik = "100-200"
            // "100", "200" -> zakres[0] = "100", zakres[1] = "200"
            else if (zakres.Length == 2 && slownik.Length > int.Parse(zakres[0]))
            {
                for (int i = int.Parse(zakres[0]); i <= int.Parse(zakres[1]); i = i + 1)
                {
                    Console.Write(slownik[i-1] + ", ");
                }
            }

           Console.ReadLine();

            
        }
    }
}
