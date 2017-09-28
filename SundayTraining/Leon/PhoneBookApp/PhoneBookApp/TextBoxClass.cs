using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public class TextBoxClass : TextBox
    {
        public TextBox ViewTextBox= new TextBox();
        public TextBox NameTextBox = new TextBox();
        public TextBox NumberTextBox = new TextBox();

        public void CreateATextBoxForMainWindow(Form form)
        {
            ViewTextBox.Size = new System.Drawing.Size(300,150);
            ViewTextBox.Multiline = true;
            ViewTextBox.ScrollBars = ScrollBars.Vertical;
            ViewTextBox.Location = new System.Drawing.Point(20,80);
            form.Controls.Add(ViewTextBox);
        }

        public void CreateATextBoxForScndWindow(Form form)
        {
            NameTextBox.Text = "1";
            NameTextBox.Size = new System.Drawing.Size(199, 20);
            NumberTextBox.Size = new System.Drawing.Size(100, 20);

            NameTextBox.Location = new System.Drawing.Point(20, 51);
            NumberTextBox.Location = new System.Drawing.Point(218, 51);

            form.Controls.Add(NameTextBox);
            form.Controls.Add(NumberTextBox);
            // test
            string test = NameTextBox.Text;
        }
    }
}
