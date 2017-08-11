namespace TournamentAppArekR
{
    public class PlayerEntity
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsEliminated { get; set; }
        public bool IsSelected { get; set; }
        public int DuellCount { get; set; }
    }
}