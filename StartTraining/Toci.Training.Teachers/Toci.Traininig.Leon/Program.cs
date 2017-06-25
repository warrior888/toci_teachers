using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Traininig.Leon
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            string text = "t";

            Byte[] encodeBytes = ascii.GetBytes(text);
            Console.WriteLine(text);
            Console.WriteLine("The encoding: ");

            
            foreach(byte b in encodeBytes)
            {
                int a = 0;
                if (b >= 97 && b <= 122)
                {
                    a = b;
                    a -= 32;
                    a = Convert.ToByte(a);
                    //... wymyslec
                }
                Console.Write("[{0}]", b);
                Console.WriteLine();
                Console.Write("[{0}]", a);
                //char decodestring = ascii.GetString(a); // i jak to obejsc?
            }
            Console.WriteLine();

            string decodeString = ascii.GetString(encodeBytes);
            Console.WriteLine("Decodeing: ");
            Console.Write(decodeString);

            Console.ReadLine();
        }
    }
}
