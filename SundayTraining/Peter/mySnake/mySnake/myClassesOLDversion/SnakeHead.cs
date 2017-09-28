using System;
using System.Drawing;
using System.Windows.Forms;

namespace mySnake.myClasses
{
    public class SnakeHead
    {
        public SnakeHead(Form1 form1)
        {
            makeHead(form1);
        }

        public static int headPosX = 0;
        public static int headPosY = 0;


        private void makeHead(Form1 form1)
        {
            Button head = MyButton.make(form1, headPosX, headPosY, Color.BlueViolet);
            head.MoveSn(form1);
            Snake.SnakeList.Add(head);
        }
    }
}