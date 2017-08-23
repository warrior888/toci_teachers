using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sudoku.items;

namespace sudoku
{
    public partial class Form1 : Form
    {
        MyTable table = new MyTable();

        public Form1()
        {
            InitializeComponent();
            table.makePlayground(this);
        }
        
    }
}
