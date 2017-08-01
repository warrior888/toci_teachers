using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Zadanie_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wpisz zdanie.");
            string sentence = Console.ReadLine(); // sentence = Ala ma kota.

            Console.WriteLine("Wpisz poszukiwane słowo a otrzymasz numer indeksu, w którym się ono zaczyna.");
            string word = Console.ReadLine(); // word = kot

            for (int i = 0; i < sentence.Length; i++)
            {

                if (word[0] == sentence[i]) // --> pod indeksem i mam literę k
                {
                    int counter = 1; // 1 bo jedna litera juz trafiona
                    for (int j = 1; j < word.Length; j++)
                    {
                       
                        if (word[j] == sentence[i+j])
                        {
                            counter = counter + 1;
                        }
                    }

                    if (counter == word.Length)
                    {
                        Console.WriteLine(i);
                    }

                }

            }
            Console.ReadLine();

        }
    }
}
