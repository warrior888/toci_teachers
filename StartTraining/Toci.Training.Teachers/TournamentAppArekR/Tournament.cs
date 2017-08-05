﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentAppArekR
{
    public partial class Tournament : Form
    {
        private List<PlayerEntity> _playersTemporary;
        private int _numberOfPlayers;
        private List<Team> _tournamentTeams;

        public Tournament()
        {
            InitializeComponent();
            StartTournament();
        }

        private void StartTournament()
        {
            _playersTemporary = new List<PlayerEntity>();
            _tournamentTeams = new List<Team>
            {
                new Team(){Name = "Dryzuna A" },
                new Team() { Name = "Dryzuna B" },
                new Team() { Name = "Dryzuna C" },
                new Team() { Name = "Dryzuna D" }
            };
        }

        private bool CheckNumberOfPlayers()
        {
            if (_numberOfPlayers != _playersTemporary.Count) return false;
            txtAddUser.Enabled =
                btnAddUser.Enabled =
                btnNumberOfPlayers.Enabled =
                numNumberOfPlayers.Enabled = false;
            btnStartTournament.Visible = true;
            lblEnterNewPlayer.Text = "";

            return true;
        }

        private void AddNewUser(string userName)
        {
            if (userName?.Length == 0)
            {
                MessageBox.Show("Nazwa użytkownika nie może być pusta");
            }
            else if (_playersTemporary.Any(pt => pt.Name.Equals(userName)))
            {
                MessageBox.Show("Użytkownik o takiej nazwie już istnieje");
            }
            else
            {
                _playersTemporary.Add(new PlayerEntity { Name = userName });
                SetScoreTable();
                if (CheckNumberOfPlayers()) return;
                SetNewPlayerLabelText();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser(txtAddUser.Text);
            txtAddUser.Text = "";
            txtAddUser.Focus();
        }

        private void txtAddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            AddNewUser(((TextBox)sender).Text);
            ((TextBox)sender).Text = "";
        }

        private void btnNumberOfPlayers_Click(object sender, EventArgs e)
        {
            _numberOfPlayers = (int)numNumberOfPlayers.Value;
            txtAddUser.Enabled = true;
            SetNewPlayerLabelText();
        }

        private void SetNewPlayerLabelText()
        {
            lblEnterNewPlayer.Text = "Wprowadź imię gracza nr " + (_playersTemporary.Count + 1);
        }

        private void SetScoreTable()
        {
            try
            {
                if (!(_playersTemporary?.Count > 0)) return;
                DataTable dt = new DataTable();
                SetDataTableHeaders(dt, "Gracz", "Drużyna", "Wynik");
                SetScoreTableRow(dt, _playersTemporary);
                DisplayScoreTable(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DisplayScoreTable(DataTable dt)
        {
            dgvTrnmtScore.Columns.Clear();
            dgvTrnmtScore.DataSource = dt;
            dgvTrnmtScore.Refresh();
        }


        private void SetScoreTable(IEnumerable<Team> teams)
        {
            try
            {
                if (!(teams?.Count() > 0)) return;
                DataTable dt = new DataTable();
                SetDataTableHeaders(dt, "Gracz", "Drużyna", "Wynik");
                SetScoreTableRow(dt, teams);
                DisplayScoreTable(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SetScoreTableRow(DataTable dt, IEnumerable<Team> teams)
        {
            foreach (var teamItem in teams)
            {
                foreach (PlayerEntity t in teamItem.Players)
                {
                    int i = 0;
                    DataRow workRow = dt.NewRow();
                    workRow[i++] = t.Name;
                    workRow[i++] = teamItem.Name;
                    workRow[i] = t.Score;
                    dt.Rows.Add(workRow);
                }
            }
        }

        private void SetScoreTableRow(DataTable dt, IEnumerable<PlayerEntity> players)
        {
            foreach (var item in players)
            {
                int i = 0;
                DataRow workRow = dt.NewRow();
                workRow[i++] = item.Name;
                workRow[i++] = "-";
                workRow[i] = item.Score;
                dt.Rows.Add(workRow);
            }
        }

        private void SetDataTableHeaders(DataTable dt, params string[] columnNames)
        {
            foreach (var item in columnNames)
            {
                dt.Columns.Add(item);
            }
        }
        private void btnStartTournament_Click(object sender, EventArgs e)
        {
            ShufflePlayers();
            SetScoreTable(_tournamentTeams);
        }

        private void ShufflePlayers()
        {
            foreach (Team t in _tournamentTeams)
            {
                for (int j = 0; j < _numberOfPlayers / _tournamentTeams.Count; j++)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(0, _playersTemporary.Count);
                    if (!(t.Players?.Count > 0))
                    {
                        t.Players = new List<PlayerEntity>();
                    }
                    t.Players.Add(_playersTemporary[index]);
                    _playersTemporary.RemoveAt(index);
                }
            }
        }

        private void txtAddUser_TextChanged(object sender, EventArgs e)
        {
            btnAddUser.Enabled = ((TextBox)sender).Text.Length > 0;
        }
    }
}
