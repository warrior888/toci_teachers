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
        ButtonsClass bc = new ButtonsClass();
        LableClass lc = new LableClass();
        TextBoxClass tbc = new TextBoxClass();

        public Form1()
        {
            InitializeComponent();
            bc.AddButtons(this, "Add person");
            lc.AddLablesForMainWindow(this);
            tbc.CreateATextBoxForMainWindow(this);
        }
    }
}
