using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.JanekK
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 zadanko z wpisywania textu do tablicy 

            Console.WriteLine("Podaj jakis text 10cio literowy: ");
            string textFromUser = Console.ReadLine(); 
            int[] array = new int[10];

            for(int i = 0; i <= array.Length; i++)
            {
                if (i < array.Length)
                {
                    array[i] = textFromUser[i];
                    char element = (char)array[i];
                    Console.WriteLine(i + " element tablicy: " + element);
                }
            }
            
            //2 zadanko znalezc max wartosc tablicy
            
            int[] array = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };
            int maxValue = array[0]; 

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                
            }
            Console.WriteLine("najwyzsza wartosc to: " + maxValue);

            //3 znalezc minimalna wartosc tablicy

            int[] array = { 3, 56, 1, 5, 78, 9, 78, 4, 3, 567, 8 };
            int minValue = array[0]; 

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
                
            }
            Console.WriteLine("najnizsza wartosc to: " + minValue);

            //4 zadanko zsumowac wszystkie elementy tablicy

            int[] array = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8, 5 };
            int result = 0;

            for(int i = 0; i < array.Length; i++)
            {               
                result += array[i];
            }
            Console.WriteLine("suma elementów tablicy: " + result);

            //5 wyszukac powtarzalnosc elementow

            int[] array = { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8, 5 };
            int number = 0;
            int repeatOfNumber = 0;

            Console.WriteLine("wprowadz liczbe i sprawdz ile razy powtarza sie dany element tablicy: ");
            Int32.TryParse(Console.ReadLine(), out number);

            for (int i = 0; i < array.Length; i++)
            {               
                if(number == array[i])
                {
                    repeatOfNumber++;
                }
            }
            Console.WriteLine("liczba wystapien danej cyfry w tablicy: " + repeatOfNumber);

            ///////////////////////////////////////////////////
        }
    }
}
