using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static PeterWinformsApp.Form1;          

namespace PeterWinformsApp
{
    public class AddMethods 
    {
        Dictionary<string, int> lexicon = GetDictionary();
        Dictionary<string, int> lexiclexiconSecondStageons = GetDictionaryForSecondStage();
        

        public void ButoonToAddPlayerOnClick(object sender, EventArgs e)
        {
            if (!lexicon.ContainsKey(StartPlayerName.Text))
            {
                lexicon.Add(StartPlayerName.Text, 0);               
            }
        }

        public void ButoonToAddPointsOnClick(object sender, EventArgs eventArgs)
        {
            Dictionary<string, int> lexiconSecondStage = GetDictionaryForSecondStage();
            Int32 number = 0;
            if (Int32.TryParse(PointsBox.Text, out number) && lexiconSecondStage.ContainsKey(PlayerNameBox.Text))
            {
                lexiconSecondStage[PlayerNameBox.Text] += Convert.ToInt32(PointsBox.Text);
            }
        }

        
        
    }
}