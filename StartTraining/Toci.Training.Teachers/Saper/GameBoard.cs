using System;
using System.Drawing;
using System.Windows.Forms;

namespace Saper
{
    public class GameBoard
    {
        public byte NumberOfBomb { get; }       // TODO: Dodać zliczanie bomb podczas oznaczania pól

        private readonly SingleField[,] _board;
        private readonly int[] _boardSize; // _boardSize[0] - lenght, _boradSize[1] - width
        private readonly Random _random;
        private readonly Panel _panel;

        public GameBoard()
        {
            // empty
        }

        public GameBoard(GameDifficultyLevel difficultyLevel, Panel panel)
        {
            _random = new Random();
            _panel = panel;
            switch (difficultyLevel)
            {
                case GameDifficultyLevel.Easy:
                    _boardSize = new[] {8, 8};
                    _board = new SingleField[_boardSize[0], _boardSize[1]]; //8x8 field
                    NumberOfBomb = 10;
                    break;
                case GameDifficultyLevel.Normal:
                    _boardSize = new[] {16, 16};
                    _board = new SingleField[_boardSize[0], _boardSize[1]]; // 16x16 field
                    NumberOfBomb = 40;
                    break;
                case GameDifficultyLevel.Hard:
                    _boardSize = new[] {16, 30};
                    _board = new SingleField[_boardSize[0], _boardSize[1]]; // 30x16 field
                    NumberOfBomb = 99;
                    break;
            }
            ArrangeTheBombs();
            BombsInTheNeighborhood();
        }

        public void ClearBoard(Panel panel)
        {
            panel.Controls.Clear();
        }

        private void ArrangeTheBombs() // Places bombs
        {
            int positionX = 0;
            int positionY = 0;
            int i;
            for (i = 0; i < _boardSize[0]; i++)
            {

                for (int j = 0; j < _boardSize[1]; j++)
                {
                    _board[i, j] = new SingleField(i, j);
                    var field = _board[i, j];
                    field.FieldButton.Location = new Point(positionX, positionY);
                    _panel.Controls.Add(field.FieldButton);
                    positionX += 30;

                    field.ShowW += new EventHandler((o, args) => OpenField(o, args, field));  // ??
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
                field.Explosion += new EventHandler(Boom);
                i++;
            }
        }

        private void Boom(Object sender, EventArgs e)
        {
            foreach (var field in _board)
            {
                if (field.FieldValue == 9)
                {
                    field.FieldButton.Text = @"X";
                    field.FieldButton.BackColor = Color.Red;
                }
                else
                {
                    field.FieldButton.Text = field.FieldValue.ToString();
                    field.FieldButton.BackColor = Color.Aqua;
                }
            }
            _panel.Enabled = false;
            MessageBox.Show(@"Game over");
        }

        private bool CheckField(int x, int y)
        {
            if (x >= 0 && x < _boardSize[0])
                if (y >= 0 && y < _boardSize[1])
                    return _board[x, y].HasABomb;
            return false;
        }

        private void BombsInTheNeighborhood()
        {
            foreach (var field in _board)
            {
                int x = field.X,
                    y = field.Y;
                if (field.IsHide && !field.HasABomb)
                {
                    if (CheckField(x - 1, y + 1))
                        field.FieldValue++;
                    if (CheckField(x - 1, y))
                        field.FieldValue++;
                    if (CheckField(x - 1, y - 1))
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
                }
            }
        }

        private void ShowFields(int x, int y)
        {
            if (x >= 0 && x < _boardSize[0])
                if (y >= 0 && y < _boardSize[1])
                    if (_board[x, y].IsHide)
                        if (!_board[x, y].HasABomb)
                        {
                            _board[x, y].IsHide = false;
                            _board[x, y].FieldButton.Text = _board[x, y].FieldValue.ToString();
                            _board[x, y].FieldButton.BackColor = Color.Aqua;
                            _board[x, y].FieldButton.Enabled = false;
                            Show(_board[x, y]);
                        }
        }

        private void Show(SingleField field)
        {
            if (field.FieldValue == 0)
            {
                int x = field.X,
                    y = field.Y;

                ShowFields(x - 1, y + 1);
                ShowFields(x - 1, y);
                ShowFields(x - 1, y - 1);
                ShowFields(x, y + 1);
                ShowFields(x, y);
                ShowFields(x, y - 1);
                ShowFields(x + 1, y + 1);
                ShowFields(x + 1, y);
                ShowFields(x + 1, y - 1);
            }
        }
 
        private  void OpenField(Object sender, EventArgs e, SingleField field)
        {
            Show(field);
        }
    }

}