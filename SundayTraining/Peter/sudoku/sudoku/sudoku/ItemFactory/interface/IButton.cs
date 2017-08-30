using System.Windows.Forms;

namespace sudoku
{
    public interface IButton : IBaseThing
    {
        Button MakeButton(Form1 form1, int posX, int posY);
    }
}