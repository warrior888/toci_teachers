using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace sudoku.items
{
    public class MyButton 
    {
        public MyButton(Form1 form1 , int posX, int posY)
        {
            handle = form1;
            MakeButton(posX, posY);
        }

        public MyButton()
        {
            
        }

        private static Form1 handle;
        ButtonWhenClick WhenClick = new ButtonWhenClick(handle);
        

        public  Button MakeButton(int x, int y)
        {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Size = new Size(MyItems.sizeX, MyItems.sizeY);
            button.BackColor = Color.Beige;
            button.Click += WhenClick.ButtonOnClick;
            button.BringToFront();
            handle.Controls.Add(button);
            return button;
        }

        public Button MakeSpecialButton(Form1 handle,int SpecialPosX, int SpecialPosY)
        {
            Button button = new Button();
            button.Location = new Point(SpecialPosX, SpecialPosY);
            button.Size = new Size(MyItems.SpecialSizeX, MyItems.SpecialSizeY);
            button.BackColor = Color.Beige;
            button.Text = "CHECK";
            button.Click += WhenClick.MakeSpecialButtonOnClick;
            handle.Controls.Add(button);
            return button;
        }

        
    }
}