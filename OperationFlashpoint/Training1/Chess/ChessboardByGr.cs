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
    public partial class ChessboardByGr : GhostRiderForm
    {
        public ChessboardByGr()
        {
            InitializeComponent();
        }

        public override void AddControl(ChessBoard cb, int i, int j)
        {
            base.AddControl(cb, i, j);
        }
    }
}
