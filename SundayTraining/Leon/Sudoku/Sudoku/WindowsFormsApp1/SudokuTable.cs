using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SudokuTable
    {
        public int[,] TableOfSudoku = new int[9, 9];
        public void CreatSudokuTable()
        {
            Random IntForTable = new Random();
            int number;
            int ControlNumber = 1;
            number = IntForTable.Next(1, 10);
            for (int z = 0, DemY = 0, DemX = 0; z < 9; z++)
            {
                for (int i = DemX; i < 9; i += 3)
                {
                    for (int j = DemY; j < 9; j += 3)
                    {
                        number = CheckNumber(number);
                        TableOfSudoku[j, i] = number;
                        number++;
                    }
                }
                number = CheckNumber(number);
                number++;
                if (ControlNumber == 1) { DemX += 2; DemY += 2; }
                if (ControlNumber == 2) { DemX--; DemY -= 2; }
                if (ControlNumber == 3) { DemX--; DemY++; }
                if (ControlNumber == 4) { DemX += 2; DemY--; }
                if (ControlNumber == 5) { DemX--; DemY++; }
                if (ControlNumber == 6) { DemX--; DemY++; }
                if (ControlNumber == 7) { DemX += 2; DemY--; }
                if (ControlNumber == 8) { DemX--; DemY++; }
                /*if(ControlNumber == 1) { DemX+=2; DemY+=2; }
                if(ControlNumber == 2) { DemX--; DemY-=2; }
                if(ControlNumber == 3) { DemX--; DemY+=2; }
                if(ControlNumber == 4) { DemX-=2; DemY+=2; }
                if(ControlNumber == 5) { DemX++; DemY--; }
                if(ControlNumber == 6) { DemY--; }
                if(ControlNumber == 7) { DemY+=2; }
                if(ControlNumber == 8) { DemX++; DemY--; }*/
                ControlNumber++;
            }
        }

        public int CheckNumber(int candidate)
        {
            if (candidate > 9)
            {
                candidate = 1;
            }
            return candidate;
        }
    }
}
