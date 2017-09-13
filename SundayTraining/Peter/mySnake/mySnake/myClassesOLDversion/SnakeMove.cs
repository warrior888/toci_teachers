using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace mySnake.myClasses
{
    public static class SnakeMove
    {
        private static Timer timer = new Timer();
        private static Form1 _form1;

        public static void MoveSn(this Button button, Form1 form1)
        {
            _form1 = form1;
            timer.Start();
            timer.Interval = 500;
            timer.Tick += TimeMethodOnTick;
        }

        private static void TimeMethodOnTick(object sender, EventArgs eventArgs)
        {
            if (posValid(0, 0, MyButton.sizeButton * MyTable.tableSize, MyButton.sizeButton * MyTable.tableSize))                   // <-popraw
            {
                directionValid();
            }

            for (int i = Snake.SnakeList.Count-1; i > 0 ; i--)
            {
                Snake.SnakeList[i].Location = Snake.SnakeList[i - 1].Location;
            }

            Snake.SnakeList[0].Location = new Point(SnakeHead.headPosX , SnakeHead.headPosY);

            EatApple(_form1);

            collision();
        }


        private static bool posValid(int x0, int y0, int xMax, int yMax)
        {
            if (SnakeHead.headPosY >= x0 &&
                SnakeHead.headPosX >= y0 &&
                SnakeHead.headPosX < xMax &&
                SnakeHead.headPosY < yMax)
            {
                return true;
            }
            throw new Exception();
            return false;
        }

        private static void directionValid()
        {
            switch (MoveButtons.flag)
            {
                case 1:
                    SnakeHead.headPosY += MyButton.sizeButton;
                    break;
                case -1:
                    SnakeHead.headPosY -= MyButton.sizeButton;
                    break;
                case 2:
                    SnakeHead.headPosX += MyButton.sizeButton;
                    break;
                case -2:
                    SnakeHead.headPosX -= MyButton.sizeButton;
                    break;

            }
        }

        private static void EatApple(Form1 form1)
        {
            if (SnakeHead.headPosX == RandomApple.apple.Location.X && SnakeHead.headPosY == RandomApple.apple.Location.Y)
            {
                RandomApple.randX = new Random(DateTime.Now.Millisecond).Next(0, MyTable.tableSize) * MyButton.sizeButton;
                RandomApple.randY = new Random().Next(0, MyTable.tableSize) * MyButton.sizeButton;

                RandomApple.apple.Location = new Point(RandomApple.randX, RandomApple.randY);

                Snake.SnakeList.Add(MyButton.make(form1,SnakeHead.headPosX,SnakeHead.headPosY,Color.Aqua));
            }
        }

        private static void collision()
        {
            for (int i = 2; i < Snake.SnakeList.Count; i++)
            {
                if (Snake.SnakeList[i-1].Location == Snake.SnakeList[0].Location)
                {
                    throw new Exception();
                }
            }
        }
    }
}