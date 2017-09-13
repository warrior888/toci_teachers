using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SudokuFillingOptions
    {
        public int  FillTheXTable_Option1(int ControlNumber, int DemX)
        {
            if (ControlNumber == 1) { DemX += 2; }
            if (ControlNumber == 2) { DemX--; }
            if (ControlNumber == 3) { DemX--; }
            if (ControlNumber == 4) { DemX += 2; }
            if (ControlNumber == 5) { DemX--; }
            if (ControlNumber == 6) { DemX--; }
            if (ControlNumber == 7) { DemX += 2; }
            if (ControlNumber == 8) { DemX--; }
            return DemX;
        }
        public int FillTheYTable_Option1(int ControlNumber, int DemY)
        {
            if (ControlNumber == 1) { DemY += 2; }
            if (ControlNumber == 2) { DemY -= 2; }
            if (ControlNumber == 3) { DemY += 2; }
            if (ControlNumber == 4) { DemY--; }
            if (ControlNumber == 5) { DemY++; }
            if (ControlNumber == 6) { DemY--; }
            if (ControlNumber == 7) { DemY--; }
            if (ControlNumber == 8) { DemY++; }
            return DemY;
        }

        public int FillTheXTable_Option2(int ControlNumber, int DemX)
        {
            if (ControlNumber == 1) { DemX += 2; }
            if (ControlNumber == 2) { DemX--; }
            if (ControlNumber == 3) { DemX--; }
            if (ControlNumber == 4) { DemX += 2; }
            if (ControlNumber == 5) { DemX--; }
            if (ControlNumber == 6) { DemX--; }
            if (ControlNumber == 7) { DemX += 2; }
            if (ControlNumber == 8) { DemX--; }
            return DemX;
        }
        public int FillTheYTable_Option2(int ControlNumber, int DemY)
        {
            if (ControlNumber == 1) { DemY += 2; }
            if (ControlNumber == 2) { DemY -= 2; }
            if (ControlNumber == 3) { DemY++; }
            if (ControlNumber == 4) { DemY--; }
            if (ControlNumber == 5) { DemY++; }
            if (ControlNumber == 6) { DemY++; }
            if (ControlNumber == 7) { DemY--; }
            if (ControlNumber == 8) { DemY++; }
            return DemY;
        }
    }
}
