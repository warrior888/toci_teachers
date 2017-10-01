using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class CheckFigureMove
    {
        FigurePawn fp = new FigurePawn();
        FigureBishop fb = new FigureBishop();
        FigureKnight fkn = new FigureKnight();
        FigureKing fk = new FigureKing();
        FigureQueen fq = new FigureQueen();
        FigureRook fr = new FigureRook();

        public void checkMove(object sender, Button[,] chessBoard)
        {
            bool q = false;
            bool w = false;
            if (((Button)sender).Image != null)
            {
                int startX = fq.getX();
                int startY = fq.getY();
                q = true;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (fq.Move(startX, startY, i, j) == true) { chessBoard[i, j].BackColor = Color.PaleTurquoise; w = true;
                        }
                    }
                }
            }
        }
    }
}
