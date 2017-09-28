using System;
using System.Collections.Generic;

using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;

using System.Linq;

using System.Text;
using System.Threading.Tasks;
/*
namespace ConsoleApp2
{
    /*
    class Program
    {
        static void Main(string[] args)
        {


            public static string[,] board { get; set; }
            public static int columns     { get; set; }
            public static int rows        { get; set; }
            public static int mine        { get; set; }
            public static int mark        { get; set; }
            public static int[] randomValueColumns { get; set; }
            public static int[] randomValueRows { get; set; }

            

        public static void area()
            {
                
                for (int i = 0; i < columns; i++)
                {
                    
                    
                    for (int j = 0; j < rows; j++)
                    {

                        board[i, j] = "1";

                    }
                }
            }

                     public  static void randomBombs()
                        {
                           Random rds= new Random();
                            randomValueColumns = new int[(mine-1)/2];
                            randomValueRows =    new int[(mine - 1) / 2];
                            int k = 0;
                            while(k < mine-1)
                            {
                                if (randomValueColumns[k] != randomValueColumns[k-1] || randomValueRows[k]!= randomValueRows[k-1])
                                {
                                    randomValueColumns[k] = rds.Next(columns - 1);
                                    k++;
                                    randomValueRows[k] = rds.Next(rows - 1);
                                }



                            }

                        }

                            public static void bombFiling()
                            {

                                for (int c = 0; c < columns; c++)
                                {
                                    if (board[c, 0] == Convert.ToString(randomValueColumns[c]))
                                    {
                                        board[c, 0] = "X";

                                    }
                                }
                                for(int d=0; d<rows; d++)
                                        {
                                            if (board[0, d] == Convert.ToString(randomValueRows[d]))
                                            {
                                                board[0, d] = "X";
                                            }
                                        }
                                
                            }

                                        public static void checkBombandAndIncrementation()
                                        {
                                            

                                            
                                                    for (int e = 0; e < columns; e++)
                                                    {
                                                        for (int f = 0; f < rows; f++)
                                                        {
                                                           
                                                        }
                                                    }
                                        }

            Console.WriteLine("Ile chcesz wpisać liczb");
            string userInput = Console.ReadLine();
            int userInputNumber = 0;
             int.TryParse(userInput, out userInputNumber);

            int[] tablica = new int[userInputNumber];

            for (int i = 0; i < userInputNumber ; i++)
            {
                Console.WriteLine("Wpisz jakas liczbe");
                string secondInput = Console.ReadLine();
                int secondInputNumber = 0;
                int.TryParse(secondInput, out secondInputNumber);
                tablica[i] = secondInputNumber;
            }

            Console.WriteLine("Okej tyle wystarczy");

            int bigger = tablica[1];

            for ( int i = 0; i < userInputNumber; i++)
            {
                if ( bigger < tablica[i])
                {
                    bigger = tablica[i];
                
                }
              
                
            }

            Console.WriteLine(" Maksymalna wartość to: " + bigger);

            Console.ReadKey();


        }
    }
}


}

