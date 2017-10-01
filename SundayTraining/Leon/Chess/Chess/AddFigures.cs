using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class AddFigures
    {
        FigurePawn fp = new FigurePawn();
        FigureBishop fb = new FigureBishop();
        FigureKnight fkn = new FigureKnight();
        FigureKing fk = new FigureKing();
        FigureQueen fq = new FigureQueen();
        FigureRook fr = new FigureRook();

        public void AddFigure(Button[,] chessBoard, int i, int j)
        {
            fq.AddFigurePictures(chessBoard, i, j);
            fr.AddFigurePictures(chessBoard, i, j);
            fb.AddFigurePictures(chessBoard, i, j);
            fkn.AddFigurePictures(chessBoard, i, j);
            fk.AddFigurePictures(chessBoard, i, j);
            fp.AddFigurePictures(chessBoard, i, j);
        }
    }
}
