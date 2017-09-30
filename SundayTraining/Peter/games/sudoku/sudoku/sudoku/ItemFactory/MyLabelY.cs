using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    public class MyLabelY : ILabelY
    {
        public int sizeXLabelY = 280;
        public int sizeYLabelY = 3;

        private Color color = Color.Black;

        public MyLabelY(Form1 f1, int posX, int posY)
        {
            MakeLabelY(f1, posX, posY);
        }

        public Label MakeLabelY(Form1 handle, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Size = new Size(sizeXLabelY, sizeYLabelY);
            label.BackColor = color;
            handle.Controls.Add(label);
            return label;
        }

    }
}
