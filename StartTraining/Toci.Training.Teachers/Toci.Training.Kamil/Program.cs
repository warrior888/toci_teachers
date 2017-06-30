using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.Kamil
{
    
    class Saper
    {
        Random rand1 = new Random();
       
        public int[,] GenerateTable()
        {
            int[,] table = new int[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i, j] = 1;
                }
                
            }
            return table;
        }

        public int RandomBombX()
        {
            int x = rand1.Next(8);
            return x;
        }

        public int RandomBombY()
        {
            int y = rand1.Next(8);
            return y;
        }
        public int[,] GeneratedBomb(int[,] mapWithBomb)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = RandomBombX();
                int y = RandomBombY();
                mapWithBomb[x, y] = 2;
            }
            return mapWithBomb;
        }
        public void DrawMap(int[,] table)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(table[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        //static int[,] table = new int[8, 8];
        static void Main(string[] args)
        {
            
            int[,] x = new Saper().GenerateTable();
            int [,] y = new Saper().GeneratedBomb(x);
            new Saper().DrawMap(y);

            Console.ReadKey();
        }
    }
}
