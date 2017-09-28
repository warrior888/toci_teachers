using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public class ButtonsClickEventLogic : ButtonsClass
    {
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Yellow;
        }

    }
}
