using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class FigurePawn : ChessFigure
    {
        protected int X;
        protected int Y;

        public override void AddFigurePictures(Button[,] chessBoard, int i, int j)
        {
            if (j == 1) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackPawn.png"); }
            if (j == 6) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhitePawn.png"); }
        }

        public override bool Move(int strtX, int strtY, int destX, int destY)
        {
            if (destY <= 3) { return strtX == destX && (strtY + 2 == destY || strtY + 1 == destY); }
            else { return strtX == destX && strtY + 1 == destY; }
        }

        public int getX() { return X; }
        public int getY() { return Y; }
    }
}
