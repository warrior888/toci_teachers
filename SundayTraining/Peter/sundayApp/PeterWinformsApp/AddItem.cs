using System.Drawing;
using System.Windows.Forms;

namespace PeterWinformsApp
{
    public class AddItem
    {
        public Button CreateButton(int x,int y,string tekst,int sizeX, int sizeY)
        {
            Button button = new Button();
            button.Size = new Size(sizeX,sizeY);
            button.Text = tekst;
            button.Location = new Point(x,y);
            return button;
        }
        public TextBox CreateTextBox(int x, int y, string tekst, int sizeX, int sizeY)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(sizeX, sizeY);
            textBox.Text = tekst;
            textBox.Location = new Point(x, y);
            return textBox;
        }
        public Label CreateLabel(int x, int y, string tekst, int sizeX, int sizeY)
        {
            Label label = new Label();
            label.Text = tekst;
            label.BackColor = Color.AliceBlue;
            label.Size = new Size(sizeX, sizeY);
            label.Location = new Point(x, y);
            return label;
        }
    }
}