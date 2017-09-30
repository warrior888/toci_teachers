using System;
using System.Drawing;
using System.Windows.Forms;

namespace masterMINDv2.fieldFactory.classes
{
    public class FieldToClick : AbstractField
    {
        public override Button makeField(Form f1)
        {
            for (int j = 0; j < 4; j++)
            {
                Button buton = new Button();
                buton.Size = new Size(size, size);
                buton.BackColor = Color.Beige;
                buton.Click += ButtonOnClick;
                buton.Location = new Point(posX, posY);
                posX += size + 10;
                f1.Controls.Add(buton);
            }

            var tab = new PromoptButtons();
            tab.posy = posY-size-5;
            tab.promoTab();
            posY += size + 10;
            return null;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = sender as Button;
            button.changeColor();
        }
    }
}