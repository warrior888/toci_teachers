using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodstawyUpToAbstraction.Model;

namespace PodstawyUpToAbstraction
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");

            var myCalc = new calc();
            myCalc.Sum(1, 1);
          
            Console.ReadKey();
        }
        /// <summary>
        /// this is sum
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

    }
}
