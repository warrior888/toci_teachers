using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SudokuButtons
    {
        public Button[,] ButtonTable = new Button[9, 9];
        int toIncrease;
        public Button[,] CreatSudocuButtons(Form1 form1, int[,] candidate)
        {
            Random switcher = new Random();
            int ToSwitch;
            ButtonTable = new Button[9, 9];

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    ButtonTable[x, y] = new Button();
                    ToSwitch = switcher.Next(0,2);
                    if (ToSwitch != 0)
                    {
                        ButtonTable[x, y].Text = candidate[x, y].ToString();
                    }
                    ButtonTable[x, y].SetBounds(28, 28, 28, 28);
                    ButtonTable[x, y].Location = new Point((38 * x)+26, (38 * y)+60);
                    //ButtonTable[x, y].BringToFront();
                    form1.Controls.Add(ButtonTable[x, y]);
                    ButtonTable[x, y].Click += SudokuButtons_Click;
                }
            }
            return ButtonTable;
        }

        private void SudokuButtons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                toIncrease = 1;
                ((Button)sender).Text = toIncrease.ToString();
            }
            else if(((Button)sender).Text != "")
            {
                string temporary = ((Button)sender).Text;
                toIncrease = Convert.ToInt32(temporary);
                toIncrease++;
                if (toIncrease > 9) { toIncrease = 1; }
                ((Button)sender).Text = toIncrease.ToString();
            }
        }

        public void BackGroundButtons(Form1 form)
        {
            Button BackGroundButton = new Button();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BackGroundButton = new Button();
                    BackGroundButton.SetBounds(50, 50, 119, 119);
                    BackGroundButton.Location = new Point((113 * i) + 19, (113 * j) + 53);
                    BackGroundButton.BackColor = Color.LightSteelBlue;
                    form.Controls.Add(BackGroundButton);
                }
            }
        }
        public void RemButtons(Form1 form, int[,] candidate)
        {
            //Random switcher = new Random();
            //int ToSwitch;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    //ToSwitch = switcher.Next(0, 2);
                    //if (ToSwitch != 0)
                    //{
                        ButtonTable[x, y].Text = candidate[x, y].ToString();
                    //}
                }
            }
        }
    }
}
