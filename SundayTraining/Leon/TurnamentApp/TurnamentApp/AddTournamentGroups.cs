using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnamentApp
{
    class AddTournamentGroups : AbstractTournament_Visualization
    {
        Form test = new Form();
        public override void GroupVisualization(string [][] candidate)
        {
            Label Group = new Label();
            Label GroupParticipant = new Label();
            string[][] GroupTable = candidate;
            for (int i = 0; i < GroupTable.Length; i++)
            {
                Group.Text = "Grupa " + i;
                Group.Location = new Point(300, 21 * i);
                test.Controls.Add(Group);
                for (int j = 0; j < GroupTable[i].Length; j++)
                {
                    GroupParticipant.Text = candidate[i][j];
                    Group.Location = new Point(350, 21 * i);
                    test.Controls.Add(Group); // to nie dziala???
                }
            }       
        }
    }
}
