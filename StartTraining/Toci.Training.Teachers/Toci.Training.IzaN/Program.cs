using System;

namespace Toci.Training.IzaN
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = CharToUppercase(34);
            Console.WriteLine(a);
            string b = GetText(8);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        static string CharToUppercase(int input)
        {
            string output = Char.ConvertFromUtf32(input);
            return output.ToUpper();
        }

        static string GetText(int numOfChars)
        {
            string[] textArray = new string[numOfChars];
            Console.WriteLine("Write me something");
            string getText = Console.ReadLine();
            var chars = getText.ToCharArray();
            if (chars.Length >= textArray.Length)
            {
                return "Array is full";
            }
            return "Array is not full";

        }
    }
}

