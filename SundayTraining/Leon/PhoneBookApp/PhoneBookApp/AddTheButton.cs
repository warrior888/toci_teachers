using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public class AddTheButton : AllButtonsAbstractClass
    {
        public override void AddAButtons(Form1 form)
        {
            Button AddButon = new Button();
            Button FindButton = new Button();
            Button ShowList = new Button();

            AddButon.Location = new System.Drawing.Point(10,10);
            FindButton.Location = new System.Drawing.Point(10,30);
            ShowList.Location = new System.Drawing.Point(10,50);

            AddButon.Text = "Add Person";
            FindButton.Text = "Find Person";
            ShowList.Text = "Show the list";

            form.Controls.Add(AddButon);
            form.Controls.Add(FindButton);
            form.Controls.Add(ShowList);
        }
    }
}
