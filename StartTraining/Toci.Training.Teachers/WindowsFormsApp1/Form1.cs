using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form


    {
        public string[] participants;
        public int counter = 0;

        public Form1()
        {
            InitializeComponent();
            labelAddParticipant();
            numberOfParticipant();
            
        }

        public void labelAddParticipant()
        {
            Label participantLabel= new Label();
            participantLabel.Text = "Dodaj uczestnika: ";
            participantLabel.Location= new Point(300,20);
            //participantLabel.BackColor = Color.AliceBlue;
            Controls.Add(participantLabel);
        }

        public void numberOfParticipant()
        {
            Label numberparticipant= new Label();
            numberparticipant.Text = "Podaj ilosc uczestnikow: ";
            numberparticipant.Location=new Point(20,20);
            //numberparticipant.BackColor= Color.AliceBlue;
            Controls.Add(numberparticipant);

            TextBox numberOfParticipantTextBox= new TextBox();
            numberOfParticipantTextBox.Location= new Point(150,20);
            Controls.Add(numberOfParticipantTextBox);

            Button participantAdd= new Button();
            participantAdd.Click += ParticipantAdd_Click;
            participantAdd.Location= new Point(20,45);
            participantAdd.Text = "Dodaj";
            Controls.Add(participantAdd);

            participants= new string[Convert.ToInt32(numberOfParticipantTextBox.Text)];




            





        }

        

        private void ParticipantAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
