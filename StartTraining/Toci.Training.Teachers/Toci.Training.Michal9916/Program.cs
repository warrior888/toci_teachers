using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Michal9916
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracja zmiennych
            int ileKonwersja = 0;
            int gornyPrzedzialKonwersja = 0;
            int dolnyPrzedzialKonwersja = 0;
            Random gen = new Random();

            //zapytanie o liczbe elementow tablicy oraz przedzial liczbowy
            System.Console.WriteLine("Podaj liczbe elementow tablicy: ");
            string ile = Console.ReadLine();
            int.TryParse(ile, out ileKonwersja);

            System.Console.WriteLine("Podaj pierwsza liczbe przedzialu: ");
            string dolnyPrzedzial = Console.ReadLine();
            int.TryParse(dolnyPrzedzial, out dolnyPrzedzialKonwersja);

            Console.WriteLine("Podaj druga liczbe przedzialu: ");
            string gornyPrzedzial = Console.ReadLine();
            int.TryParse(gornyPrzedzial, out gornyPrzedzialKonwersja);

            //wpisanie liczb do tablicy
            int[] tab = new int[ileKonwersja]; // dynamiczna deklaracja tablicy
            for (int i = 0; i < ileKonwersja; i++)
            {
                tab[i] = gen.Next(dolnyPrzedzialKonwersja, gornyPrzedzialKonwersja);
                Console.Write("{0} ", tab[i]);
            }

            // szukanie najwiekszej i najmniejszej wartosci w tablicy
            int max = tab[0];
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            Console.WriteLine("Najwieksza wartosc w tablicy: {0} oraz najmniejsza wartosc w tablicy: {1}", max, min);

            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma = suma+tab[i];

            }
            Console.WriteLine("Suma wszystkich elementow tablicy {0}",suma);

            //ile powtorzen ma dana liczba
            Console.WriteLine("Liczbe wystapien ktorej liczby chcesz policzyc z zakresu od {0} do {1} ",dolnyPrzedzialKonwersja,gornyPrzedzialKonwersja);

            int licznik = 0;
            int szukanaKonwersja = 0;
            string szukana = Console.ReadLine();
            int.TryParse(szukana, out szukanaKonwersja);
            foreach (var item in tab)
            {
                if(item == szukanaKonwersja)
                licznik++;
            }
            Console.WriteLine("Ilosc wystapien {0}", licznik);
            int iletab2 = gornyPrzedzialKonwersja - dolnyPrzedzialKonwersja+1;
            int[] tab2= new int[iletab2];
            for (int i =dolnyPrzedzialKonwersja; i <= gornyPrzedzialKonwersja; i++)
            {
                tab2[i-dolnyPrzedzialKonwersja] = i;
            }
            int licznik2=0;
            for (int j = 0; j < tab2.Length; j++)
            {
                licznik2 = 0;
                for (int i = 0; i < tab.Length; i++)
                {   
                    if(tab2[j] == tab[i])
                    licznik2++;
                }
                Console.Write("{0} dla {1}\n", licznik2, tab2[j]);
            }
            Console.ReadLine();
        }
    }
}
