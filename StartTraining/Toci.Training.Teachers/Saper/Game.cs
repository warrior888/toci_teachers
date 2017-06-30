using System.Windows.Forms;

namespace Saper
{
    public class Game       // TODO: Ograniczyć tylko do jednej instancji
    {
        public Game(Panel panel, ComboBox difficulty)
        {
            var createBoard = new GameBoard();
            createBoard.ClearBoard(panel);
            createBoard = new GameBoard((GameDifficultyLevel)difficulty.SelectedIndex, panel);
        }
    }
}