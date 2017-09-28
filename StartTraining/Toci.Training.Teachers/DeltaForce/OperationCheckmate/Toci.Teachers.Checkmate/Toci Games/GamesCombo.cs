using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci_Games.Bll;

namespace Toci_Games
{
    public partial class GamesCombo : Form
    {
        public GamesCombo()
        {
            InitializeComponent();
            PresentGames();
            ComboUtils u = new ComboUtils();

            u.TpShowdown();
        }

        protected virtual void PresentGames()
        {
            int x = 20;
            int progress = 100;

            foreach (KeyValuePair<string, RadioButton> gameEntry in ComboUtils.AllGamesWeOffer)
            {
                gameEntry.Value.Location = new Point(x += progress, 20);

                Controls.Add(gameEntry.Value);
            }
        }
    }
}
