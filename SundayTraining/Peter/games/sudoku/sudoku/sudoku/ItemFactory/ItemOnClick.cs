using System;
using System.Windows.Forms;
using sudoku.check;

namespace sudoku
{
    public class ItemOnClick
    {
        public ItemOnClick()
        {
            
        }

        private Form1 _f1;
        public ItemOnClick(Form1 f1)
        {
            _f1 = f1;
        }
        
        public void ButtonOnClick(object sender, EventArgs e)
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
            Table.ClientTab[button.Location.X / ButtonBase.sizeX, button.Location.Y / ButtonBase.sizeY] = buttonNumber;
            button.Text = buttonNumber.ToString();
        }


        public void CheckButtonOnClick(object sender, EventArgs e)
        {
            chcekX checkMyTableX = new chcekX();
            checkY checkMyTableY = new checkY();
            checkSquare checkMySquare = new checkSquare();
            var scoreX = checkMyTableX.checkTabX();
            var scoreY = checkMyTableY.checkTabY();
            var scoreSquare = checkMySquare.CheckMySquare();
            if (!scoreX || !scoreY || !scoreSquare)
            {
                MessageBox.Show(_f1, "Try one more time");
            }
            else
            {
                MessageBox.Show(_f1, "You win");

            }
        }
    }
}