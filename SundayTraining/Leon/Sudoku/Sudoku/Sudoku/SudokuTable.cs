using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public abstract class SudokuTable
    {
        public abstract int[,] FillingTableWithNumbers(int[,] candidate);

        public abstract int CheckNumber(int candidate);
    }
}
