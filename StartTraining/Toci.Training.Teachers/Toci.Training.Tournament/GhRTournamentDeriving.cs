using System;
using System.Windows.Forms;

namespace Toci.Training.Tournament
{
    public class GhRTournamentDeriving : Form1
    {


        protected override void ParticipantAdd_Click(object sender, EventArgs e)
        {
            base.ParticipantAdd_Click(sender, e);

            Label lb = new Label();

            lb.Text = Participants[0];
        }
    }
}