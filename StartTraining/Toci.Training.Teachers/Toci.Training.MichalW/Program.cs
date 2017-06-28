using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.MichalW
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Podaj słowo : ");

             string InputWord = Console.ReadLine();

             ASCIIEncoding ascii = new ASCIIEncoding();

             Byte[] ASCIIValues = ascii.GetBytes(InputWord);
             foreach (var Number in ASCIIValues)
             {
                 if (Number >= 97 && Number <= 122)
                 {

                     int result = Number - 32;
                     result = Convert.ToByte(result);


                     Console.WriteLine("[{0}]", result);
                     Console.WriteLine();
                     String decoded = ascii.GetString(ASCIIValues);
                     Console.WriteLine("Decoded string: '{0}'", decoded);

                    // Nie pokazuje duzych liter mimo zmiany kodu ASCII...
                 }
             }



             Console.ReadKey();*/

            Console.Write("Ilu elementowa ma być Twoja tablica : ");
            string InputUser = Console.ReadLine();
            int UserInputNumber = 0;
            int.TryParse(InputUser, out UserInputNumber);
            int[] example = new int[UserInputNumber];

            string[] Table = new string[UserInputNumber];
            int number = Table.Length;

            for (int i = 0; i < number; i++)
            {
                Console.Write("\nPodaj element nr " + (i + 1) + ": ");
                Table[i] = Console.ReadLine();

                if (number - 1 == i)
                {
                    Console.WriteLine("\nUzupełniłeś swoją tablicę !");
                }
            }
            Console.WriteLine("\nElementy Twojej tablicy :");

            for (int i = 0; i < number; i++)
            {
                Console.Write(" " + (i + 1) + "." + Table[i]);
            }
            Console.ReadKey();
        }
    }
}
