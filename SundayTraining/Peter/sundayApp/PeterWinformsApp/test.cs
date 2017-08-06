using System.Drawing;
using System.Windows.Forms;

namespace PeterWinformsApp
{
    public class test:Form
    {
        public Button make()
        {
            Button button = new Button();
            button.Location = new Point(20,20);
            button.Size = new Size(120,120);
            Controls.Add(button);
            return button;
        }
    }
}