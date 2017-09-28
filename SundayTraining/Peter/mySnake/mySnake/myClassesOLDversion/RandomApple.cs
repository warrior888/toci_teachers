using System;
using System.Drawing;
using System.Windows.Forms;

namespace mySnake.myClasses
{
    public class RandomApple
    {
        public RandomApple(Form1 form1)
        {
            makeApple(form1 , apple);
        }

        public static int randX = new Random(DateTime.Now.Millisecond).Next(0, MyTable.tableSize);
        public static int randY = new Random().Next(0, MyTable.tableSize);

        public static Button apple = new Button();

        private void makeApple(Form1 form1, Button a)
        {
            a.Location = new Point(randX* MyButton.sizeButton, randY* MyButton.sizeButton);
            a.Size = new Size(MyButton.sizeButton, MyButton.sizeButton);
            a.BackColor = Color.Gold;
            form1.Controls.Add(a);
        }
    }
}