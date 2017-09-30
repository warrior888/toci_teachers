using System.Windows.Forms;

namespace sudoku
{
    public interface ILabelX : IBaseThing
    {
        Label MakeLabelX(Form1 form1, int posX, int posY);
    }
}