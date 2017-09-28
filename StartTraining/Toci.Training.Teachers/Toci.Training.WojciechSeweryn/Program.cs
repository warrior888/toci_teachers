using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.WojciechSeweryn
{

    class Program
    {
        
        static void Main(string[] args)
        {
            MoneyValue moneyTEST = new MoneyValue();
            moneyTEST.GetMoneyValue("666666666");

            PeselValidator peselTest = new PeselValidator();
            peselTest.IsPeselValid("91090702398");

            /*
            Saper example = new Saper();
            example.SaperGame();
            */

            QuizLogic exampleQuiz = new QuizLogic();
            exampleQuiz.Load();



            int[] exampleTable = new[] { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
            
            TableOperations tableOp = new TableOperations();
            
            tableOp.IndexOf("bartek szkoli programistow", "szkoli");

            Console.WriteLine("Podaj wyraz do zamiany wielkosci liter: ");
            string SizeLetter = Console.ReadLine();
            tableOp.ChangeSizeLetters(SizeLetter);
            
            int MaxTable = tableOp.MaxValue(exampleTable);
            Console.WriteLine("Maksymalna wartosc w tablicy: " + MaxTable);

            int MinTable = tableOp.MinValue(exampleTable);
            Console.WriteLine("Minimalna wartosc w tablicy: " + MinTable);

            int SumTable = tableOp.SumTableValues(exampleTable);
            Console.WriteLine("Suma wartosci w tablicy: " + SumTable);

            tableOp.CountElement(exampleTable);

            Console.ReadLine();

        }
    }
}