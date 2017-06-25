using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Kafar
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            string text = "taras";

            Byte[] encodeBytes = ascii.GetBytes(text);
            Console.WriteLine(text);
            Console.WriteLine("The encoding: ");
            int i = 0;
            foreach (byte b in encodeBytes)
            {
                int a = 0;

                if (b >= 97 && b <= 122)
                {
                    ;
                    a = b - 32;
                    a = Convert.ToByte(a);
                    //... wymyslec
                }
                else
                {
                    a = b;
                }
                Console.WriteLine("Mała litera = [{0}]", b);
                Console.WriteLine("Duża litera = [{0}]", a);
                Console.WriteLine();
                encodeBytes[i] = (byte)a;
                // i jak to obejsc?
                i++;
            }
            Console.WriteLine();

            string decodeString = ascii.GetString(encodeBytes);
            Console.WriteLine("Decodeing: ");
            Console.Write(decodeString);

            Console.ReadLine();
        }
    }
}
