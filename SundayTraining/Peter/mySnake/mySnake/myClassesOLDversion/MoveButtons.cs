using System.Drawing;

namespace mySnake.myClasses
{
    public class MoveButtons
    {
        public MoveButtons(Form1 form1)
        {
            addButtons(form1);
        }

        public static int flag = 1;
        private int MoveButtonSize = 50;
        private Color Color = Color.BurlyWood;

        private void addButtons(Form1 form1)
        {
            var buttonUp = MyButton.make(form1, 350, 300, Color);
            buttonUp.Text = "UP";
            buttonUp.Size = new Size(MoveButtonSize, MoveButtonSize);
            buttonUp.Click += (sender, args) => { flag = -1; };

            var buttonDown = MyButton.make(form1, 350, 400, Color);
            buttonDown.Text = "DOWN";
            buttonDown.Size = new Size(MoveButtonSize, MoveButtonSize);
            buttonDown.Click += (sender, args) => { flag = 1; };

            var buttonRight = MyButton.make(form1, 400, 350, Color);
            buttonRight.Text = "RIGHT";
            buttonRight.Size = new Size(MoveButtonSize, MoveButtonSize);
            buttonRight.Click += (sender, args) => { flag = 2; };

            var buttonLeft = MyButton.make(form1, 300, 350, Color);
            buttonLeft.Text = "LEFT";
            buttonLeft.Size = new Size(MoveButtonSize, MoveButtonSize);
            buttonLeft.Click += (sender, args) => { flag = -2; };
        }
    }
}