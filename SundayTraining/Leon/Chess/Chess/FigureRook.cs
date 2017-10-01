using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class FigureRook : ChessFigure
    {
        protected int X;
        protected int Y;

        public override void AddFigurePictures(Button[,] chessBoard, int i, int j)
        {
            if (i == 0 && j == 0) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackRook.png"); }
            if (i == 7 && j == 0) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackRook.png"); X = i; Y = j; }
            if (i == 0 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteRook.png"); }
            if (i == 7 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteRook.png"); }
        }

        public override bool Move(int strtX, int strtY, int destX, int destY)
        {
            return strtX == destX || strtY == destY;
        }

        public int getX() { return X; }
        public int getY() { return Y; }
    }
}
