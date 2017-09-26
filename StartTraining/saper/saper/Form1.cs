using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatePlain();
        }

        public void CreatePlain()

        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button b = new Button();

                    b.Size = new Size(20, 20);
                    b.Location = new Point(i*20, j*20);

                    Controls.Add(b);
                }
            }
        }
    }
}
