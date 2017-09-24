using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public class ButtonsClass : Button
    {
        public Button btnAdd = new Button();
        LableClass lc = new LableClass();
        Form f = new Form();
        PhoneBookDictionary pbd = new PhoneBookDictionary();
        TextBoxClass tbc = new TextBoxClass();

        //public EventHandler btnAdd_Click; //<- to nie jest potrzebne jak na razie

        public void AddButtons(Form form, string name)
        {
            btnAdd.Text = name;
            btnAdd.Location = new Point(20, 20);
            form.Controls.Add(btnAdd);

            // nie dziala
            // this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click );

            btnAdd.Click += BtnAdd_Click;
        }
        public void AddButtons(Form form, string name, int posX, int posY)
        {
            btnAdd.Text = name;
            btnAdd.Location = new Point(posX, posY);
            form.Controls.Add(btnAdd);
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add person")
            {
                // Show(AddPersonForm); <- nie dziala
                // tak dziala. Trzeba bylo stworzyc nowa instancje objektu
                AddPersonForm apf = new AddPersonForm(); // <- instancja objektu
                apf.Show(); // <- wywolanie
            }
            else if(btnAdd.Text == "Save")
            {
                string key = tbc.NameTextBox.Text;
                //tbc.NameTextBox.BringToFront(); // <-nic nie daje
                tbc.NameTextBox.Text += " test"; 
                //pbd.PhoneDict.Add(tbc.NameTextBox.Text.ToString(), tbc.NumberTextBox.Text);
            }
        }

    }

    // proba napisania extension method
    /*public static class ClickEv
    {
        public static void btnClickEV(this ButtonsClass test)
        {
            test.btnAdd.Click += new System.EventHandler(btnAdd_Click);
        }
    }*/
}
