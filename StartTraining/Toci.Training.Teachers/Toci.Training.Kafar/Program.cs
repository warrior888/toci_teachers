using System;
using System.Collections.Generic;

namespace Toci.Training.Kafar
{
    class Saper
    {
        public static Dictionary<int, int[]> LocationOfBombs = new Dictionary<int, int[]>();

        public void Game(int columns, int rows, int bombs)
        {
            string[,] area = new string[columns, rows];

            RandomBombs(columns, rows, bombs, area);
            InsertZero(columns, rows, area);
            LookingForBombs(area);

            DrawOnScreen(columns, rows, area);

        }

        // metoda iterująca pola sąsiadujące bomb

        private static void LookingForBombs(string[,] area)
        {
            foreach (KeyValuePair<int, int[]> location in LocationOfBombs)
            {
                AdjacentFieldsIncrementation(area, location.Value[0], location.Value[1]);
            }

        }

        // metoda inkrementująca 8 pól przylegających do bomby

        private static void AdjacentFieldsIncrementation(string[,] area, int i, int j)
        {
            for (int c = i - 1; c <= i + 1; c++)
            {
                for (int r = j - 1; r <= j + 1; r++)
                {
                    try
                    {
                        if (int.TryParse(area[c, r], out int value))
                        {
                            value++;
                            area[c, r] = value.ToString();
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

        private static void DrawOnScreen(int columns, int rows, string[,] area)
        {
            Console.WriteLine();
            for (int i = 0; i < columns; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < rows; j++)
                {
                    if (j == rows - 1)
                        Console.WriteLine(" " + area[i, j] + "\n");
                    else
                        Console.Write(" " + area[i, j] + " ");
                }
            }
        }

        // metoda uzupełniająca Sapera zerami

        private static void InsertZero(int columns, int rows, string[,] area)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (area[i, j] != "X") // jeśli w danym miejscu nie ma bomby, to wstawiane jest 0
                    {
                        area[i, j] = "0";
                    }
                }
            }
        }

        // metoda losująca bomby w Saperze

        private static void RandomBombs(int columns, int rows, int bombs, string[,] area)
        {

            for (int i = 0; i < bombs;)
            {
                int[] location = new int[2];
                Random locOfBomb = new Random();
                location[0] = locOfBomb.Next(columns - 1);
                location[1] = locOfBomb.Next(rows - 1);
                if (area[location[0], location[1]] != "X") // if sprawdza, czy wylosowana lokacja nie jest już miejscem gdzie znajduje się bomba
                {
                    area[location[0], location[1]] = "X"; // jeśli w wylosowanej lokacji nie ma bomby, to wstawiamy bombę
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
            Saper a = new Saper();
            Console.Write("Podaj wielkość pola gry.");

            do
            {
                Console.Write("\nIlość kolumn: ");
            } while (!int.TryParse(Console.ReadLine(), out columns));

            do
            {
                Console.Write("\nIlość rzędów: ");
            } while (!int.TryParse(Console.ReadLine(), out rows));

            do
            {
                Console.Write("\nPodaj ilość min na polu gry: ");
            } while (!int.TryParse(Console.ReadLine(), out bombs));

            a.Game(columns, rows, bombs);

            Console.ReadKey();
        }
    }
}
