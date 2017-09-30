using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using masterMINDv2.fieldFactory;
using masterMINDv2.fieldFactory.classes;

namespace masterMINDv2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Helpers.form2 = this;
            new FieldToClick().makeField(this);
            new CheckButton().makeField(this);
            Helpers.TabOfColors = Helpers.shuffle();
    }
    }
}
