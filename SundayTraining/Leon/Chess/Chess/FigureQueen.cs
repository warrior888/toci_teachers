using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class FigureQueen : ChessFigure
    {
        protected int X;
        protected int Y;

        public override void AddFigurePictures(Button[,] chessBoard, int i, int j)
        {
            if(i == 3 && j == 0)
            { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackQueen.png"); X = i; Y = j;
            }
            if(i == 3 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteQueen.png"); }
        }

        public override bool Move(int strtX, int strtY, int destX, int destY)
        {
            return (strtX + strtY == destX + destY || strtX - strtY == destX - destY) || (strtX == destX || strtY == destY);
        }

        public int getX() { return X; }
        public int getY() { return Y; }
    }
}
