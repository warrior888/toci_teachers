using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            test.AddAButtons(this);
        }
        AddTheButton test = new AddTheButton();

        private void AddButton_Click(object sender, EventArgs e)
        {
            RegisterNewUser rnu = new RegisterNewUser();

            rnu.Show();
        }
    }

}