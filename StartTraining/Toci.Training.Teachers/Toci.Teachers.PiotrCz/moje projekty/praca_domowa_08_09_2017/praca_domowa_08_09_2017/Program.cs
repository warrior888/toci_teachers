using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using praca_domowa_08_09_2017.Piotr_Czerski_String_Operations;

namespace praca_domowa_08_09_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PiotrStringOperations strOp = new PiotrStringOperations();
           
            //public abstract int CountOccurences(string candidate, char needle);
            strOp.CountOccurences("bartaeka", 'a');
           
            //ublic override string Getname()
            strOp.Getname();
          
            // public abstract string GlueBeginingEnd(string candidate);
            strOp.GlueBeginingEnd("beatka");

            //public abstract int LetterPositionInString(string candidate, char needle, char replace);
            strOp.LetterPositionInString("beatka", 'e', 's');

            
            //public abstract string Substring(string candidate, int start, int length);
            strOp.Substring("beatka", 1, 3);

            // public abstract string StringReplace(string candidate, string needle, string replace);
            strOp.StringReplace("bartlomiej", "art", "beatka");

            Console.ReadLine();
        }
    }
}
