using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int up { get; set; }
        public int left { get; set; }

        

        public Form1()
        {
            InitializeComponent();

            up = 5;
            left = 5;

            for (int i = 0; i < up; i++)
            {
                for (int j = 0; j < left; j++)
                {
                   board(i*20,j*20);
                    
                }
            }
            

           
            
             


        }

        public void board(int x, int y)
        {
            x = up;
            y = left;
            Button button = new Button();
            button.BackColor = Color.AntiqueWhite;
            button.Click += Button_Click;
            button.Location= new Point(x,y);

            

            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
