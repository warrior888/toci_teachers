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
        public int ParticipantCount = 0;
        TextBox ParticipantName = new TextBox();

        TurnamentParticipantShuffle participantShuffle = new TurnamentParticipantShuffle();
       

        public Form1()
        {
            InitializeComponent();
            AddApElements(ParticipantCount + 1);
            //ParticipantTable = participantShuffle.Shuffle(ParticipantTable);
            //Groups = participantShuffle.ToSplitGroups(ParticipantTable);
        }

        // tu dodawac rozne przyciski
        public void AddApElements(int dimY)
        {
            Label AddParticipant = new Label();
            Label ParticipantNO = new Label();
            
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

            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ParticipantCount <= 19)
            {
                AddApElements(ParticipantCount);
                ParticipantTable[ParticipantCount] = Convert.ToString(ParticipantName);
                ParticipantCount++;
            }
            if(ParticipantCount >= 20)
            {
                Label Finish = new Label();
                Finish.Text = "Turniej jest pelny!";
                Finish.Location = new Point(30, 21 * ParticipantCount);
                Controls.Add(Finish);
            }
        }
    }
}
