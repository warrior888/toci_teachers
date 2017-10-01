using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class ChessBoard : Form , IColor
    {
        AddFigures af = new AddFigures();
        FigureQueen fq = new FigureQueen();
        Button tentativeButton = new Button();
        Button[,] tentativeButtonTable = new Button[8, 8];
        public Button[,] chessBoard = new Button[8, 8];
        CheckFigureMove cfm = new CheckFigureMove();

        public void CreatAChessBoard(Form form)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j] = new Button();
                    chessBoard[i, j].Location = new System.Drawing.Point((i*61)+61, (j*61)+61);
                    chessBoard[i, j].Size = new System.Drawing.Size(61,61);
                    chessBoard[i, j].BackColor = (GetColor(i,j)) ? System.Drawing.Color.Gray : System.Drawing.Color.WhiteSmoke;
                    form.Controls.Add(chessBoard[i, j]);
                    //chessBoard[i, j].Image = Chess.Properties.Resources.BlackBishop;
                    af.AddFigure(chessBoard, i, j);
                    chessBoard[i, j].MouseEnter += ChessBoard_MouseEnter;
                    chessBoard[i, j].MouseLeave += ChessBoard_MouseLeave;
                    chessBoard[i, j].MouseDown += ChessBoard_MouseDown;
                    chessBoard[i, j].MouseUp += ChessBoard_MouseUp;
                    chessBoard[i, j].AllowDrop = true;
                    chessBoard[i, j].DragEnter += ChessBoard_DragEnter;
                    chessBoard[i, j].DragDrop += ChessBoard_DragDrop;
                }
            }
        }

        private void ChessBoard_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)sender).Image = tentativeButton.Image;
        }

        private void ChessBoard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void ChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tentativeButtonTable[i, j] = new Button();
                    tentativeButtonTable[i, j].BackColor = chessBoard[i, j].BackColor;
                }
            }
            cfm.checkMove(sender, chessBoard);

            if (((Button)sender).Image != null)
            {
                ((Button)sender).DoDragDrop(((Button)sender).Image, DragDropEffects.Move);
            }
        }

        private void ChessBoard_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j].BackColor = tentativeButtonTable[i, j].BackColor;
                }
            }
        }

        private void ChessBoard_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = tentativeButton.BackColor;
        }

        private void ChessBoard_MouseEnter(object sender, EventArgs e)
        {
            tentativeButton.BackColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = System.Drawing.Color.Turquoise;
            tentativeButton.Image = ((Button)sender).Image;
        }

        public bool GetColor(int x, int y)
        {
            return (x + y) % 2 == 1 ? true : false;
        }
    }
}
