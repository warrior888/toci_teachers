using System;

namespace Toci.Training.WojciechSeweryn
{
    public class TableOperations
    {
        public void TalbeOfStrings()
        {
            string[] tableOfStrings = new string[10];

            for (int i = 0; i < tableOfStrings.Length; i++)
            {
                Console.Write("Prosze podaj " + (i + 1) + " linie tekstu, a ja wpisze ja do tablicy: ");
                tableOfStrings[i] = Console.ReadLine();
                if (i == tableOfStrings.Length - 1)
                {
                    Console.WriteLine("No i sie skonczylo\n");
                }
            }
        }

        public void ChangeSizeLetters(string sizeLetter)
        {
            Console.WriteLine("Zamieniona wielkosc liter: ");
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
            Console.WriteLine();
        }

        public int MaxValue(int[] table)
        {
            int temp = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (temp < table[i])
                {
                    temp = table[i];
                }
            }
            return temp;
        }

        public int MinValue(int[] table)
        {
            int temp = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (temp > table[i])
                {
                    temp = table[i];
                }
            }
            return temp;
        }

        public int SumTableValues(int[] table)
        {
            int sum = 0;
            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }
            return sum;
        }

        public void CountElement(int[] table)
        {
            int counter = 0;
            Console.Write("Podaj wartosc, by dowiedziec sie ile razy wystepuje w tablicy: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < table.Length; i++)
            {
                if (value == table[i])
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine("Poszukiwany element wystepuje " + counter + " raz/razy w tablicy");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego elementu w tablicy!");
            }
        }

        public string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i < start + length && i<candidate.Length; i++)
            {
                result += candidate[i];
            }
            return result;
        }

        public int IndexOf(string candidate, string search) //bartek szkoli programistow, szkoli -> 7
        {
            int start = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                string substring = Substring(candidate, i, search.Length);
                if (substring == search)
                {
                    start = i;
                }
            }
            return start;
        }
    }
}