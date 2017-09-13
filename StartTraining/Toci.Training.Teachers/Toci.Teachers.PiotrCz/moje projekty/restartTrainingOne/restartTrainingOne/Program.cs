using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restartTrainingOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaCAlkowita = 5;
            double liczbaZmiennoprezcinkowa = 4.5;
            float TezliczbaZmiennoprezcinkowa = 4.5f;
            bool zmiennaLogiczna = true;
            string imie = "bartek";// odwrocony strong bartek
            char JedenZnaczek = 'b';
            char[] tablica = new[] {'b', 'a', 'r','t','e','k',' ','i',' ', 'b','e','a','t','k','a'};
            //dlugosc tablicy char

            int bezwartosci;
            bezwartosci = 8;// przypisanie
            
            if (bezwartosci <= 8 && bezwartosci >=16)
            {
                Console.WriteLine(bezwartosci);
                }
            else
            {
                Console.WriteLine("psikus");
            }
            Console.WriteLine("dlugosc tablicy znakow : " + tablica.Length);//dlugosc tablicy char
            string result = ""; //sklejona tablica znakow
            for (int j = imie.Length-1; j >= 0; j--)// odwrocony strong bartek
            {
                Console.WriteLine(imie[j]); // odwrocony strong bartek
            }

            for (int i = 0; i < tablica.Length; i++)//sklejona tablica znakow
            {
                result += tablica[i];//sklejona tablica znakow
            }
            Console.WriteLine("sklejona tablica znakow : " + result);//sklejona tablica znakow
            Console.ReadLine();
        }
    }
}
