using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnamentApp
{
    public partial class Form1 : Form
    {
        public string[] ParticipantTable = new string[20];
        public string[][] Groups = new string[4][];
        public int[] GroupScoreTable = new int[4];
        public int[] FightNum = new int[4];
        public int counter;
        public int ParticipantCount = 0;
        public int TextBoxCount = 1;
        public int ForI = 0;
        TextBox ParticipantName = new TextBox();
        Button Check = new Button();
        Button CheckFor2ndRound = new Button();
        TextBox GroupScore = new TextBox();

        TurnamentParticipantShuffle participantShuffle = new TurnamentParticipantShuffle();
        AddTournamentGroups ShowingGroups = new AddTournamentGroups();


        public Form1()
        {
            InitializeComponent();
            AddParticipantElements();
        }

        public void AddParticipantElements()
        {
            Label AddParticipant = new Label();
            Label ParticipantNO = new Label();
            ParticipantName = new TextBox();
            Button AddButton = new Button();

            AddParticipant.Text = "Dodaj uzytkownika:";
            ParticipantNO.Text = Convert.ToString(ParticipantCount+1);
            AddButton.Text = "Dodaj";

            AddParticipant.Location = new Point(30, 21 * ParticipantCount);
            ParticipantNO.Location = new Point(10, 21 * ParticipantCount);
            ParticipantName.Location = new Point(130, 21 * ParticipantCount);
            AddButton.Location = new Point(240, 21 * ParticipantCount);

            Controls.Add(AddParticipant);
            Controls.Add(ParticipantNO);
            Controls.Add(ParticipantName);
            Controls.Add(AddButton);

            // zamiana z ParticipantName na ParticipantCount
            ParticipantTable[ParticipantCount] = Convert.ToString(ParticipantCount);
            if (ParticipantCount == 0)
            {
                ParticipantCount++;
            }

            if (ParticipantTable[19] != null)
            {
                Label Tournament = new Label();
                Tournament.Text = "Round 1";
                Tournament.Location = new Point(450,21);
                Controls.Add(Tournament);
                Turnament1stStage();
            }
            AddButton.Click += AddButton_Click;
        }

        public void ShowGroups(int dimX, int startFromGroup, int endWithGroup, int counter)
        {
            for(int i = startFromGroup; i < endWithGroup; i++)
            {
                Label GroupNo = new Label();
                GroupNo.Text = "Grupa " + (i +1);
                GroupNo.Location = new Point(350 * dimX, 21 * counter);
                Controls.Add(GroupNo);
                counter++;
                for (int j = 0; j < Groups[i].Length; j++)
                {
                    Label GroupPartisipant = new Label();
 
                    GroupPartisipant.Text = Groups[i][j];
                    GroupPartisipant.SetBounds(20,20,20,20);

                    GroupPartisipant.Location = new Point(350 * dimX, 21 * counter);

                    Controls.Add(GroupPartisipant);
                    counter++;
                }
            }
        }

        public void Turnament1stStage()
        {
            counter = 2;
            FightNum = participantShuffle.ShuffleGroups();
            for (int i = 0; i < 4; i++)
            {
                Label GroupNo = new Label();

                GroupNo.Text = "Grupa " + FightNum[i];

                GroupNo.SetBounds(20, 20, 50, 20);
                GroupNo.Location = new Point(450, 21 * counter);

                Controls.Add(GroupNo);
                counter++;

                if (i == 0 || i == 2)
                {
                    Label versus = new Label();
                    versus.Text = "VS";
                    versus.SetBounds(20, 20, 30, 20);
                    versus.Location = new Point(450, 21 * counter);
                    Controls.Add(versus);
                    counter++;
                }
                if(i == 1) { counter++; }
            }
            counter = 2;

            Check.Text = "Zatwierdz";

            Check.SetBounds(20, 20, 80, 20);
            Check.Location = new Point(530, 21 * counter);
            GroupScore.SetBounds(20, 20, 30, 20);
            GroupScore.Location = new Point(500, 21 * counter);

            Controls.Add(Check);
            Controls.Add(GroupScore);
            Check.Click += Check_Click;
        }

        public void Turnament2stStage()
        {
            counter = 2;
            WinerCheck Checking = new WinerCheck(); // nie moge wyniesc to do pozostalych klas --> pokazuje owerflow.exeption
            FightNum = Checking.FirstRoundWinerChecking(FightNum, GroupScoreTable);

            for (int i = 0; i < 4; i++)
            {
                Label GroupNo = new Label();

                GroupNo.Text = "Grupa " + FightNum[i];

                GroupNo.SetBounds(20, 20, 50, 20);
                GroupNo.Location = new Point(650, 21 * counter);

                Controls.Add(GroupNo);
                counter++;
                if (i == 0 || i == 2)
                {
                    Label versus = new Label();
                    versus.Text = "VS";
                    versus.SetBounds(20, 20, 30, 20);
                    versus.Location = new Point(650, 21 * counter);
                    Controls.Add(versus);
                    counter++;
                }
                if (i == 1) { counter++; }
            }
            for (int i = 0; i < 4; i++)
            {
                GroupScoreTable[i] = 0;
            }
            counter = 2;
            ForI = 0; 

            CheckFor2ndRound.Text = "Zatwierdz";

            CheckFor2ndRound.SetBounds(20, 20, 80, 20);
            CheckFor2ndRound.Location = new Point(800, 21 * counter);
            GroupScore.SetBounds(20, 20, 30, 20);
            GroupScore.Location = new Point(720, 21 * counter);

            Controls.Add(CheckFor2ndRound);
            Controls.Add(GroupScore);
            CheckFor2ndRound.Click += CheckFor2ndRound_Click;
        }

        public void FinalResult()
        {
            WinerCheck Checking = new WinerCheck(); // nie moge wyniesc to do pozostalych klas --> pokazuje owerflow.exeption
            FightNum = Checking.WinerChecking(FightNum, GroupScoreTable);
            for(int i = 0; i < 4; i++)
            {
                Label FinalPlace = new Label();
                FinalPlace.Text = (i + 1) + " place: ";
                FinalPlace.SetBounds(20, 20, 50, 20);
                FinalPlace.Location = new Point(870, 21 * (i + 2));
                Controls.Add(FinalPlace);
                //ShowGroups(3, FightNum[i]-1, FightNum[i], i+2); // nie dopracowane
                Label GroupNo = new Label();
                GroupNo.Text = "Grupa " + FightNum[i];
                GroupNo.SetBounds(20, 20, 50, 20);
                GroupNo.Location = new Point(940, 21 * (i + 2));
                Controls.Add(GroupNo);
            }

        }

        private void CheckFor2ndRound_Click(object sender, EventArgs e)
        {
            if (ForI < 4)
            {
                GroupScoreTable[ForI] = int.Parse(GroupScore.Text);
                if (counter < 8) counter++;
                if (counter == 3 || counter == 5 || counter == 7) { counter++; }
                CheckFor2ndRound.Location = new Point(760, 21 * counter);
                GroupScore.Location = new Point(720, 21 * counter);
                ForI++;
            }
            if (GroupScoreTable[3] != 0)
            {
                Label TheFinal = new Label();
                TheFinal.Text = "And the winner is...";
                TheFinal.Location = new Point(870, 21);
                Controls.Add(TheFinal);
                FinalResult();
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {   if (ForI < 4)
            {
                GroupScoreTable[ForI] = int.Parse(GroupScore.Text);
                if (counter <8) counter++;
                if (counter == 3 || counter == 5 || counter == 7) { counter++; }
                Check.Location = new Point(550, 21 * counter);
                GroupScore.Location = new Point(500, 21 * counter);
                ForI++;
            }
            if (GroupScoreTable[3] != 0)
            {
                Label Tournament = new Label();
                Tournament.Text = "Round 2";
                Tournament.Location = new Point(650, 21);
                Controls.Add(Tournament);
                Turnament2stStage();
                Controls.Remove(Check);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TextBoxCount < 20)
            {
                AddParticipantElements();
                // zamiana z ParticipantName na ParticipantCount
                ParticipantTable[ParticipantCount] = Convert.ToString(ParticipantCount);
                ParticipantCount++;
            }
            if(TextBoxCount > 20)
            {
                Label Finish = new Label();
                Finish.Text = "Turniej jest pelny!";
                Finish.Location = new Point(30, 21 * ParticipantCount);
                Controls.Add(Finish);
            }
            if (ParticipantTable[19] != null)
            {
                ParticipantTable = participantShuffle.Shuffle(ParticipantTable);
                Groups = participantShuffle.ToSplitGroups(ParticipantTable);
                //ShowingGroups.GroupVisualization(Groups);// to nie dziala. Musialem uzyc ShowGroups();
                ShowGroups(1,0,4,1);
            }
            TextBoxCount++;
        }
    }
}
