using System.Drawing;
using System.Windows.Forms;

namespace sudoku.items
{
    public class MyLabel 
    {
        public int sizeXLabelX = 3;
        public int sizeYLabelX = 280;

        public int sizeXLabelY = 280;
        public int sizeYLabelY = 3;

        private Color color = Color.Black;

        public  Label MakeLabelX( Form1 handle, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Size = new Size(sizeXLabelX, sizeYLabelX);
            label.BackColor = color;
            handle.Controls.Add(label);
            return label;
        }

        public Label MakeLabelY(Form1 handle,int x, int y)
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