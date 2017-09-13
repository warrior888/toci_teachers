using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

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
        public bool IsSelected;

        public void GetTournamentDuelPairs()
        {
            Random rnd= new Random();
            var index = rnd.Next(0, Players.Count);


        }
    }
}