using System.Drawing;

namespace mySnake.myClasses
{
    public class MyTable
    {
        public static int tableSize = 10;

        public MyTable(Form1 form1)
        {
            makeTable(form1);
        }

        private void makeTable(Form1 form1)
        {
            for (int i = 0; i < tableSize; i++)
            {
                for (int j = 0; j < tableSize; j++)
                {
                    new MyButton(form1, j * MyButton.sizeButton, i * MyButton.sizeButton,Color.Azure);
                }
            }
        }
    }
}