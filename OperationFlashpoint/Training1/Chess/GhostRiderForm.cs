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
    public partial class GhostRiderForm : Form
    {
        public GhostRiderForm()
        {
            InitializeComponent();

	        this.MinimumSize = new  Size(620, 640);

            ChessBoard cb = new ChessBoard();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    AddControl(cb, i, j);
                }
            }
            
        }

        public virtual void AddControl(ChessBoard cb, int i, int j)
        {
            Button b = new Button();

            b.Location = new Point(cb.Board[i, j].XCoordinate, cb.Board[i, j].YCoordinate);
            b.Size = new Size(60, 60);
	        b.BackColor = cb.Board[i, j].color;

            Controls.Add(b);
        }
    }
}
