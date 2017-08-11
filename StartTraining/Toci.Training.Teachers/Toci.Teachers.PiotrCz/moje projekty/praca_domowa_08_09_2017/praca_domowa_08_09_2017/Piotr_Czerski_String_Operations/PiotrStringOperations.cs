using System;
using System.Runtime.InteropServices;

namespace praca_domowa_08_09_2017.Piotr_Czerski_String_Operations
{
    public class PiotrStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string return1 = "";
            for (int i = start; i < start + length; i++)
            {

               // return1 += candidate[i];
                //  Console.WriteLine("zwracam = {0}", return1);

            }
            return "";
        }

        public override string Getname()
        {
            string name = "Piotr Czerski";
            // Console.Write(name);
            {
                return name;
            }
        }

        //2
        public override string GlueBeginingEnd(string candidate)
        {
            string returnik = "";
            for (int i = 0, j = candidate.Length - 1; i <= j; i++, j--)
            {
                returnik += candidate[i];
                returnik += candidate[j];

            }
            // Console.WriteLine(returnik);
            return "";
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int count = 0;
            for (int i = 0; i < candidate.Length; i++)
            {

                if (candidate[i] == needle)
                {
                    count += 1;
                    // Console.WriteLine("W stringu bartek jest " + count + " literka/literki a" );
                }
            }
            return count;
        }

        public override int LetterPositionInString(string candidate, char needle, char replace)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                    return i;
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string returnReplace = "";
            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    returnReplace += replace;
                    i += needle.Length -1;
                    
                }
                else
                {
                    returnReplace += candidate[i];
                }
            }
            
            return returnReplace;

        }
    }
}
               
            
  