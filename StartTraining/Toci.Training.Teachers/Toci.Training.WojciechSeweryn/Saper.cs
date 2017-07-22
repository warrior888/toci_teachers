using System;

namespace Toci.Training.WojciechSeweryn
{
    public class Saper
    {
        //Stan poczatkowy gry
        public static void FillTable(int[,] tableToFill)
        {
            for (int i = 0; i < tableToFill.GetLength(0); i++)
            {
                for (int j = 0; j < tableToFill.GetLength(1); j++)
                {
                    tableToFill[i, j] = 0;
                }
            }
        }

        //wyswietlanie tabeli
        public static void ViewTable(int[,] tableToView)
        {
            for (int i = 0; i < tableToView.GetLength(0); i++)
            {
                for (int j = 0; j < tableToView.GetLength(1); j++)
                {
                    Console.Write(" " + tableToView[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Losowe rozmieszczanie bomb + ustawienia odp wartosci na pozostalych polach
        public static void Bombs(int[,] tableToFill)
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
        }

        public void SaperGame()
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
    }
}