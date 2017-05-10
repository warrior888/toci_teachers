using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static char[] CharsArr { get; private set; }
        public static int DigitCount { get; private set; }

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
            string userInput = Console.ReadLine();

            CharsArr = userInput.ToCharArray();

            var tasks = new[]
                    {
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc znaków: " + userInput?.Length)),
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc liter: " + CharsArr.Where(z => char.IsLetter(z)).Count())),
                        Task.Factory.StartNew(() => Console.WriteLine("ilosc cyfr: " + CharsArr.Where(z => char.IsDigit(z)).Count())),
                        Task.Factory.StartNew(() => IncreaseDigits())
                    };
            Task.WaitAll(tasks);
            Console.WriteLine("ilosc cyfr z zakresu 2-9: " + DigitCount);
            Console.WriteLine("Nowy tekst: {0}", new string(CharsArr));
            Console.ReadLine();
        }

        private static int IncreaseDigits()
        {
            for (int i = 0; i < CharsArr.Length; i++)
            {
                string s = CharsArr[i].ToString();
                if (char.IsDigit(CharsArr[i]) && int.Parse(s) >= 2 && int.Parse(s) <= 9)
                {
                    int cyfra = int.Parse(s);
                    DigitCount++;
                    CharsArr[i] = char.Parse((--cyfra).ToString());
                }
            }
            return DigitCount;
        }
    }
}
