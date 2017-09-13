using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sundayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                Create();
                AddButoonToAddPlayer();
                AddButoonToShowPlayersList();
                //AddButoonToCreateRandomPlayers();
                AddButoonToMakeGroups();
                AddButoonToAddPoints();1    
                AddButoonToChooseSecondStage();
                AddButoonToChooseTheWinners();

            }
        }


        TextBox textBox = new TextBox();
        TextBox PointsBpx = new TextBox();
        TextBox PlayerNameBox = new TextBox();
        public static Dictionary<string, int> slownik = new Dictionary<string, int>();
        public static Dictionary<string, int> WinSlownik = new Dictionary<string, int>();

        public int players = 0;
        public static int howManyPlayers;
        public static string[] playersList = new string[50];
        public int pointsInTabel = 0;
        public int playerInTabel = 0;
        public int kontrolka = 0;




        public Button CreateButton(int x, int y, string tekst, int sizeX, int sizeY)
        {
            Button button = new Button();
            button.Size = new Size(sizeX, sizeY);
            button.Text = tekst;
            button.Location = new Point(x, y);
            Controls.Add(button);
            return button;
        }
        public TextBox CreateTextBox(int x, int y, string tekst, int sizeX, int sizeY)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(sizeX, sizeY);
            textBox.Text = tekst;
            textBox.Location = new Point(x, y);
            Controls.Add(textBox);
            return textBox;
        }
        public Label CreateLabel(int x, int y, string tekst, int sizeX, int sizeY)
        {
            Label label = new Label();
            label.BackColor = Color.AliceBlue;
            label.Size = new Size(sizeX, sizeY);
            label.Text = tekst;
            label.Font = new Font(Font.FontFamily, 10);
            label.Location = new Point(x, y);
            Controls.Add(label);
            return label;
        }



        public void Create()
        {
            textBox.Size = new Size(158, 40);
            textBox.Text = "";
            textBox.Location = new Point(161, 28);
            Controls.Add(textBox);

            PointsBpx.Size = new Size(78, 20);
            PointsBpx.Text = "points";
            PointsBpx.Location = new Point(878, 64);
            Controls.Add(PointsBpx);

            PlayerNameBox.Size = new Size(78, 20);
            PlayerNameBox.Text = "name";
            PlayerNameBox.Location = new Point(878, 28);
            Controls.Add(PlayerNameBox);


            //BackgroundImage = Image.FromFile(@"..\..\image.jpg");

            Label PlayerNameLabel = CreateLabel(774, 30, "Write player name", 100, 16);
            PlayerNameLabel.BackColor = Color.DarkGray;
            Label PointsLabel = CreateLabel(774, 65, "Write player points", 100, 16);
            PointsLabel.BackColor = Color.DarkGray;
        }

        public void AddButoonToAddPlayer()
        {
            Button button = CreateButton(32, 28, "Add player", 100, 49);
            button.Click += Button1OnClick;
        }
        public void AddButoonToShowPlayersList()
        {
            Button button = CreateButton(32, 83, "Show players", 100, 49);
            button.Click += Button2OnClick;
        }
        /*
        public void AddButoonToCreateRandomPlayers()
        {
            Button button = CreateButton(32, 138, "Uzupełnij tablice", 100, 49);
            button.Click += Button3OnClick;
        }
        */
        public void AddButoonToMakeGroups()
        {
            Button button = CreateButton(361, 28, "Get a groups", 100, 49);
            button.Click += Button4OnClick;
        }
        public void AddButoonToAddPoints()
        {
            Button button = CreateButton(668, 28, "Add points", 100, 49);
            button.Click += Button5OnClick;
        }
        public void AddButoonToChooseSecondStage()
        {
            Button button = CreateButton(668, 118, "Second stage", 100, 49);
            button.Click += Button6OnClick;
        }
        public void AddButoonToChooseTheWinners()
        {
            Button button = CreateButton(948, 118, "Choose the WINNERS", 100, 49);
            button.Click += Button7OnClick;
        }

        private void Button7OnClick(object sender, EventArgs e)
        {
            List<KeyValuePair<string, int>> sorted = (from v in WinSlownik orderby v.Value select v).ToList();
            string[] winners = new string[WinSlownik.Count];
            int[] points = new int[WinSlownik.Count];
            for (int i = 0; i < sorted.Count; i++)
            {
                winners[sorted.Count - 1 - i] = sorted[i].Key;
                points[sorted.Count - 1 - i] = sorted[i].Value;
            }
            int y = 137;
            Label winLabel1 = CreateLabel(1056, 101, "WINNERS :", 90, 20);
            winLabel1.Font = new Font(Font.FontFamily, 10);
            winLabel1.BackColor = Color.LightSlateGray;
            for (int i = 0; i < 3; i++)
            {
                if (winners.Length >= 3)
                {

                    Label label = CreateLabel(1054, y, "(" + (i + 1) + ") " + winners[i] + " :   " + points[i] + " pkt", 200, 20);
                    y += 40;
                }
                else
                {
                    if (winners.Length > 0)
                    {
                        Label label = CreateLabel(1054, y, "(" + (1) + ") " + winners[0] + " :   " + points[0] + " pkt", 200, 20);
                    }
                    else
                    {
                        Label label = CreateLabel(1054, y, "Not enough players", 200, 20);

                    }
                }
            }
        }

        private void Button6OnClick(object sender, EventArgs eventArgs)
        {
            List<KeyValuePair<string, int>> sorted = (from v in slownik orderby v.Value select v).ToList();
            string[] winners = new string[slownik.Count];
            int[] points = new int[slownik.Count];
            for (int i = 0; i < sorted.Count; i++)
            {
                winners[sorted.Count - 1 - i] = sorted[i].Key;
                points[sorted.Count - 1 - i] = sorted[i].Value;
            }
            int y = 120;
            int pomoc = 1;
            for (int i = 0; i < howManyPlayers / 2; i++)
            {
                if (pomoc == 5)
                {
                    pomoc = 1;
                    y += 30;
                }
                Label label = CreateLabel(800, y, winners[i] + " :  " + points[i] + " pkt", 150, 20);
                WinSlownik.Add(winners[i], points[i]);
                y += 20;
                pomoc++;
            }
        }


        public string[] mixMYTable(string[] tab)
        {
            Random rand = new Random();
            if (howManyPlayers > 2)
            {
                int liczbaPrzesuniec = rand.Next(1, howManyPlayers / 2);
                string chwilowa = "";
                for (int i = 0; i < tab.Length - 1; i += 1)
                {
                    chwilowa = tab[i];
                    tab[i] = tab[liczbaPrzesuniec];
                    tab[liczbaPrzesuniec] = chwilowa;
                    if (liczbaPrzesuniec >= 3)
                    {
                        liczbaPrzesuniec -= 3;
                    }
                }
            }
            return tab;
        }

        private void Button5OnClick(object sender, EventArgs eventArgs)
        {
            Int32 number = 0;
            if (Int32.TryParse(PointsBpx.Text, out number) && slownik.ContainsKey(PlayerNameBox.Text))
            {
                slownik[PlayerNameBox.Text] += Convert.ToInt32(PointsBpx.Text);
            }

        }


        private void Button4OnClick(object sender, EventArgs eventArgs)
        {
            string[] coopyPlayersList = new string[howManyPlayers];
            string name;
            int x = 494;
            int y = 28;
            int zwiekszOdstep = 1;

            for (int i = 0; i < howManyPlayers; i++)
            {
                coopyPlayersList[i] = playersList[i];
            }
            string[] groups = mixMYTable(coopyPlayersList);
            for (int i = 0; i < groups.Length; i++)
            {
                if (zwiekszOdstep == 5)
                {
                    y += 20;
                    zwiekszOdstep = 1;
                }
                name = groups[i];
                Label label = new Label();
                label = CreateLabel(x, y, "", 100, 20);
                label.Text = zwiekszOdstep + ") " + name;
                y += 20;
                zwiekszOdstep++;
            }
        }




        private void Button3OnClick(object sender, EventArgs eventArgs)
        {
            playersList[0] = "piotr";
            playersList[1] = "adam";
            playersList[2] = "kacper";
            playersList[3] = "bartek";
            playersList[4] = "jan";
            playersList[5] = "mateusz";
            playersList[6] = "kuba";
            playersList[7] = "ania";
            playersList[8] = "bozena";
            playersList[9] = "kasia";
            playersList[10] = "wiki";
            playersList[11] = "julia";
            playersList[12] = "karolina";
            playersList[13] = "dawid";
            playersList[14] = "ania2";
            playersList[15] = "ania3";
            playersList[16] = "piotr1";
            playersList[17] = "adam2";
            playersList[18] = "kacper2";
            playersList[19] = "bartek2";
            playersList[20] = "jan2";
            playersList[21] = "mateusz2";
            playersList[22] = "kuba2";
            playersList[23] = "ania22";
            playersList[24] = "bozena2";
            playersList[25] = "kasia2";
            playersList[26] = "wiki12";
            playersList[27] = "julia12";
            playersList[28] = "karolina12";
            playersList[29] = "dawid12";
            playersList[30] = "ania212";
            playersList[31] = "ania312";
            howManyPlayers += 32;
            players = howManyPlayers;
            if (kontrolka == 0)
            {

                for (int i = 0; i < howManyPlayers; i++)
                {
                    if (!slownik.ContainsKey(textBox.Text))
                    {
                        slownik.Add(playersList[i], i * 100);
                        kontrolka = 1;
                    }
                }
            }


        }

        public int x = 158;
        public int y = 800;

        public virtual void Button2OnClick(object sender, EventArgs e)
        {
            int y = 83;
            for (int i = 0; i < howManyPlayers; i++)
            {
                Label label = new Label();
                label = CreateLabel(161, y, "", 100, 20);
                label.Text += i + 1 + " )  " + playersList[i];
                y += 20;
            }
        }

        private void Button1OnClick(object sender, EventArgs eventArgs)
        {
            if (!slownik.ContainsKey(textBox.Text))
            {
                slownik.Add(textBox.Text, 0);
                playersList[players] = textBox.Text;
                players++;
                howManyPlayers++;
            }
        }
    }
}
