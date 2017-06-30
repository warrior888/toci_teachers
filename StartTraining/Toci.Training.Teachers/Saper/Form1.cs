using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            _gameStart = new Game(panel1, difficultyComboBox);
        }
    }
}
