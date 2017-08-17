using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuTableInherit : SudokuTable
    {
        public override int[,] FillingTableWithNumbers(int[,] candidate)
        {
            Random IntForTable = new Random();
            int number;

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    do
                    {
                        number = IntForTable.Next(1, 10);
                    }
                    while (HorizontalChecking(candidate, number, j) == false || VerticalChecking(candidate, number, i) == false);
                    candidate[i, j] = number;
                }
            }
            return candidate;
        }

        public override bool VerticalChecking(int[,] table, int candidate, int AreaX)
        {
            bool result = true;
            for(int i = 0; i < 9; i++)
            {
                if(table[AreaX,i] == candidate)
                {
                    result = false;
                }
            }
            return result;
        }

        public override bool HorizontalChecking(int[,] table, int candidate, int AreaY)
        {
            bool result = true;
            for (int i = 0; i < 9; i++)
            {
                if (table[i,AreaY] == candidate)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
