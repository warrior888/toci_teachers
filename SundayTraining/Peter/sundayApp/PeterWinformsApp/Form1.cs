using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeterWinformsApp
{
    public  partial class Form1 : Form
    {
        AddMethods Methods = new AddMethods();
        AddItem addItem = new AddItem();
        ShuffleMethod shuffleMethod = new ShuffleMethod();

        public Form1()
        {
            InitializeComponent();
            AddButonns();
            AddTextBox();
            AddLabels();
        }

        
        public void AddButonns()
        {
            Button ButoonToAddPlayer = addItem.CreateButton(32, 28, "Add player", 100, 49);
            ButoonToAddPlayer.Click += Methods.ButoonToAddPlayerOnClick;
            Controls.Add(ButoonToAddPlayer);

            Button ButoonToShowPlayersList = addItem.CreateButton(32, 83, "Show players", 100, 49);
            ButoonToShowPlayersList.Click += ButoonToShowPlayersListOnClick;
            Controls.Add(ButoonToShowPlayersList);

            Button ButoonToMakeGroups = addItem.CreateButton(361, 28, "Get a groups", 100, 49);
            ButoonToMakeGroups.Click += ButoonToMakeGroupsOnClick;
            Controls.Add(ButoonToMakeGroups);

            Button ButoonToAddPoints = addItem.CreateButton(668, 28, "Add points", 100, 49);
            ButoonToAddPoints.Click += Methods.ButoonToAddPointsOnClick ;
            Controls.Add(ButoonToAddPoints);

            Button ButoonToChooseSecondStage = addItem.CreateButton(640, 118, "Second stage", 100, 49);
            ButoonToChooseSecondStage.Click += ButoonToChooseSecondStageOnClick;
            Controls.Add(ButoonToChooseSecondStage);

            Button ButoonToChooseTheWinners = addItem.CreateButton(948, 118, "Choose the WINNERS", 100, 49);
            ButoonToChooseTheWinners.Click += ButoonToChooseTheWinnersOnClick;
            Controls.Add(ButoonToChooseTheWinners);
        }
        public void AddTextBox()
        {
            ItemsBox.StartPlayerName = addItem.CreateTextBox(261, 40, "name", 158, 40);
            Controls.Add(ItemsBox.StartPlayerName);

            ItemsBox.PointsBox = addItem.CreateTextBox(978, 64, "points",78 , 20);
            Controls.Add(ItemsBox.PointsBox);

            ItemsBox.PlayerNameBox = addItem.CreateTextBox(878, 28, "name", 78, 20);
            Controls.Add(ItemsBox.PlayerNameBox);
        }

        public void AddLabels()
        {
            Label PlayerNameLabel = addItem.CreateLabel(774, 30, "Write player name", 100, 16, Color.DarkGray , 10);
            Controls.Add(PlayerNameLabel);
            Label PointsLabel = addItem.CreateLabel(794, 65, "Write player points", 120, 16, Color.DarkGray,10);
           Controls.Add(PointsLabel);
        }

        public void ButoonToShowPlayersListOnClick(object sender, EventArgs eventArgs)
        {
            int y = 83;
            int i = 1;
            foreach (var name in ItemsBox.lexicon)
            {
                Label label = new Label();
                label = addItem.CreateLabel(161, y,   i + ")  " + name.Key  , 150, 20, Color.Azure,12);
                y += 20;
                i++;
                Controls.Add(label);
            }
        }
        
        public void ButoonToMakeGroupsOnClick(object sender, EventArgs eventArgs)
        {
            int y = 40;
            if (ItemsBox.makeGroupsSave == 0)
            {
                ItemsBox.lexiconSecondStage = shuffleMethod.shuffle(ItemsBox.lexicon, 4, 2);
                Label labelGroups = addItem.CreateLabel(480, y, "Groups : ", 150, 20, Color.Azure,12);
                Controls.Add(labelGroups);

                foreach (var name in ItemsBox.lexiconSecondStage)
                {
                    Label label = new Label();
                    label = addItem.CreateLabel(480, y + 30, ItemsBox.toFour + 1 + ") " + name.Key , 150, 20, Color.Azure,12);
                    y += 20;
                    ItemsBox.toFour++;
                    if (ItemsBox.toFour >= 4)
                    {
                        ItemsBox.toFour = 0;
                        y += 40;
                    }
                    Controls.Add(label);
                }
            }
            if(ItemsBox.makeGroupsSave >0)
            {
                Label label = new Label();
                label = addItem.CreateLabel(480, y +40, "only one shuffle", 150, 20, Color.Azure,12);
                Controls.Add(label);
            }
            ItemsBox.makeGroupsSave++;
        }

        public void ButoonToChooseSecondStageOnClick(object sender, EventArgs eventArgs)
        {
            int y = 120;
            Methods.MakeWinnersList();
            foreach (var name in ItemsBox.lexiconOfWiners)
            {
                Label label = new Label();
                label = addItem.CreateLabel(750, y, ItemsBox.toTwo + 1 + ") " + name.Key + "  " + name.Value + " pkt"  , 170, 20, Color.Azure,12);
                y += 20;
                ItemsBox.toTwo++;
                if (ItemsBox.toTwo >=2)
                {
                    ItemsBox.toTwo = 0;
                    y += 40;
                }
                Controls.Add(label);
            }
        }
        public void ButoonToChooseTheWinnersOnClick(object sender, EventArgs eventArgs)
        {
            List<KeyValuePair<string, int>> sorted = (from v in ItemsBox.lexiconOfWiners orderby v.Value select v).ToList();
            Label winLabel1 = addItem.CreateLabel(1056, 101, "WINNERS :", 170, 45, Color.DarkGray, 20);
            Controls.Add(winLabel1);
            int y = 147;
            int place = 4;
            foreach (var item in sorted)
            {
                Label label = new Label();
                label = addItem.CreateLabel(1056, y, place + ") " + item.Key + "  " + item.Value + " pkt", 170, 20, Color.AntiqueWhite, 10);
                y += 30;
                label.Font = new Font(Font.FontFamily, 12);
                place--;
                
                Controls.Add(label);
            }
        }
    }
}
