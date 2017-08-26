using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SudokuTable stbl = new SudokuTable();
        SudokuButtons sbtn = new SudokuButtons();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stbl.CreatSudokuTable();
            sbtn.CreatSudocuButtons(this, stbl.TableOfSudoku);
            sbtn.BackGroundButtons(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stbl.CreatSudokuTable();
            sbtn.RemButtons(this, stbl.TableOfSudoku);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string button = "";
            string table = "";
            bool checking = true;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    button = Convert.ToString(sbtn.ButtonTable[x, y].Text);
                    table = stbl.TableOfSudoku[x, y].ToString();
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
            else { MessageBox.Show("Try harder"); }
        }
    }
}
