namespace TournamentAppArekR
{
    public class DuellPairEntity
    {
        public PlayerEntity Player1 { get; set; }
        public PlayerEntity Player2 { get; set; }

        public bool CheckForWinner()
        {
            return Player1.Score != Player2.Score;
        }

        public PlayerEntity GetWinner()
        {
            return Player1.Score > Player2.Score ? Player1 : Player2;
        }

        public PlayerEntity GetLoser()
        {
            if (Player1.Score < Player2.Score)
            {
                Player1.IsEliminated = true;
                return Player1;
            }
            Player2.IsEliminated = true;
            return Player2;

        }
    }
}