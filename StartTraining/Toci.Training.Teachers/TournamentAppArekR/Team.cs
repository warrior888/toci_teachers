using System.Collections.Generic;
using System.Linq;

namespace TournamentAppArekR
{
    public class Team
    {
        public List<PlayerEntity> Players;
        public string Name;
        public int GetScore()
        {
            return Players.Sum(player => player.Score);
        }
    }
}