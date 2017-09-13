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
using mySnake.myClasses;

namespace mySnake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new SnakeHead(this);

            new RandomApple(this);

            //new MyTable(this);

            new MoveButtons(this);
        }
    }
}
