using System;
using System.Drawing;
using System.Windows.Forms;

namespace masterMINDv2.fieldFactory.classes
{
    public class StartField : AbstractField
    {
        public override Button makeField(Form f1)
        {
            Button buton = new Button();
            Button buton2 = new Button();
            buton.Size = new Size(80, 80);
            buton2.Size = new Size(80, 80);
            buton.BackColor = Color.DeepSkyBlue;
            buton2.BackColor = Color.DeepSkyBlue;
            buton.Click += ButtonOnClick;
            buton2.Click += Buton2OnClick;
            buton.Location = new Point(50, 50);
            buton2.Location = new Point(150, 50);
            buton.Text = "Start mastermind";
            buton2.Text = "Start sudoku";
            f1.Controls.Add(buton);
            f1.Controls.Add(buton2);
            return null;
        }

        private void Buton2OnClick(object sender, EventArgs eventArgs)
        {
            sudoku.Form1 s = new sudoku.Form1();
            s.Show();
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            var a = Helpers.TabOfColors;


        }
    }
}