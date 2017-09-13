using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace zadania_domowe__8.wskazowki__zadania_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableOne = new int[] { 3, 15, 28, 6, 81,4,123,15,444,2,1,5 };

            int maxymalnawartosc = 0;
           // int maxymalnawartosc = int.MinValue; startujemy od minimalnej a szukamy maksymalnej wartosci; to gdy szukamy maksymalnej wartosci 
           //a gdy szukamy minimalnej wartosci to wpisujemy na odwrot int minimalnawartosc = int.MaxValue;

            for (int i = 0; i < tableOne.Length; i++)

                if (maxymalnawartosc < tableOne[i])
                {
                    maxymalnawartosc = tableOne[i];
                }
           
            //     int summary = maxymalnawartosc;
          
            // czyli tak: do maxymalnej wartosci wpada pierwsza liczba z petli i potem petla leci po kolei i sprawdza czy kolejna liczba jest wieksza od tej maxymalnej
            // jezeli jest wieksza to ustala ja jako maxymalna i leci dalej az dojdzie do konca petli np na poczatku mamy liczbe 3  i jest ona w tej chwili najwieksza
            // ale nastepna liczba to juz 15 i ona staje sie ta maymalna wartoscia, reasumujac w tej petli nawieksza liczba to 444 i taki wynik uzyskalem
            // tutaj koncowka jest wyswietlana jako konsola ale i breakpointa tez wstawilem lecz okkomentowalem go

            Console.WriteLine("wyszlo to : " + maxymalnawartosc);

            Console.ReadLine();
        }
        
    }
}
