using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public class MyLableX : ILabelX
    {
        public int sizeXLabelX = 3;
        public int sizeYLabelX = 280;

        private Color color = Color.Black;

        public MyLableX(Form1 f1, int posX, int posY)
        {
            MakeLabelX(f1, posX, posY);
        }

        public Label MakeLabelX(Form1 handle, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Size = new Size(sizeXLabelX, sizeYLabelX);
            label.BackColor = color;
            handle.Controls.Add(label);
            return label;
        }
    }
}