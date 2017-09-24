using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OakieDokie.dab;

namespace OakieDokie
{
    public partial class Toci : Form
    {
        protected string JoinMeJoinUrl = "";
        protected string MumbleIpAddress = "";

        protected Factory Fact = new Factory();

        public Toci()
        {
            InitializeComponent();
            Fact.AcceptPath(Directory.GetCurrentDirectory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fact.GetElements()[whatToInstalEnum.JoinMe]();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fact.GetElements()[whatToInstalEnum.Mumble]();
        }
    }
}
