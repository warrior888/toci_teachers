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
            int ControlNumber = 1;
            number = IntForTable.Next(1, 10);
            for (int z = 0, DemY = 0, DemX = 0; z <9; z++)
            {
                for (int i = DemX; i < 9; i += 3)
                {
                    for (int j = DemY; j < 9; j += 3)
                    {
                        number = CheckNumber(number);
                        candidate[j, i] = number;
                        number++;
                    }
                }
                number = CheckNumber(number);
                number++;
                //if(ControlNumber == 1) { DemX+=2; DemY+=2; }
                /*if(ControlNumber == 2) { DemX--; DemY-=2; }
                if(ControlNumber == 3) { DemX--; DemY++; }
                if(ControlNumber == 4) { DemX+=2; DemY--; }
                if(ControlNumber == 5) { DemX--; DemY++; }
                if(ControlNumber == 6) { DemX--; DemY++; }
                if(ControlNumber == 7) { DemX+=2; DemY--; }
                if(ControlNumber == 8) { DemX--; DemY++; }*/
                if(ControlNumber == 1) { DemX+=2; DemY+=2; }
                if(ControlNumber == 2) { DemX--; DemY-=2; }
                if(ControlNumber == 3) { DemX--; DemY+=2; }
                if(ControlNumber == 4) { DemX+=2; DemY--; }
                if(ControlNumber == 5) { DemX--; DemY++; }
                if(ControlNumber == 6) { DemX--; DemY--; }
                if(ControlNumber == 7) { DemX+=2; DemY--; }
                if(ControlNumber == 8) { DemX--; DemY++; }
                ControlNumber++;
            }
            return candidate;
        }

        public override int CheckNumber(int candidate)
        {
            if(candidate > 9)
            {
                candidate = 1;
            }
            return candidate;
        }
    }
}
