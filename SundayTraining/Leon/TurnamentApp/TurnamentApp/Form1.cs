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

        TurnamentParticipantShuffle oneLove = new TurnamentParticipantShuffle();
        

        public Form1()
        {
            InitializeComponent();
        }

        // tu dodawac rozne przyciski
        public void AddApElements()
        {
            
        }
    }
}
