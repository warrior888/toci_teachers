using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Downloader.AppToInstall;

namespace Downloader
{
    public partial class Toci : Form
    {
        protected string JoinMeJoinUrl = "";
        protected string MumbleIpAddress = "";

        private readonly Manage _manage = new Manage();
        private string _rootPath = @"C:\";
        private Dictionary<string, IAppToInstall> app = new Dictionary<string, IAppToInstall>();

        public Toci()
        {
            InitializeComponent();
            app.Add("joinMe", new JoinMe());
            app.Add("mumble", new Mumble());
            _manage.ComplateDownload += _wc_DownloadFileCompleted;
            _manage.Progress += _wc_DownloadProgressChanged;
            //Fact.AcceptPath(Directory.GetCurrentDirectory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            folderBrowserDialog1.SelectedPath = _rootPath;
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            _manage.DownloadFile(folderBrowserDialog1.SelectedPath, app["joinMe"]);
        }

        private void instalJoinMeButton_Click(object sender, EventArgs e)
        {
            instalJoinMeButton.Enabled = false;
            try
            {
                _manage.AppInstall(app["joinMe"]);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Nie odnaleziono pliku");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _rootPath;
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            _manage.DownloadFile(folderBrowserDialog1.SelectedPath, app["mumble"]);
        }

        private void _wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            complateLabel.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;

            Console.WriteLine("Ukończono");
        }

        private void _wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                _manage.AppInstall(app["mumble"]);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Nie odnaleziono pliku");
            }
        }
    }
}
