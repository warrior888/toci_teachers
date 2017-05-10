using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static string _test;
        static char[] _charsArr;
        static int _digitCount = 0;

        /*
         Napisać program, w którym należy pobrać łańcuch znaków, a następnie wyświetlić długość łańcucha oraz liczbę liter (alfabetu łacińskiego), 
         a także liczbę (nie sumę) występujących w podanym łańcuchu cyfr z zakresu 2-9. 
         Dodatkowo należy w tym łańcuchu liczby z zakresu 2-9 zmniejszyć o 1.
        Przykładowy wynik dla łańcucha „Dzisiejsza data 04.05.2017””:
                Nowy łańcuch: „Dzisiejsza data 03.04.1016””:
             
             
             */


        static void Main(string[] args)
        {
            Console.WriteLine("wprowadz tekst:");
            _test = Console.ReadLine();
            _charsArr = _test.ToCharArray();

            var tasks = new[]
                    {
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc znaków: " + _test?.Length)),
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc liter: " + _charsArr.Where(z => char.IsLetter(z)).Count())),
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc cyfr: " + _charsArr.Where(z => char.IsDigit(z)).Count())),
                        Task.Factory.StartNew(() => IncreaseDigits())
                    };
            Task.WaitAll(tasks);
            Console.WriteLine("ilosc cyfr z zakresu 2-9: " + _digitCount);
            Console.WriteLine("Nowy tekst: {0}",  new string(_charsArr));
            Console.ReadLine();
        }

        private static int IncreaseDigits()
        {
            for (int i = 0; i < _charsArr.Length; i++)
            {
                string znak = _charsArr[i].ToString();
                if (char.IsDigit(_charsArr[i]) && int.Parse(znak) >= 2 && int.Parse(znak) <= 9)
                {
                    int cyfra = int.Parse(znak);
                    _digitCount++;
                    _charsArr[i] = char.Parse((--cyfra).ToString());
                }
            }
            return _digitCount;
        }
    }
}
