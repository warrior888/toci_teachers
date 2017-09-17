using System.Windows.Forms;

namespace sudoku
{
    public interface ILabelY : IBaseThing
    {
        Label MakeLabelY(Form1 form1, int posX, int posY);
    }
}