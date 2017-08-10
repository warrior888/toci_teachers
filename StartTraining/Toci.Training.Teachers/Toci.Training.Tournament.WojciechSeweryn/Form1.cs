using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toci.Training.Tournament.WojciechSeweryn
{
    public partial class Form1 : Form
    {
        #region KOD ZE SZKOLENIA
        /*
        public string[] Participants = new string[10];
        public int counter = 0;
        TextBox participantNameTextBox = new TextBox();

        //KONSTRUKTOR
        public Form1()
        {
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            {
                AddNewParticipantForm(30);
            }
            
        }

        //DODANIE UCZESTNIKA
        public void AddParticipants()
        {
            //Participants[]
        }

        //NOWY UCZESTNIK 
        public void AddNewParticipantForm(int y)
        {
            Label participantLabel = new Label();

            participantLabel.Text = "Dodaj uczestnika: ";
            //participantLabel.BackColor = Color.Black;
            //participantLabel.ForeColor = Color.White;
            //participantLabel.TextAlign = 
            participantLabel.Location = new Point(20, y);
            
            participantLabel.Font = new Font("Arial", 9);
            Controls.Add(participantLabel);

            
            participantNameTextBox.Location = new Point(230, 30);
            Controls.Add(participantNameTextBox);

            Button particpantAdd = new Button();
            particpantAdd.Location = new Point(340, 30);
            particpantAdd.Click += ParticpantAdd_Click;
            particpantAdd.Text = "Dodaj";
            Controls.Add(particpantAdd);
            

        }

        private void ParticpantAdd_Click(object sender, EventArgs e)
        {
            Participants[counter] = participantNameTextBox.Text;
            counter++;
            Label lb = new Label();
            lb.Text = Participants[0];
            MessageBox.Show("New user added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        */
        #endregion

        public string[] Participants = new string[6];
        public int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void participantAdd_Click(object sender, EventArgs e)
        {
            Participants[counter] = participantNameTextBox.Text;
            Label participantLabel = new Label()
            {
                Text = Participants[counter],
                Location = new Point(30, 30 + counter * 20),
                Font = new Font("Arial", 10)
            };
            counter++;
            Controls.Add(participantLabel);
        }

        public void drawGroups(string[] participantCandidate)
        {
            int groupQuantity = 2;
            string [,] newGroups = new string[groupQuantity, participantCandidate.Length/groupQuantity];

            for (int i = 0; i < participantCandidate.Length; i++)
            {
                participantCandidate[i] = 
            }
            
        }

    }
} 
