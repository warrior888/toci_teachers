using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.WojciechSeweryn
{

    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------
            ---------------SAPER-----------------
            ------------------------------------*/

            //Stan poczatkowy gry
            int? FillTable(int[,] tableToFill)
            {
                for (int i = 0; i < tableToFill.GetLength(0); i++)
                {
                    for (int j = 0; j < tableToFill.GetLength(1); j++)
                    {
                        tableToFill[i, j] = 0;
                    }
                }
                return null;
            }
            
            //Wyswietlanie tablicy
            int? ViewTable(int[,] tableToView)
            {
                for (int i = 0; i < tableToView.GetLength(0); i++)
                {
                    for (int j = 0; j < tableToView.GetLength(1); j++)
                    {
                        Console.Write(" " + tableToView[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return null;
            }

            //Losowe rozmieszczanie bomb + ustawienia odp wartosci na pozostalych polach
            int? Bombs(int[,] tableToFill)
            {
                Console.Write("Podaj ilosc bomb: ");
                int bombsQuantity = Convert.ToInt32(Console.ReadLine());

                int rowsBomb = 0;
                int columnBomb = 0;
                Random rnd = new Random();
                while (bombsQuantity > 0) // petla zdana na los xd - chyba malo optymalna :(
                {
                    rowsBomb = rnd.Next(0, tableToFill.GetLength(0));
                    columnBomb = rnd.Next(0, tableToFill.GetLength(1));

                    if (tableToFill[rowsBomb, columnBomb] != -1)    //Nie dublujemy bomb 
                    {
                        tableToFill[rowsBomb, columnBomb] = -1;
                        /*1 bomba -> 8 mozliwych ulozen: 
                        
                         TOP-LEFT   TOP     TOP-RIGHT
                         LEFT       (-1)    RIGHT
                         DOWN-LEFT  DOWN    DOWN-RIGHT
                                                  
                        */
                        
                        for (int j = -1; j <= 1; j++)
                        {
                            for (int k = -1; k <= 1; k++)
                            {
                                //warunki brzegowe planszy - pomijamy iteracje
                                if (rowsBomb + j < 0 || columnBomb + k < 0) continue; 
                                if (rowsBomb + j > tableToFill.GetLength(0) - 1 ||
                                    columnBomb + k > tableToFill.GetLength(1) - 1) continue;

                                //pole z bomba - pomijamy iteracje
                                if (tableToFill[rowsBomb + j, columnBomb + k] == -1) continue;

                                //trafilismy na jedno z 8 mozliwych ulozen -> inkrementacja
                                tableToFill[rowsBomb + j, columnBomb + k] += 1;
                            }
                        }
                        bombsQuantity--;
                    }
                }
                return null;
            }

            void Saper()
            {
                int rows = 0;
                int column = 0;

                while (rows <= 0)
                {
                    Console.Write("Podaj ilosc wierszy: ");
                    rows = Convert.ToInt32(Console.ReadLine());
                    if (rows <= 0)
                    {
                        Console.WriteLine("Ilosc wierszy musi byc wieksza od 0!");
                    }
                }
                
                while (column <= 0)
                {
                    Console.Write("Podaj ilosc kolumn: ");
                    column = Convert.ToInt32(Console.ReadLine());
                    if (column <= 0)
                    {
                        if (column <= 0)
                        {
                            Console.WriteLine("Ilosc kolumn musi byc wieksza od 0!");
                        }
                    }
                }

                int[,] table2D = new int[rows, column];
                
                Console.WriteLine("Okay, Twoja czysta plansza: ");
                FillTable(table2D); 
                ViewTable(table2D);
                Bombs(table2D);
                ViewTable(table2D);
             }

             Saper();

            /*-----------------------------------
            ------PODSTAWOWE ZADANIA DOMOWE------
            ------------------------------------*/
            void TableOfStrings()
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

            TableOfStrings();

            void ChangeSizeLetters()
            {
                Console.WriteLine("ZMIANA WIELKOSCI LITER: ");
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
                Console.WriteLine();
            }

            ChangeSizeLetters();

            int[] table = new[] { 3, 56, 3, 5, 78, 9, 78, 4, 3, 567, 8 };

            Console.WriteLine("\nDla ponizszej tablicy o wartosiach: ");
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write(table[i]+" ");
            }
            
            int MaxValue(int[] tab)
            {
                int temp = tab[0];
                for (int i = 1; i < tab.Length; i++)
                {
                    if (temp < tab[i])
                    {
                        temp = tab[i];
                    }
                }
                return temp;
            }

            int MinValue(int[] tab)
            {
                int temp = tab[0];
                for (int i = 1; i < tab.Length; i++)
                {
                    if (temp > tab[i])
                    {
                        temp = tab[i];
                    }
                }
                return temp;
            }

            int SumTableValues(int[] tab)
            {
                int sum = 0;
                for (int i = 0; i < tab.Length; i++)
                {
                    sum += tab[i];
                }
                return sum;
            }

            int? CountElement(int[] tab)
            {
                int counter = 0;
                Console.Write("Podaj wartosc, by dowiedziec sie ile razy wystepuje w tablicy: ");
                int value = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < tab.Length; i++)
                {
                    if (value == tab[i])
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
                return null;
            }

            Console.WriteLine("\nNajwieksza wartosc w tablicy to: " + MaxValue(table));
            Console.WriteLine("\nNajmniejsza wartosc w tablicy to: " + MinValue(table));
            Console.WriteLine("\nSuma elementow tablicy wynosi: " + SumTableValues(table));
            Console.WriteLine(CountElement(table));

            Console.ReadLine();
        }
    }
}