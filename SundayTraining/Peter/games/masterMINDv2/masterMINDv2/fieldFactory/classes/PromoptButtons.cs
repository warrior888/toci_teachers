using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace masterMINDv2.fieldFactory.classes
{
    public class PromoptButtons : AbstractField
    {
        public static List<Color> color = new List<Color>(){Color.Beige, Color.Beige, Color.Beige, Color.Beige };

        public int posy;
        public override Button makeField(Form f1)
        {
            Button buton = new Button();
            buton.Size = new Size(20, 20);
            buton.BackColor = color[0];
            buton.Location = new Point(250, posy);
            f1.Controls.Add(buton);
            return null;
        }
        public Button makeField2(Form f1)
        {
            Button buton = new Button();
            buton.Size = new Size(20, 20);
            buton.BackColor = color[1];
            buton.Location = new Point(250+20, posy);
            f1.Controls.Add(buton);
            return null;
        }
        public Button makeField3(Form f1)
        {
            Button buton = new Button();
            buton.Size = new Size(20, 20);
            buton.BackColor = color[2];
            buton.Location = new Point(250, posy + 20);
            f1.Controls.Add(buton);
            return null;
        }
        public Button makeField4(Form f1)
        {
            Button buton = new Button();
            buton.Size = new Size(20, 20);
            buton.BackColor = color[3];
            buton.Location = new Point(250+20, posy+20);
            f1.Controls.Add(buton);
            return null;
        }

        public Button[] promoTab()
        {
            Helpers.getPrompt();

            return new Button[]{makeField(Helpers.form2),makeField2(Helpers.form2),makeField3(Helpers.form2),makeField4(Helpers.form2)};
        }
    }
}