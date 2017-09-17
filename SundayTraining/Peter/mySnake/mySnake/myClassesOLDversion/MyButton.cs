using System.Drawing;
using System.Windows.Forms;

namespace mySnake.myClasses
{
    public class MyButton
    {
        public static int sizeButton = 30;

        public MyButton(Form1 form1, int posX, int posY, Color color)
        {
            make(form1, posX, posY, color);
        }

        public static Button make(Form1 form1, int posX, int posY, Color color)
        {
            Button button = new Button
            {
                Size = new Size(sizeButton, sizeButton),
                Location = new Point(posX, posY),
                BackColor = color
            };
            form1.Controls.Add(button);
            return button;
        }

    }
}