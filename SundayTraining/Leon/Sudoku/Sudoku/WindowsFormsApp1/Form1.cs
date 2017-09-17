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

        private void StartButton_Click(object sender, EventArgs e)
        {
            stbl.CreatSudokuTable();
            sbtn.CreatSudocuButtons(this, stbl.TableOfSudoku);
            sbtn.BackGroundButtons(this);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            stbl.CreatSudokuTable();
            sbtn.RemButtons(this, stbl.TableOfSudoku);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            bool checking = true;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (Convert.ToString(sbtn.ButtonTable[x, y].Text) != stbl.TableOfSudoku[x, y].ToString())
                    {
                        sbtn.ButtonTable[x, y].BackColor = Color.Red;
                        checking = false;
                    }
                }
            }

            if (checking)
            {
                MessageBox.Show("Correct");
            }
            else { MessageBox.Show("Try harder"); }
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    sbtn.ButtonTable[x, y].BackColor = Color.WhiteSmoke;
                }
            }
        }
    }
}
