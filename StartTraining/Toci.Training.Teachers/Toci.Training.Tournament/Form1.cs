using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toci.Training.Tournament
{
    public partial class Form1 : Form
    {
        public string[] Participants = new string[10];

        //public List<string> participants = new List<string>();

        public int counter = 0;
        TextBox participantNameTextBox = new TextBox();

        public Form1()
        {
            InitializeComponent();

            //GhRTournamentDeriving ghr = new GhRTournamentDeriving();

            //ghr.Show();
            //for (int i = 0; i < 10; i++)
            {
                AddNewParticipantForm(20);
            }
        }

        public void AddParticipant()
        {
            //Participants[]
        }

        public void AddNewParticipantForm(int y)
        {
            Label participantLabel = new Label();

            participantLabel.Text = "Dodaj uczestnika: ";

            //participantLabel.BackColor = Color.Red;

            participantLabel.Location = new Point(20, y);

            Controls.Add(participantLabel);

            participantNameTextBox.Location = new Point(150, y);

            Button participantAdd = new Button();

            participantAdd.Click += ParticipantAdd_Click;
            //participantAdd.Click +=
            participantAdd.Location = new Point(400, y);
            participantAdd.Text = "Dodaj";

            Controls.Add(participantAdd);
            Controls.Add(participantNameTextBox);

            //TextBox
            //Button
        }

        protected virtual void ParticipantAdd_Click(object sender, EventArgs e)
        {
            Participants[counter] = participantNameTextBox.Text;
            counter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
private void Form1_Load(object sender, EventArgs e)
{

}
*/
    }
}
