using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public class NormalButton : ButtonBase
    {
        public NormalButton()
        {
            
        }

        public NormalButton(Form1 form1,int posX, int posY)
        {
           MakeButton(form1,posX, posY);
        }

        ItemOnClick ItemOnClick = new ItemOnClick();
        public override Button MakeButton(Form1 form1,int posX, int posY)
        {
            ReadyTab.readTab();
            Button button = new Button();
            button.Location = new Point(posX, posY);
            button.Size = new Size(sizeX, sizeY);
            button.BackColor = Color.Beige;
            button.Text = ReadyTab.getNumber();
            button.Click += ItemOnClick.ButtonOnClick;
            form1.Controls.Add(button);
            return button;
        }
    }
}