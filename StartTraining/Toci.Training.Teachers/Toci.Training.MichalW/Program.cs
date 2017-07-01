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
            /*-----------------------------------------------------------------------------------------------------
             //Zadanie 0 : Zamiana małych liter na duże
              
             Console.WriteLine("Podaj słowo : ");

             string InputWord = Console.ReadLine();

             ASCIIEncoding ascii = new ASCIIEncoding();

             Byte[] ASCIIValues = ascii.GetBytes(InputWord);
            int One = 0;
            foreach (byte Number in ASCIIValues)
            {
                byte a = 0; // zmiana zmiennej int na byte
                if (Number >= 97 && Number <= 122)
                {
                    a = Number;
                    a -= 32;
                }
                else
                {
                    a = Number;
                }
                //Console.WriteLine("Mala litera: [{0}]", Number);
                //Console.WriteLine("Duza litera: [{0}]", a);
                ASCIIValues[One] = a;
                One ++;
            }
            String decoded = ascii.GetString(ASCIIValues);
                     Console.WriteLine("Decoded string : " + decoded);

                    
             Console.ReadKey();   */

            /* ---------------------------------------------------------------------------------------------
             * Zad 1 : Tablica i pokazanie jej elementów
             *
             * Console.Write("Ilu elementowa ma być Twoja tablica : ");
             string InputUser = Console.ReadLine();
             int UserInputNumber = 0;
             int.TryParse(InputUser, out UserInputNumber);
             int[] example = new int[UserInputNumber];

             string[] Table = new string[UserInputNumber];
             int number = Table.Length;

             for (int i = 0; i < number; i++)
             {
                 Console.Write("\nPodaj element nr " + (i + 1) + ": ");
                 Table[i] = Console.ReadLine();

                 if (number - 1 == i)
                 {
                     Console.WriteLine("\nUzupełniłeś swoją tablicę !");
                 }
             }
             Console.WriteLine("\nElementy Twojej tablicy :");

             for (int i = 0; i < number; i++)
             {
                 Console.Write(" " + (i + 1) + "." + Table[i]);
             }
             Console.ReadKey();  */


int[] Tablle = new int[11];
Tablle[0] = 3;
Tablle[1] = 56;
Tablle[2] = 3;
Tablle[3] = 5;
Tablle[4] = 78;
Tablle[5] = 9;
Tablle[6] = 78;
Tablle[7] = 4;
Tablle[8] = 3;
Tablle[9] = 567;
Tablle[10] = 8; 

//int[] Tablle = new int[] {3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8};   << Można też tak w 1 linii

// 1. Pokazanie najwyższej wartości z tej tabeli :

//  int Max = Tablle.Max();  << Metoda szybka z funkcji wbudowanej

int Biggest = Tablle[0];
for (int i = 1; i < Tablle.Length; i++)
{
    if (Biggest < Tablle[i])
    {
        Biggest = Tablle[i];

    }
}
Console.WriteLine("Najwyższa wartość z tej tablicy to : " + Biggest);

//----------------------------------------------------------------------------------------------------------
// 2. Pokazanie najniższej wartości z tej tabeli :

//  int Min = Tablle.Min(); << Metoda szybka z funkcji wbudowanej

int Smallest = Tablle[0];

for (int i = 1; i < Tablle.Length; i++)
{
    if (Smallest > Tablle[i])
    {
        Smallest = Tablle[i];
    }
}

Console.WriteLine("Najmniejsza wartość z tej tablicy to : " + Smallest);

//-------------------------------------------------------------------------------------------
// 3. Pokazanie sumy wartości z tablicy :

// int Total = Tablle.Sum();  << Metoda szybka z funkcji wbudowanej

int Total = 0;

for (int i = 0; i < Tablle.Length; i++)
{
    Total += Tablle[i];
}

Console.WriteLine("Suma wartości z tej tablicy to : " + Total);

// ---------------------------------------------------------------------
// 4. Pokazanie ilości wystąpień danego elementu :

Console.WriteLine("\nElementy Twojej tablicy :");

for (int i = 0; i < Tablle.Length; i++)
{
    Console.Write(" " + (i + 1) + "." + Tablle[i]);
}
Console.Write("\nIlość którego elementu pokazać : ");
string UserNumber = Console.ReadLine();
int NumberOfAppearances = 0;
int.TryParse(UserNumber, out NumberOfAppearances);

int Result = 0;

for (int i = 0; i < Tablle.Length; i++)
{
   if (NumberOfAppearances == Tablle[i])
    {
        Result ++;
    }
}
Console.WriteLine("Element " + UserNumber + " pojawił się : " + Result + " raz(y)");

Console.ReadKey(); 
}
}
}
