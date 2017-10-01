using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public abstract class ChessFigure
    {
        public bool Color;
        
        public abstract bool Move(int strtX, int strtY, int destX, int destY);

        public abstract void AddFigurePictures(Button[,] chessBoard, int i, int j);
    }
}
