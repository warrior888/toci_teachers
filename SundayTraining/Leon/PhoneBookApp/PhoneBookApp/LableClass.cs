using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public class LableClass : Label
    {
        public void AddLablesForMainWindow(Form form)
        {
            Label nameInfo = new Label();
            Label numberInfo = new Label();

            nameInfo.Text = "Imie i Nazwisko";
            numberInfo.Text = "Numer";

            nameInfo.BorderStyle = BorderStyle.FixedSingle;
            numberInfo.BorderStyle = BorderStyle.FixedSingle;

            nameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            numberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            nameInfo.Size = new System.Drawing.Size(199,20);
            numberInfo.Size = new System.Drawing.Size(100,20);

            nameInfo.Location = new System.Drawing.Point(20,55);
            numberInfo.Location = new System.Drawing.Point(218,55);

            form.Controls.Add(nameInfo);
            form.Controls.Add(numberInfo);
        }

        public void AddLablesForScndWindow(Form form)
        {
            Label name = new Label();
            Label number = new Label();

            name.Text = "Imie i nazwisko";
            number.Text = "Numer";

            name.BorderStyle = BorderStyle.FixedSingle;
            number.BorderStyle = BorderStyle.FixedSingle;

            name.Size = new System.Drawing.Size(199, 20);
            number.Size = new System.Drawing.Size(100, 20);

            name.Location = new System.Drawing.Point(20, 30);
            number.Location = new System.Drawing.Point(218, 30);

            form.Controls.Add(name);
            form.Controls.Add(number);
        }
    }
}
