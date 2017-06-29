using System;
using System.Drawing;
using System.Windows.Forms;

namespace Saper
{
    public class GameBoard
    {
        public byte NumberOfBomb { get; }

        private readonly SingleField[,] _board;
        private readonly int[] _boardSize;        // _boardSize[0] - lenght, _boradSize[1] - width
        private readonly Random _random;
        private readonly Panel _panel;

        public GameBoard()
        {
            // empty
        }

        public GameBoard(GameDifficultyLevel difficultyLevel, Panel panel)
        {
            //TODO: Dodać ustawienia wymiarów dla panela i okna zależnie od planszy
            _random = new Random();
            _panel = panel;
            switch (difficultyLevel)
            {
                case GameDifficultyLevel.Easy:
                    _boardSize = new [] { 8, 8};
                    _board = new SingleField[_boardSize[0], _boardSize[1]];     //8x8 field
                    NumberOfBomb = 10;
                    ArrangeTheBombs();
                    BombsInTheNeighborhood(_board);
                    break;
                case GameDifficultyLevel.Normal:
                    _boardSize = new[] { 16, 16 };
                    _board = new SingleField[_boardSize[0], _boardSize[1]];    // 16x16 field
                    NumberOfBomb = 40;
                    ArrangeTheBombs();
                    BombsInTheNeighborhood(_board);
                    break;
                case GameDifficultyLevel.Hard:
                    _boardSize = new[] { 16, 30 };
                    _board = new SingleField[_boardSize[0], _boardSize[1]];    // 30x16 field
                    NumberOfBomb = 99;
                    ArrangeTheBombs();
                    BombsInTheNeighborhood(_board);
                    break;
            }
        }

        public void ClearBoard(Panel panel)
        {
            panel.Controls.Clear();
        }

        private void ArrangeTheBombs()   // Places bombs
        {
            int positionX = 0;
            int positionY = 0;
            int i;
            for (i = 0; i < _boardSize[0]; i++ )
            {
                
                for (int j = 0; j < _boardSize[1]; j++)
                {
                    _board[i, j] = new SingleField(i, j/*, _panel*/);
                    _board[i, j].FieldButton.Location = new Point(positionX, positionY);
                    _panel.Controls.Add(_board[i, j].FieldButton);
                    positionX += 30;
                }
                positionX = 0;
                positionY += 30;
            }

            i = 0;
            while (i < NumberOfBomb)
            {
                var field = _board[_random.Next(_boardSize[0]), _random.Next(_boardSize[1])];

                if (field.HasABomb) continue;
                field.HasABomb = true;
                field.FieldValue = 9;
                i++;
            }
        }

        private bool CheckField(int x, int y)
        {
            if (x >= 0 && x < _boardSize[0])
                if (y >= 0 && y < _boardSize[1])
                    return _board[x, y].HasABomb;
            return false;
        }

        //private void BombsInTheNeighborhood(SingleField field)
        private void BombsInTheNeighborhood(SingleField[,] board)
        {
            foreach (var field in board)
            if (field.IsHide && !field.HasABomb)
            {
                int x = field.X,
                    y = field.Y;

                if (CheckField(x - 1, y + 1))
                    field.FieldValue++;
                if (CheckField(x - 1, y))
                    field.FieldValue++;
                if (CheckField(x - 1, y -1))
                    field.FieldValue++;
                if (CheckField(x, y + 1))
                    field.FieldValue++;
                if (CheckField(x, y))
                    field.FieldValue++;
                if (CheckField(x, y - 1))
                    field.FieldValue++;
                if (CheckField(x + 1, y + 1))
                    field.FieldValue++;
                if (CheckField(x + 1, y))
                    field.FieldValue++;
                if (CheckField(x + 1, y - 1))
                    field.FieldValue++;
                //field.FieldButton.Text = field.FieldValue.ToString();
            }
        }
    }
}