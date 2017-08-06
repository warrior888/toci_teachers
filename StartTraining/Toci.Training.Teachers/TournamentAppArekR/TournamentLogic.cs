using System;
using System.Collections.Generic;
using System.Linq;

namespace TournamentAppArekR
{
    public class TournamentLogic
    {
        public List<Team> TournamentTeams { get; set; }
        public static List<DuellPairEntity> DuellPairs { get; set; }
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
            //UnSelectAllTeams();
            DuellPairs = new List<DuellPairEntity>();
            int numberOfDuells = TournamentTeams.Sum(tt => tt.Players.Count(pl => !pl.IsEliminated)) / 2;
            for (int i = 0; i < numberOfDuells; i++)
            {
                DuellPairEntity duellPair = new DuellPairEntity();
                for (int j = 0; j < 2; j++)
                {
                    var teams = TournamentTeams.Where(tt => tt.Players.Count(pl => !pl.IsSelected && !pl.IsEliminated) > 0).ToList();
                    if (!(teams?.Count > 0)) return;
                    Random rnd = new Random();
                    int tempIndex = rnd.Next(0, teams.Count);
                    int index = TournamentTeams.FindIndex(tt => tt.Name.Equals(teams[tempIndex].Name));
                    TournamentTeams[index].IsSelected = numberOfDuells > 1;
                    PlayerEntity tempPlayer = PrepareDuellPlayer(TournamentTeams[index].Players);

                    if (j == 0)
                    {
                        duellPair.Player1 = new PlayerEntity { Name = tempPlayer.Name };
                    }
                    else
                    {
                        duellPair.Player2 = new PlayerEntity { Name = tempPlayer.Name };
                    }
                }
                DuellPairs.Add(duellPair);
                //UnSelectAllTeams();
            }
        }

        private void UnSelectAllTeams()
        {
            foreach (var team in TournamentTeams)
            {
                team.IsSelected = false;
            }
        }

        private PlayerEntity PrepareDuellPlayer(List<PlayerEntity> players)
        {
            Random rnd = new Random();
            var tempTeam = players.Where(p => !p.IsEliminated && !p.IsSelected).ToList();
            int tempIndex = rnd.Next(0, tempTeam.Count);
            int indx = players.FindIndex(pl => pl.Name.Equals(tempTeam[tempIndex].Name));
            players[indx].IsSelected = true;
            return players[indx];
        }

        public void FinishDuell(int indx)
        {
            SaveDuellScore(TournamentTeams.FirstOrDefault(tt => tt.Players.Count(pl => pl.Name.Equals(DuellPairs[indx].Player1.Name)) > 0), DuellPairs[indx].Player1, indx);
            SaveDuellScore(TournamentTeams.FirstOrDefault(tt => tt.Players.Count(pl => pl.Name.Equals(DuellPairs[indx].Player2.Name)) > 0), DuellPairs[indx].Player2, indx);
        }


        public PlayerEntity GetTotalWinner()
        {

            //var test = TournamentTeams.Sum(tt => tt.Players.Count(pl => !pl.IsEliminated));
            return TournamentTeams.Sum(tt => tt.Players.Count(pl => !pl.IsEliminated)) == 1 ?
                TournamentTeams.Select(tt => tt.Players.FirstOrDefault(pl => !pl.IsEliminated)).FirstOrDefault()
                : null;
        }


        private static void SaveDuellScore(Team team, PlayerEntity player, int indx)
        {
            int index = team.Players.FindIndex(pl => pl.Name.Equals(player.Name));
            if (index >= 0)
            {
                team.IsSelected = false;
                team.Players[index].Score += player.Score;
                team.Players[index].IsEliminated = team.Players[index].Name.Equals(DuellPairs[indx].GetLoser().Name);
                team.Players[index].IsSelected = false;
            }
        }
    }
}