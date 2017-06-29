using System;
using System.Collections.Generic;

namespace Toci.Training.Kafar
{
    class Saper
    {
        private static string[,] Area { get; set; }
        private static int Columns { get; set; }
        private static int Rows { get; set; }
        private static int Bombs { get; set; }
        private static readonly Dictionary<int, int[]> LocationOfBombs = new Dictionary<int, int[]>();

        public Saper(int columns, int rows, int bombs)
        {
            Columns = columns;
            Rows = rows;
            Bombs = bombs;
            Area = new string[columns, rows];
            Play();
        }

        private static void Play()
        {
            RandomBombs();
            InsertZero();
            LookingForBombs();
            DrawOnScreen();
        }

        /// <summary>
        /// A method to increments numbers in 8 fields around all bombs.
        /// </summary>

        private static void LookingForBombs()
        {
            foreach (KeyValuePair<int, int[]> location in LocationOfBombs)
            {
                AdjacentFieldsIncrementation(location.Value[0], location.Value[1]);
            }

        }

        /// <summary>
        /// A method to increments numbers in 8 fields around bomb.
        /// </summary>
        /// <param name="columns">A number of columns</param>
        /// <param name="rows">A number of rows</param>

        private static void AdjacentFieldsIncrementation(int columns, int rows)
        {
            for (int c = columns - 1; c <= columns + 1; c++)
            {
                for (int r = rows - 1; r <= rows + 1; r++)
                {
                    try
                    {
                        if (int.TryParse(Area[c, r], out int value))
                        {
                            value++;
                            Area[c, r] = value.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
        }

        // metoda rysująca Sapera w konsoli

        /// <summary>
        /// A method to draw Minesweeper board in console.
        /// </summary>

        private static void DrawOnScreen()
        {
            Console.WriteLine();
            for (int i = 0; i < Columns; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < Rows; j++)
                {
                    if (j == Rows - 1)
                        Console.WriteLine(" " + Area[i, j] + "\n");
                    else
                        Console.Write(" " + Area[i, j] + " ");
                }
            }
        }

        /// <summary>
        /// A method to supplement Minesweeper board with zeeros.
        /// </summary>

        private static void InsertZero()
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (Area[i, j] != "X") // jeśli w danym miejscu nie ma bomby, to wstawiane jest 0
                    {
                        Area[i, j] = "0";
                    }
                }
            }
        }

        /// <summary>
        /// A method to random bombs on Minesweeper board.
        /// </summary>

        private static void RandomBombs()
        {

            for (int i = 0; i < Bombs;)
            {
                int[] location = new int[2];
                Random locOfBomb = new Random();
                location[0] = locOfBomb.Next(Columns - 1);
                location[1] = locOfBomb.Next(Rows - 1);
                if (Area[location[0], location[1]] != "X") // if sprawdza, czy wylosowana lokacja nie jest już miejscem gdzie znajduje się bomba
                {
                    Area[location[0], location[1]] = "X"; // jeśli w wylosowanej lokacji nie ma bomby, to wstawiamy bombę
                    i++;
                    LocationOfBombs.Add(i, location);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int columns, rows, bombs;
            
            Console.WriteLine("Podaj wielkość pola gry.");

            do
            {
                Console.Write("Ilość kolumn: ");
            } while (!int.TryParse(Console.ReadLine(), out columns));

            do
            {
                Console.Write("Ilość rzędów: ");
            } while (!int.TryParse(Console.ReadLine(), out rows));

            do
            {
                Console.Write("Podaj ilość min na polu gry: ");
            } while (!int.TryParse(Console.ReadLine(), out bombs));

            new Saper(columns, rows, bombs);

            Console.ReadKey();
        }
    }
}
