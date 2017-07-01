
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Peter
{
    class Program
    {
        static void Main(string[] args)
        {
            string toLower(string text)
            {
                string corektLow = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int myAsci = (int)text[i];

                    if (myAsci >= 65 && (myAsci <= 90))
                    {
                        myAsci += 32;
                    }
                    corektLow += (char)myAsci;
                }
                return corektLow;
            }



            string toHigher(string text)
            {
                string corekt = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int myAsci = (int)text[i];
                    if (myAsci >= 97 && (myAsci <= 122))
                    {
                        myAsci -= 32;
                    }
                    corekt += (char)myAsci;
                }
                return corekt;
            }

            string[] giveItToTable(int sizeOfTable)
            {
                string[] table = new string[sizeOfTable];
                
                for (int i = 0; i < sizeOfTable; i++)
                {
                    int stop = i + 1;


                    Console.WriteLine("wprowadź element tablicy");
                    table[i] = Console.ReadLine();
                    Console.WriteLine("\n" + "aktualnie tablica zawiera" + stop + "elementów");


                    if (stop == sizeOfTable)
                    {
                        Console.WriteLine("dzięki tablica jest pełna, jak chcesz zobaczyć zawartość wciśnij: 1");
                        if (Console.ReadLine() == "1")
                        {
                            for (int j = 0; j < sizeOfTable; j++)
                            {
                                Console.WriteLine(table[j]);
                            }

                        }
                    }
                }
                Console.ReadLine();
                return table;
            }

            toLower("AlA ma KoTAAAa");
            toHigher("a KOt Ma alEEEe");
            giveItToTable(5);
            Console.ReadLine();
        }
    }
}
