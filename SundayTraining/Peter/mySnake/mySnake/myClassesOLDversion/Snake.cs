using System.Collections.Generic;
using System.Windows.Forms;

namespace mySnake.myClasses
{
    public class Snake
    {
        //public static Button[,] SnakeArray = new Button[MyTable.tableSize+1, MyTable.tableSize + 1];

        //public static int SnakePosX = 0;
        //public static int SnakePosY = 0;

        public static List<Button> SnakeList = new List<Button>();

        public static int howManyAppleAreEaten;
    }
}