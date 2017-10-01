using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        ChessBoard cb = new ChessBoard();
        public Form1()
        {
            InitializeComponent();
            cb.CreatAChessBoard(this);
        }
    }
}
