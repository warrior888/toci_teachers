using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public int FieldSize;
        public int MinesNumber;
        Button FieldBox = new Button();

        public Form1()
        {
            InitializeComponent();
            AddField();
        }

        public void AddField()
        {
            Label Field = new Label();
            RadioButton RadioButton1 = new RadioButton();
            RadioButton RadioButton2 = new RadioButton();
            RadioButton RadioButton3 = new RadioButton();
            Button StartGame = new Button();

            Field.Text = "Wybierz rozmiar:";
            RadioButton1.Text = "5";
            RadioButton2.Text = "10";
            RadioButton3.Text = "15";
            StartGame.Text = "Rozpocznij";

            Field.Location = new Point(10, 10);
            RadioButton1.Location = new Point(10, 30);
            RadioButton2.Location = new Point(10, 50);
            RadioButton3.Location = new Point(10, 70);
            StartGame.Location = new Point(115, 10);

            Controls.Add(Field);
            Controls.Add(RadioButton1);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton3);
            Controls.Add(StartGame);

            StartGame.Click += StartGame_Click;
            RadioButton1.Click += RadioButton1_click;
            RadioButton2.Click += RadioButton2_click;
            RadioButton3.Click += RadioButton3_click;
        }

        public void BombIngection(int [,] candidate)
        {
            Random mine = new Random();
            int dimX;
            int dimY;
            while (MinesNumber > 0)
            {
                dimX = mine.Next(0, FieldSize);
                dimY = mine.Next(0, FieldSize);
                if (candidate[dimX, dimY] != -1)
                {
                    candidate[dimX, dimY] = -1;
                    MinesNumber--;
                }
            }
        }

        public void BombCounter(int[,] candidate)
        {
            for (int i = 0; i < candidate.GetLength(0); i++)
            {
                for (int j = 0; j < candidate.GetLength(1); j++)
                {
                    if (candidate[i,j] != -1)
                    {
                        if (IsFieldContainBomb(candidate, i - 1, j)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i, j)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i + 1,j)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i - 1, j - 1)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i, j - 1)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i + 1, j - 1)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i - 1, j + 1)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i, j + 1)) candidate[i, j]++;
                        if (IsFieldContainBomb(candidate, i + 1, j + 1)) candidate[i, j]++;
                    }
                }
            }
        }

        public bool IsFieldContainBomb(int[,] candidate, int x, int y)
        {
            bool result = false;
            if (IsFieldExist(x, y))
            {
                if(candidate[x,y] == -1)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool IsFieldExist(int X, int Y)
        {
            bool result = true;
            if (X < 0) result = false;
            if (Y < 0) result = false;
            if (X >= FieldSize) result = false;
            if (Y >= FieldSize) result = false;

            return result;
        }

        private void RadioButton3_click(object sender, EventArgs e)
        {
            FieldSize = 15;
            MinesNumber = 15;
            /*Random mine = new Random();
            int[,] SupperField = new int[15, 15];
            for(int i = 0; i < SupperField.GetLength(0); i++)
            {
                for(int j = 0; j < SupperField.GetLength(1); j++)
                { 
                    TextBox FieldBox = new TextBox();
                    FieldBox.SetBounds(10 + (20 * i), 100 + (20 * j), 20, 10);
                    FieldBox.Text = Convert.ToString(mine.Next(-1, 1));
                    Controls.Add(FieldBox);
                }
            }*/
        }

        private void RadioButton2_click(object sender, EventArgs e)
        {
            FieldSize = 10;
            MinesNumber = 10;
        }

        private void RadioButton1_click(object sender, EventArgs e)
        {
            FieldSize = 5;
            MinesNumber = 5;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            int[,] SupperField = new int[FieldSize, FieldSize];
            string[] number = new string[FieldSize * FieldSize];
            
            BombIngection(SupperField);
            BombCounter(SupperField);

            for (int i = 0; i < SupperField.GetLength(0); i++)
            {
                for (int j = 0; j < SupperField.GetLength(1); j++)
                {
                    FieldBox = new Button();
                    FieldBox.SetBounds(10 + (20 * i), 100 + (20 * j), 20, 20);
                    FieldBox.BackColor = Color.Black;
                    if (SupperField[i, j] != 0)
                    {
                        FieldBox.Text = Convert.ToString(SupperField[i, j]);
                    }
                    Controls.Add(FieldBox);
                    FieldBox.Click += Form1_Click;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
                ((Button)sender).BackColor = Color.White;
            if(((Button)sender).Text == "-1")
            {
                ((Button)sender).BackColor = Color.Red;
                MessageBox.Show("You die!");
                Application.Exit();
            }
        }
    }
}
