using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public class CheckButton : ButtonBase
    {
        public CheckButton()
        {

        }

        public CheckButton(Form1 form1, int posX, int posY)
        {
            MakeButton(form1, posX, posY);
        }

        

        public override Button MakeButton(Form1 form1, int posX, int posY)
        {
            ItemOnClick ItemOnClick = new ItemOnClick(form1);

            Button button = new Button();
            button.Location = new Point(posX, posY);
            button.Size = new Size(sizeX*2, sizeY*2);
            button.BackColor = Color.Gold;
            button.Text = "Check";
            button.Click += ItemOnClick.CheckButtonOnClick;
            form1.Controls.Add(button);
            return button;
        }
    }
}