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
           Console.WriteLine("Podaj słowo : ");

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


                
            
        }
    }
}
