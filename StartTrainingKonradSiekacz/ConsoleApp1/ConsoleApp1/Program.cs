using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int komputery = 24;
            int studenci;
            double wynik;
            Console.WriteLine("Podaj liczbę studentów: ");
            studenci = int.Parse(Console.ReadLine());
            wynik = (double)studenci / komputery;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
