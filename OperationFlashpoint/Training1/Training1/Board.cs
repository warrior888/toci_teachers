using Training1.Interfaces;

namespace Training1
{
    public class ChessBoard : IBoard
    {
        public IField[,] Board { get; set; }

        public ChessBoard()
        {
            Board = new IField[8,8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = GetField(i,j);
                }
            }
        }

        public virtual IField GetField(int i, int j)
        {
            Field f = new Field();
            f.XCoordinate = (i * 20) + 20;
            f.YCoordinate = (j * 20) + 20;


            return f;
        }
    }
}