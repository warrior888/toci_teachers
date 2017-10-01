using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class FigureKing : FigureQueen
    {
        protected int X;
        protected int Y;

        public override bool Move(int strtX, int strtY, int destX, int destY)
        {
            return base.Move(strtX, strtY, destX, destY) && (destX < strtX + 2 && destY < strtY + 2);
        }

        public override void AddFigurePictures(Button[,] chessBoard, int i, int j)
        {
            if (i == 4 && j == 0) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackKing.png"); X = i; Y = j; }
            if (i == 4 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteKing.png"); }
        }

        public int getX() { return X; }
        public int getY() { return Y; }
    }
}
