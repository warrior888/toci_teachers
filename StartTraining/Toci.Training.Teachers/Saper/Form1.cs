using System;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {
        private Game _gameStart;
        //private GameDifficultyLevel _difficultyLevel;

        public Form1()
        {
            InitializeComponent();
            difficultyComboBox.SelectedIndex = 0;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            _gameStart = new Game(panel1, difficultyComboBox);
        }
    }
}
