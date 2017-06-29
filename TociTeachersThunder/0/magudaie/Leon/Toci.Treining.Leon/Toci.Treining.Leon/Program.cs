using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Treining.Leon
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            string text = "tat";

            Byte[] encodeBytes = ascii.GetBytes(text);
            Console.WriteLine(text);
            Console.WriteLine("The encoding: ");

            foreach (byte b in encodeBytes)
            {
                int a = 0;
                if (b >= 97 && b <= 122)
                {
                    ; a = b;
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
            Console.WriteLine(decodeString);

            // zadanie z tablica - wpisac dane z forem

            int[] TablicaFor = new int[10];

            Console.WriteLine(TablicaFor.Length);

            for(int i = 0; i < TablicaFor.Length; i++)
            {
                Console.WriteLine("Podaj numer dla tablicy {0}", i + 1);
                string Input = Console.ReadLine();
                int InputToInt = 0;
                int.TryParse(Input, out InputToInt);
                TablicaFor[i] = InputToInt;
            }

            for(int i = 0; i < TablicaFor.Length; i++)
            {
                Console.WriteLine("Tablica od {0} ma numer {1}", i + 1, TablicaFor[i]);
            }

            // summa wszystkich elementow

            int Summa = 0;
            for (int i = 0; i < TablicaFor.Length; i++)
            {
                Summa += TablicaFor[i];
            }
            Console.WriteLine(Summa);

            // znalezc maksymalna wartosc

            int NajwiekszaLiczba = 0;
            for(int i = 0; i <TablicaFor.Length; i++)
            {
                if(NajwiekszaLiczba < TablicaFor[i])
                {
                    NajwiekszaLiczba = TablicaFor[i];
                }
            }
            Console.WriteLine(NajwiekszaLiczba);

            // znalezc minimalna wartosc



            Console.ReadLine();
        }
    }
}
