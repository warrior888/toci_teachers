using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turniej
{
    public partial class Form1 : Form
    {
        
        public string[] uczestnicy = new string[20];
        public int limit = 0;
        TextBox dodajuczestnikaTextBox = new TextBox();

        public Form1()
        
        {
            
            InitializeComponent();
            dodajUczestnikaFunkcja(20, 20);
            //DodajButton_Click1.
            //DodajButton klasaB = new DodajButton();
            //klasaB.DodajButton_Click();
        }

        public void DodajUczestinka() 
        {
            //uczestnicy[i]
        }

        public void dodajUczestnikaFunkcja(int x, int y)
        {
            Label dodajLabel = new Label();
            dodajLabel.Text = "Dodaj uczestnika";
            dodajLabel.Location = new Point(x, 20);
            Controls.Add(dodajLabel);

            dodajuczestnikaTextBox.Location = new Point(x +130, y);
            
            Button dodajButton= new Button();
            dodajButton.Location = new Point(x +280 ,y);
            dodajButton.Click += DodajButton_Click;
            dodajButton.Text = "Dodaj uczestnika";
            Controls.Add(dodajButton);
            Controls.Add(dodajuczestnikaTextBox);
            //Controls.ADodajButton_Click1


            //Label uczestnikLabel = new Label();
            //uczestnikLabel.Text = uczestnicy[dodajuczestnikaTextBox];
            //uczestnikLabel.Location = new Point(x, y + 50);
            //Controls.Add(uczestnikLabel);

        }

        //public void petla()
        //{
        //    for (int i = 0; i < limit; i++)
        //    {
                
        //    }
        //}


        protected virtual void DodajButton_Click(object sender, EventArgs e)
        {
            uczestnicy[limit] = dodajuczestnikaTextBox.Text;
            limit++;
            Label napiszLabel = new Label();

            for (int i = 0; i < limit; i++)
            {
                napiszLabel.Text = uczestnicy[i];
            }



        }
    }

   
}
