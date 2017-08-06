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
    public partial class Form1 : test
    {
        AddMethods Methods = new AddMethods();
        AddItem item = new AddItem();
        ShuffleMethod method = new ShuffleMethod();
        public static Dictionary<string, int> lexicon = new Dictionary<string, int>();
        public static Dictionary<string, int> lexiconSecondStage = new Dictionary<string, int>();
        public static Dictionary<string, int> lexiconOfWiners = new Dictionary<string, int>();
        public static TextBox StartPlayerName = new TextBox();
        public static TextBox PointsBox = new TextBox();
        public static TextBox PlayerNameBox = new TextBox();

        test Test= new test();

        public Form1()
        {
            InitializeComponent();
            AddButonns();
            AddTextBox();
            Test.make();
            
        }

        
        public static Dictionary<string, int> GetDictionary()
        {
            return lexicon;
        }
        public static Dictionary<string, int> GetDictionaryForSecondStage()
        {
            return lexiconSecondStage;
        }
        public void AddButonns()
        {
            Button ButoonToAddPlayer = item.CreateButton(32, 28, "Add player", 100, 49);
            ButoonToAddPlayer.Click += Methods.ButoonToAddPlayerOnClick;
            Controls.Add(ButoonToAddPlayer);

            Button ButoonToShowPlayersList = item.CreateButton(32, 83, "Show players", 100, 49);
            ButoonToShowPlayersList.Click += ButoonToShowPlayersListOnClick;
            Controls.Add(ButoonToShowPlayersList);

            Button ButoonToMakeGroups = item.CreateButton(361, 28, "Get a groups", 100, 49);
            ButoonToMakeGroups.Click += ButoonToMakeGroupsOnClick;
            Controls.Add(ButoonToMakeGroups);

            Button ButoonToAddPoints = item.CreateButton(668, 28, "Add points", 100, 49);
            ButoonToAddPoints.Click += Methods.ButoonToAddPointsOnClick ;
            Controls.Add(ButoonToAddPoints);

            Button ButoonToChooseSecondStage = item.CreateButton(668, 118, "Second stage", 100, 49);
            ButoonToChooseSecondStage.Click += ButoonToChooseSecondStageOnClick;
            Controls.Add(ButoonToChooseSecondStage);

            Button ButoonToChooseTheWinners = item.CreateButton(948, 118, "Choose the WINNERS", 100, 49);
            ButoonToChooseTheWinners.Click += ButoonToChooseTheWinnersOnClick;
            Controls.Add(ButoonToChooseTheWinners);
        }
        public void AddTextBox()
        {
            StartPlayerName = item.CreateTextBox(161, 28, "name", 158, 40);
            Controls.Add(StartPlayerName);

            PointsBox = item.CreateTextBox(878, 64, "points",78 , 20);
            Controls.Add(PointsBox);

            PlayerNameBox = item.CreateTextBox(878, 28, "name", 78, 20);
            Controls.Add(PlayerNameBox);
        }

        public void ButoonToShowPlayersListOnClick(object sender, EventArgs eventArgs)
        {
            int y = 83;
            int i = 0;
            foreach (var name in lexicon)
            {
                Label label = new Label();
                label = item.CreateLabel(161, y, "", 100, 20);
                label.Text += name.Key;
                label.Font = new Font(Font.FontFamily,12);
                y += 20;
                i++;
                Controls.Add(label);
            }
        }
        public void ButoonToMakeGroupsOnClick(object sender, EventArgs eventArgs)
        {
            
            lexiconSecondStage = method.shuffle(lexicon,4,2);
            int toFour = 0;
            int y = 28;
            foreach (var name in lexiconSecondStage)
            {
                Label label = new Label();
                label = item.CreateLabel(494, y, "", 150, 20);
                y += 20;
                label.Text = toFour + 1 + ") " + name.Key;
                label.Font = new Font(Font.FontFamily, 12);
                toFour++;
                if (toFour >= 4)
                {
                    toFour = 0;
                    y += 40;
                }
                Controls.Add(label);
            }
        }

        public void ButoonToChooseSecondStageOnClick(object sender, EventArgs eventArgs)
        {
            List<KeyValuePair<string, int>> sorted = (from v in lexiconSecondStage orderby v.Value select v).ToList();
            int judge = 0;
            lexiconSecondStage.Clear();
            foreach (var item in sorted)
            {
                if (judge > sorted.Count-4)
                {
                    lexiconSecondStage.Add(item.Key, item.Value);
                    judge++;
                }
            }
            lexiconOfWiners = method.shuffle(lexiconSecondStage, 3, 2);
            int toTwo = 0;
            int y = 120;
            foreach (var name in lexiconOfWiners)
            {
                Label label = new Label();
                label = item.CreateLabel(750, y, "", 170, 20);
                y += 20;
                label.Text = toTwo + 1 + ") " + name.Key + "  " + name.Value + " pkt";
                label.Font = new Font(Font.FontFamily, 12);
                toTwo++;
                if (toTwo >=2)
                {
                    toTwo = 0;
                    y += 40;
                }
                Controls.Add(label);
            }
        }
        public void ButoonToChooseTheWinnersOnClick(object sender, EventArgs eventArgs)
        {
            List<KeyValuePair<string, int>> sorted = (from v in lexiconOfWiners orderby v.Value select v).ToList();
            
            Label winLabel1 = item.CreateLabel(1056, 101, "WINNERS :", 170, 40);
            winLabel1.Font = new Font(Font.FontFamily,20);
            Controls.Add(winLabel1);
            int y = 137;
            foreach (var name in lexiconOfWiners)
            {
                Label label = new Label();
                label = item.CreateLabel(1056, y,"" , 170, 20);
                
                label.Text =  1 + ") " + name.Key + "  " + name.Value + " pkt";
                label.Font = new Font(Font.FontFamily, 12);
                
                Controls.Add(label);
            }
        }
    }
}
