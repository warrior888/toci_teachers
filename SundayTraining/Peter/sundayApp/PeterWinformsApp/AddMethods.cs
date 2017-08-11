using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PeterWinformsApp.Form1;          

namespace PeterWinformsApp
{
    public class AddMethods 
    {
        ShuffleMethod shuffleMethod = new ShuffleMethod();

        public void ButoonToAddPlayerOnClick(object sender, EventArgs e)
        {
            if (!ItemsBox.lexicon.ContainsKey(ItemsBox.StartPlayerName.Text))
            {
                ItemsBox.lexicon.Add(ItemsBox.StartPlayerName.Text, 0);               
            }
        }

        public void ButoonToAddPointsOnClick(object sender, EventArgs eventArgs)
        {
            Int32 number = 0;
            if (Int32.TryParse(ItemsBox.PointsBox.Text, out number) && ItemsBox.lexiconSecondStage.ContainsKey(ItemsBox.PlayerNameBox.Text))
            {
                ItemsBox.lexiconSecondStage[ItemsBox.PlayerNameBox.Text] += Convert.ToInt32(ItemsBox.PointsBox.Text);
            }
        }

        public void MakeWinnersList()
        {
            List<KeyValuePair<string, int>> sorted = (from v in ItemsBox.lexiconSecondStage orderby v.Value select v).ToList();
            int judge = 0;
            ItemsBox.lexiconSecondStage.Clear();
            foreach (var item in sorted)
            {
                if (judge >= sorted.Count-4)
                {
                    ItemsBox.lexiconSecondStage.Add(item.Key, item.Value);
                }
                judge++;
            }
            ItemsBox.lexiconOfWiners = shuffleMethod.shuffle(ItemsBox.lexiconSecondStage, 3, 2);
        }
    }
}