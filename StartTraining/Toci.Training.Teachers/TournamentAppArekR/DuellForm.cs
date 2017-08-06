using System;
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
    public partial class DuellForm : Form
    {
        public DuellForm()
        {
            InitializeComponent();
            lblPlayer1.Text = TournamentLogic.DuellPair.Player1.Name;
            lblPlayer2.Text = TournamentLogic.DuellPair.Player2.Name;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TournamentLogic.DuellPair.Player1.Score = (int)((NumericUpDown)sender).Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TournamentLogic.DuellPair.Player2.Score = (int)((NumericUpDown)sender).Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TournamentLogic.DuellPair.CheckForWinner())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("pojedynek musi wyłonic zwycięzcę");
            }
        }

        private void DuellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TournamentLogic.DuellPair.CheckForWinner())
            {
                e.Cancel = true;
                MessageBox.Show("pojedynek musi wyłonić zwycięzcę");
            }
        }
    }
}
