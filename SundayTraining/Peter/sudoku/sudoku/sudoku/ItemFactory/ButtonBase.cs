using System.Windows.Forms;

namespace sudoku
{
    public abstract class ButtonBase : IButton
    {
        public static int sizeX = 30;
        public static int sizeY = 30;

        public abstract Button MakeButton(Form1 form1, int posX, int posY);
    }
}