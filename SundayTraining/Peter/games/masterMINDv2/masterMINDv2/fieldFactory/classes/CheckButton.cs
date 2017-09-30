using System;
using System.Drawing;
using System.Windows.Forms;

namespace masterMINDv2.fieldFactory.classes
{
    public class CheckButton : AbstractField
    {
        public override Button makeField(Form f1)
        {
            Button buton = new Button();
            buton.Size = new Size(80, 80);
            buton.BackColor = Color.DeepSkyBlue;
            buton.Click += ButtonOnClick;
            buton.Location = new Point(300, 30);
            buton.Text = "Check";
            f1.Controls.Add(buton);
            return null;
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            switch (Helpers.validationFields())
            {
                case 1:
                {
                    MessageBox.Show("wygrałeś");
                        break;
                }
                case 2:        //nie wszystie kropki się zgadzają
                {
                    new FieldToClick().makeField(Helpers.form2);
                    Helpers.fieldsList.Clear();
                        break;
                }
                case 3:
                {
                    MessageBox.Show("nie uzupełniłeś wszystkich pól");
                    break;
                }

            }
            for (int i = 0; i < 4; i++)
            {
                PromoptButtons.color[i] = Color.Black;
            }

        }
    }
}