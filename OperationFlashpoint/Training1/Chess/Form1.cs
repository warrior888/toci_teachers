using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //GhostRiderForm f = new GhostRiderForm();

            //f.Show();

            List<Type> lst = Assembly.GetCallingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(GhostRiderForm))).Select(m => m).ToList();

            foreach (var item in lst)
            {
                GhostRiderForm gf = (GhostRiderForm) Activator.CreateInstance(item);

                gf.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChessboardByLeon cbl = new ChessboardByLeon();
            cbl.Show();
        }

        // szachownica
    }
}
