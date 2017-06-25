using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.WojciechSeweryn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableOfStrings = new string[10];

            for (int i = 0; i < tableOfStrings.Length; i++)
            {
                Console.WriteLine("Prosze podaj " + (i + 1) + " linie tekstu, a ja wpisze ja do tablicy: ");
                tableOfStrings[i] = Console.ReadLine();
                if (i == tableOfStrings.Length - 1)
                {
                    Console.WriteLine("No i sie skonczylo");
                }
            }

            //Zamiana liter na male/duze przy użyciu tablicy kodów ASCI
            Console.WriteLine("Poda wyraz: ");
            string sizeLetter = Console.ReadLine();

            for (int i = 0; i < sizeLetter.Length; i++)
            {
                if ((int)sizeLetter[i] >= 65 && (int)sizeLetter[i] <= 90)
                {
                    Console.Write((char)((int)(sizeLetter[i] + 32)));
                }
                else
                {
                    Console.Write((char)((int)(sizeLetter[i] - 32)));
                }
            }
            Console.ReadLine();
        }
    }
}
