using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public class ReadOnlyButton : ButtonBase
    {
        public ReadOnlyButton()
        {

        }

        public ReadOnlyButton(Form1 form1, int posX, int posY)
        {
            MakeButton(form1, posX, posY);
        }

        ReadyTab ReadyTab = new ReadyTab();

        public override Button MakeButton(Form1 form1, int posX, int posY)
        {
            ReadyTab.readTab();
            Button button = new Button();
            button.Location = new Point(posX, posY);
            button.Size = new Size(sizeX, sizeY);
            button.BackColor = Color.DarkGoldenrod;
            Table.ClientTab[posX/ButtonBase.sizeX,posY/ButtonBase.sizeX] = int.Parse(ReadyTab.getNumber());
            button.Text = ReadyTab.getNumber();
            form1.Controls.Add(button);
            return button;
        }
    }
}