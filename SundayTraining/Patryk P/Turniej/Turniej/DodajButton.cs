using System;
using System.Windows.Forms;

namespace Turniej
{
    public class DodajButton_Click1 : Form1
    {
        protected override void DodajButton_Click(object sender, EventArgs e)
        {
            base.DodajButton_Click(sender, e);

            Label napiszLabel = new Label();

            for (int i = 0; i < limit; i++)
            {
                napiszLabel.Text = uczestnicy[i];
            }
        }

        internal void DodajButton_Click()
        {
            throw new NotImplementedException();
        }
    }
}