using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class FigureKnight : ChessFigure
    {
        protected int X;
        protected int Y;

        public override void AddFigurePictures(Button[,] chessBoard, int i, int j)
        {
            if (i == 2 && j == 0) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackKnight.png"); X = i; Y = j; }
            if (i == 5 && j == 0) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\BlackKnight.png"); }
            if (i == 5 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteKnight.png"); }
            if (i == 2 && j == 7) { chessBoard[i, j].Image = Image.FromFile(@"E:\Szkolenie\C#\Projekty\Chess\Chess\ChessPictures\WhiteKnight.png"); }
        }

        public override bool Move(int strtX, int strtY, int destX, int destY)
        {
            bool result = false;
            if      (strtX + 2 == destX && (strtY - 1 == destY || strtY + 1 == destY)) { result = true; }
            else if (strtX + 1 == destX && (strtY - 2 == destY || strtY + 2 == destY)) { result = true; }
            else if (strtX - 1 == destX && (strtY - 2 == destY || strtY + 2 == destY)) { result = true; }
            else if (strtX - 2 == destX && (strtY - 1 == destY || strtY + 1 == destY)) { result = true; }
            return result;
        }

        public int getX() { return X; }
        public int getY() { return Y; }
    }
}
