using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentAppArekR
{
    public partial class TournamentFrm : Form
    {
        private List<PlayerEntity> _playersTemporary;
        private int _numberOfPlayers;
        private PlayerEntity winner;
        //private List<Team> _tournamentTeams;
        private TournamentLogic tournament;
        public TournamentFrm()
        {
            InitializeComponent();
            StartTournament();
        }

        private void StartTournament()
        {
            _playersTemporary = new List<PlayerEntity>();
            tournament = new TournamentLogic();
            tournament.CreateTeams();

        }

        private void AddNewUser(string userName)
        {
            if (userName?.Length == 0)
            {
                MessageBox.Show("Nazwa użytkownika nie może być pusta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_playersTemporary.Any(pt => pt.Name.Equals(userName)))
            {
                MessageBox.Show("Użytkownik o takiej nazwie już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _playersTemporary.Add(new PlayerEntity { Name = userName });
                SetScoreTable();
                if (CheckNumberOfPlayers()) return;
                SetNewPlayerLabelText();
            }
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser(txtAddUser.Text);
            txtAddUser.Text = "";
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
            txtAddUser.Focus();
        }

        private void SetScoreTable()
        {
            try
            {
                if (!(_playersTemporary?.Count > 0)) return;
                DataTable dt = new DataTable();
                SetDataTableHeaders(dt, "Gracz", "Drużyna", "Wynik");
                SetScoreTableRow(dt, _playersTemporary);
                DisplayScoreTable(dt, dgvTrnmtScore);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DisplayScoreTable(DataTable dt, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = dt;
            dgv.Refresh();
        }


        private void SetScoreTable(IEnumerable<Team> teams)
        {
            try
            {
                if (!(teams?.Count() > 0)) return;
                DataTable dt = new DataTable();
                SetDataTableHeaders(dt, "Gracz", "Drużyna", "Wynik");
                DataColumn column = new DataColumn("Status")
                {
                    DataType = Type.GetType("System.Byte[]"),
                    AllowDBNull = true,
                    Caption = "Status"
                };
                dt.Columns.Add(column);
                SetScoreTableRow(dt, teams);
                DisplayScoreTable(dt, dgvTrnmtScore);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
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
                    workRow[i++] = t.Score;
                    workRow[i] = ImageToByteArray(t.IsEliminated ? Properties.Resources.cross : Properties.Resources.tick);
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
            tournament.ShufflePlayers(_playersTemporary, _numberOfPlayers);
            SetScoreTable(tournament.TournamentTeams);
            btnStartTournament.Enabled = false;
        }


        private void txtAddUser_TextChanged(object sender, EventArgs e)
        {
            btnAddUser.Enabled = ((TextBox)sender).Text.Length > 0;
        }

        private void btnGetDuell_Click(object sender, EventArgs e)
        {
            tournament.PrepareDuell();
            new DuellForm().ShowDialog();
            tournament.FinishDuell();
            SetScoreTable(tournament.TournamentTeams);
            winner = tournament.GetTotalWinner();
            if (winner is null) return;
            btnGetDuell.Enabled = false;
            MessageBox.Show("Wygrywa gracz "+winner.Name + " Brawo ON!", "And the winner is...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
