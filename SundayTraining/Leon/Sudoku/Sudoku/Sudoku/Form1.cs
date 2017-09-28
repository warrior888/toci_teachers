using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public int[,] SudokuTable = new int[9,9];
        Random Switcher = new Random();
        Button[,] someButtone = new Button[9,9];
        int switcherNumber;

        public Form1()
        {
            InitializeComponent();

            SudokuTableInherit variable = new SudokuTableInherit();
            variable.FillingTableWithNumbers(SudokuTable);

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    AddFields(x, y, SudokuTable[x,y]);
                }
            }
            //AddButton();
        }

        public void AddFields(int x, int y, int name)
        {
            int increment = 1;
            TextBox SudokuField = new TextBox();
            switcherNumber = Switcher.Next(0,2);
            //if (switcherNumber != 0)
            //{
                SudokuField.Text = Convert.ToString(name);
            //}
            SudokuField.SetBounds(20,20,20,20);
            //SudokuField.BorderStyle = Color.Red;
            SudokuField.Location = new Point(20*(1+x),20*(1+y));
            Controls.Add(SudokuField);
            increment++;
        }

        /*public void AddButton()
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    someButtone[x,y] = new Button();
                    someButtone[x, y].Text = SudokuTable[x, y].ToString();
                    someButtone[x, y].SetBounds(20, 20, 20, 20);
                    someButtone[x, y].Location = new Point(250+(20*x), 20*y);
                    Controls.Add(someButtone[x, y]);
                    someButtone[x, y].Click += SomeButtone_Click;
                }
            }
        }*/

        /*private void SomeButtone_Click(object sender, EventArgs e)
        {
            string button = "";
            string table = "";
            bool checking = true;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    button = Convert.ToString(someButtone[x, y].Text);
                    table = SudokuTable[x, y].ToString();
                    if (button != table)
                    {
                        checking = false;
                    }
                }
            }

            if (checking)
            {
                MessageBox.Show("Correct");
            }
        }*/
    }
}
