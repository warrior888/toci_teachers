using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training1;

namespace Chess
{
    public partial class CheesboardByLukaszLu : GhostRiderForm
    {
        ChessBoard chessboard = new ChessBoard();
        public CheesboardByLukaszLu()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    AddControl(chessboard, i, j);
                }
            }
        }
    }
}
