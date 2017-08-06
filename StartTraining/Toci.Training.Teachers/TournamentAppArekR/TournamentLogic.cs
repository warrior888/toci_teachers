using System;
using System.Collections.Generic;
using System.Linq;

namespace TournamentAppArekR
{
    public class TournamentLogic
    {
        public List<Team> TournamentTeams { get; set; }
        public static DuellPairEntity DuellPair { get; set; }
        public void CreateTeams()
        {
            TournamentTeams = new List<Team>
            {
                new Team() {Name = "Dryzuna A"},
                new Team() {Name = "Dryzuna B"},
                new Team() {Name = "Dryzuna C"},
                new Team() {Name = "Dryzuna D"}
            };
        }

        public void ShufflePlayers(List<PlayerEntity> playerEntities, int participantsCount)
        {
            foreach (Team t in TournamentTeams)
            {
                for (int j = 0; j < participantsCount / TournamentTeams.Count; j++)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(0, playerEntities.Count);
                    if (!(t.Players?.Count > 0)) // if (t.Players is null)
                    {
                        t.Players = new List<PlayerEntity>();
                    }
                    t.Players.Add(playerEntities[index]);
                    playerEntities.RemoveAt(index);
                }
            }
        }


        public void PrepareDuell()
        {
            DuellPair = new DuellPairEntity();
            foreach (var team in TournamentTeams)
            {
                team.IsSelected = false;
            }

            for (int i = 0; i < 2; i++)
            {
                var teams = TournamentTeams.Where(tt => !tt.IsSelected && tt.Players.Count(pl => !pl.IsEliminated) > 0).ToList();
                if (!(teams?.Count > 0)) return;
                Random rnd = new Random();
                int tempIndex = rnd.Next(0, teams.Count);
                int index = TournamentTeams.FindIndex(tt => tt.Name.Equals(teams[tempIndex].Name));
                TournamentTeams[index].IsSelected = true;
                PlayerEntity tempPlayer = PrepareDuellPlayer(TournamentTeams[index].Players);

                if (i == 0)
                {
                    DuellPair.Player1 = new PlayerEntity {Name = tempPlayer.Name};
                    //DuellPair.Player1.Score = 0;
                }
                else
                {
                    DuellPair.Player2 = new PlayerEntity { Name = tempPlayer.Name };
                    //DuellPair.Player2.Score = 0;
                }

            }
        }

        private PlayerEntity PrepareDuellPlayer(List<PlayerEntity> players)
        {
            Random rnd = new Random();
            var tempTeam = players.Where(p => !p.IsEliminated).ToList();
            int index = rnd.Next(0, tempTeam.Count);
            return players.FirstOrDefault(pl => pl.Name.Equals(tempTeam[index].Name));
        }

        public void FinishDuell()
        {
            var teams = TournamentTeams.Where(tt => tt.IsSelected).ToList();
            SaveDuellScore(teams.FirstOrDefault(tt => tt.Players.Count(pl => pl.Name.Equals(DuellPair.Player1.Name)) > 0), DuellPair.Player1);
            SaveDuellScore(teams.FirstOrDefault(tt => tt.Players.Count(pl => pl.Name.Equals(DuellPair.Player2.Name)) > 0), DuellPair.Player2);
        }


        public PlayerEntity GetTotalWinner()
        {

            //var test = TournamentTeams.Sum(tt => tt.Players.Count(pl => !pl.IsEliminated));
            return TournamentTeams.Sum(tt => tt.Players.Count(pl => !pl.IsEliminated)) == 1 ?
                TournamentTeams.Select(tt => tt.Players.FirstOrDefault(pl => !pl.IsEliminated)).FirstOrDefault()
                : null;
        }


        private static void SaveDuellScore(Team team, PlayerEntity player)
        {
            int index = team.Players.FindIndex(pl => pl.Name.Equals(player.Name));
            if (index >= 0)
            {
                team.IsSelected = false;
                team.Players[index].Score += player.Score;
                team.Players[index].IsEliminated = team.Players[index].Name.Equals(DuellPair.GetLoser().Name);
            }
        }
    }
}