using System;
using System.Windows.Forms;

namespace sudoku.items
{
    public class ButtonWhenClick
    {
        private Form1 handle;

        public ButtonWhenClick(Form1 handle)
        {
            this.handle = handle;
        }

        public void MakeSpecialButtonOnClick(object sender, EventArgs e)
        {
            CheckMyTableX checkMyTableX = new CheckMyTableX();
            CheckMyTableY checkMyTableY = new CheckMyTableY();
            CheckMySquare checkMySquare = new CheckMySquare();
            var scoreX = checkMyTableX.checkTabX();
            var scoreY = checkMyTableY.checkTabY();
            var scoreSquare = checkMySquare.checkSquare();
            if (!scoreX || !scoreY || !scoreSquare)
            {
                MessageBox.Show(handle, "Try one more time");
            }
            else
            {
                MessageBox.Show(handle, "You win");

            }
        }

        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            int buttonNumber = 0;
            if (Int32.TryParse(button.Text, out buttonNumber))
            {
                buttonNumber = Int32.Parse(button.Text);
            }
            buttonNumber++;
            if (buttonNumber >= 10)
            {
                buttonNumber = 1;
            }
            MyItems.tab[button.Location.X / MyItems.sizeX, button.Location.Y / MyItems.sizeY] = buttonNumber;
            button.Text = buttonNumber.ToString();
        }
    }
}