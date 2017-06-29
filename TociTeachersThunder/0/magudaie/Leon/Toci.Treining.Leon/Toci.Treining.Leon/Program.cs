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
            string text = "TO CI dopiero";

            Byte[] encodeBytes = ascii.GetBytes(text);
            Console.WriteLine(text);
            Console.WriteLine("The encoding: ");

            int j = 0;
            foreach (byte b in encodeBytes)
            {
                byte a = 0; // zmienilem zmienna INT na BYTE
                if (b >= 97 && b <= 122)
                {
                    a = b;
                    a -= 32;
                    //a = Convert.ToByte(a); // to juz nie potrzebne
                }
                else 
                {
                    a = b;
                }
                Console.WriteLine("Mala litera: [{0}]", b);
                Console.WriteLine("Duza litera: [{0}]", a);
                encodeBytes[j] = a; // dzieki Kafar!!!!
                j++;
                //string decodestring = ascii.GetString(a); // to w ogole nie jest potrzebne
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

            int NajmniejszaLiczba = TablicaFor[0];
            for(int i = 0; i < TablicaFor.Length; i++)
            {
                if(NajmniejszaLiczba > TablicaFor[i])
                {
                    NajmniejszaLiczba = TablicaFor[i];
                }
            }
            Console.WriteLine(NajmniejszaLiczba);

            // ilosc wystapien

            Console.WriteLine("Podaj jaka liczbe bedziemy sprawdzac: ");
            string FromUser = Console.ReadLine();
            int IntFromUser = 0;
            int.TryParse(FromUser, out IntFromUser);
            int occurence = 0;

            for (int i = 0; i < TablicaFor.Length; i++)
            {
                if(IntFromUser == TablicaFor[i])
                {
                    occurence++;
                }
            }
            Console.WriteLine("Liczba {0} wystepuje w tej tablicy {1} razy", IntFromUser, occurence);

            Console.ReadLine();
        }
    }
}
