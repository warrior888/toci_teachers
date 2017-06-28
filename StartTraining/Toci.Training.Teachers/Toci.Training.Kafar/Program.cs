using System;

namespace Toci.Training.Kafar
{
    class Saper
    {
        public void Game(int columns, int rows, int bombs)
        {
            string[,] area = new string[columns, rows];

            RandomBombs(columns, rows, bombs, area);
            InsertZero(columns, rows, area);
            IteratingBombNumbers(columns, rows, area);

            DrawOnScreen(columns, rows, area);

        }

        // metoda iterująca pola sąsiadujące bomb

        private static void IteratingBombNumbers(int columns, int rows, string[,] area)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    if (area[i, j] == "X") // uzupełniamy liczby bomb
                    {
                        UpperLeftField(area, i, j);
                        LeftField(area, i, j);
                        LowerLeftField(area, i, j);
                        UpperField(area, i, j);
                        LowerField(area, i, j);
                        UpperRightField(area, i, j);
                        RightField(area, i, j);
                        LowerRightField(area, i, j);
                    }

                }
            }
        }

        // osiem metod obsługujących inkrementacje liczby bomb w sąsiednich polach, w każdym polu z osobna

        private static void LowerRightField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i + 1, j + 1], out int value))
                {
                    value++;
                    area[i + 1, j + 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void RightField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i + 1, j], out int value))
                {
                    value++;
                    area[i + 1, j] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void UpperRightField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i + 1, j - 1], out int value))
                {
                    value++;
                    area[i + 1, j - 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void LowerField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i, j + 1], out int value))
                {
                    value++;
                    area[i, j + 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void UpperField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i, j - 1], out int value))
                {
                    value++;
                    area[i, j - 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void LowerLeftField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i - 1, j + 1], out int value))
                {
                    value++;
                    area[i - 1, j + 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void LeftField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i - 1, j], out int value))
                {
                    value++;
                    area[i - 1, j] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private static void UpperLeftField(string[,] area, int i, int j)
        {
            try
            {
                if (int.TryParse(area[i - 1, j - 1], out int value))
                {
                    value++;
                    area[i - 1, j - 1] = value.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
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
                Random locOfBomb = new Random();
                int columnsLoc = locOfBomb.Next(columns - 1);
                int rowsLoc = locOfBomb.Next(rows - 1);
                if (area[columnsLoc, rowsLoc] != "X") // if sprawdza, czy wylosowana lokacja nie jest już miejscem gdzie znajduje się bomba
                {
                    area[columnsLoc, rowsLoc] = "X"; // jeśli w wylosowanej lokacji nie ma bomby, to wstawiamy bombę
                    i++;
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
