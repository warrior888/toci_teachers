using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using CefSharp;
using TociApp.Interface;
using TociApp.Managed;
using TociApp.ViewModels;
using Button = System.Windows.Controls.Button;
using MessageBox = System.Windows.MessageBox;
using ProgressBar = System.Windows.Controls.ProgressBar;

namespace TociApp.Views
{
    /// <summary>
    /// Interaction logic for TociApp.xaml
    /// </summary>
    public partial class TociApp : Window
    {
        private readonly Manage _manage;
        private const string RootPath = @"C:\";
        private const string TociBeginer = @"";     // TODO: Uzupełnic adresy www do dropboxa
        private const string Tociintermediate = @"";
        private bool _downloadComplete;


        public TociApp()
        {
            InitializeComponent();
            _manage = new Manage();
        }

        private void DownloadFile(AppToInstall appName,
            System.ComponentModel.AsyncCompletedEventHandler completedDownload, DownloadProgressChangedEventHandler progress, ProgressBar progressBar)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() { SelectedPath = RootPath, ShowNewFolderButton = true })
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK) return;

                progressBar.Visibility = Visibility.Visible;
                _manage.DownloadFile(folderBrowserDialog.SelectedPath, _manage.App[appName], completedDownload, progress);
            }
        }

        private void InstallApp(IAppToInstall app, Button btn)
        {
            try
            {
                if (_manage.AppInstall(app))
                {
                    btn.IsEnabled = false;
                    RunJoinMeApp.IsEnabled = true;
                }
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
            }
        }

        // TODO: Dodać plik pzrechwujący stan aplikacji (jeżeli plik został pobrany, ale nie zainstalowany, to aplkacja powinna pamietać jego lokalizację)
        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) return;

            bool isInstalled;
            if (button.Name == InstallJoinMeButton.Name)
            {
                isInstalled = _manage.AppIsIntaled(_manage.App[AppToInstall.JoinMe]);
                if (!isInstalled)
                {
                    if (!_downloadComplete)
                    {
                        DownloadFile(AppToInstall.JoinMe, _wc_DownloadFileCompleted, _wc_JoinMeDownloadProgressChange, JoinMeDownloadProgresBar);
                    }
                    else
                    {
                        button.Content = @"Instaluj";
                        button.Click -= DownloadButton_Click;
                        button.Click += InstalButton_Click;
                    }

                }
                else
                {
                    InstallJoinMeButton.IsEnabled = false;
                    RunJoinMeApp.IsEnabled = true;
                }
            }
            else if (button.Name == InstallMumbleButton.Name)
            {
                isInstalled = _manage.AppIsIntaled(_manage.App[AppToInstall.Mumble]);
                if (!isInstalled)
                {
                    if (!_downloadComplete)
                    {
                        DownloadFile(AppToInstall.Mumble, _wc_DownloadFileCompleted, _wc_MumbleDownloadProgressChanged, MumbleInstallProgresBar);
                    }
                    else
                    {
                        button.Content = @"Instaluj";
                        button.Click -= DownloadButton_Click;
                        button.Click += InstalButton_Click;
                    }
                }
                else
                {
                    InstallMumbleButton.IsEnabled = false;
                    RunMumbleApp.IsEnabled = true;
                }
            }
        }

        private void _wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (!(sender is IAppToInstall app)) return;
            switch (app.AppName)
            {
                case "join.me":
                    JoinMeDownloadCompleted.Visibility = Visibility.Visible;
                    break;
                case "mumble":
                    MumbleDownloadCompleted.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
#if DEBUG
            Console.WriteLine(@"Download finish");
#endif
        }

        private void _wc_MumbleDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            MumbleInstallProgresBar.Value = e.ProgressPercentage;
        }

        private void _wc_JoinMeDownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            JoinMeDownloadProgresBar.Value = e.ProgressPercentage;
        }

        private void InstalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) return;
            if (button.Name == InstallMumbleButton.Name)
                InstallApp(_manage.App[AppToInstall.Mumble], button);
            else if (button.Name == InstallJoinMeButton.Name)
                InstallApp(_manage.App[AppToInstall.JoinMe], button);
        }

        private void RunJoinMeApp_OnClick(object sender, RoutedEventArgs e)
        {
            _manage.RunApplication(_manage.App[AppToInstall.JoinMe]);
            JoinMeDownloadCompleted.Visibility = Visibility.Hidden;
            JoinMeDownloadProgresBar.Visibility = Visibility.Hidden;
        }

        private void RunMumbleApp_OnClick(object sender, RoutedEventArgs e)
        {
            _manage.RunApplication(_manage.App[AppToInstall.Mumble]);
            MumbleDownloadCompleted.Visibility = Visibility.Hidden;
            MumbleInstallProgresBar.Visibility = Visibility.Hidden;
        }

        private void DropBoxButton_OnClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (button.Content.ToString().Contains(@"DropBox - Początkujący"))
                {
                    new Browser(TociBeginer).Show();
                }
                else if (button.Content.ToString().Contains(@"DropBox - Średnio zawansowane"))
                    new Browser(Tociintermediate).Show();
            }
        }

        private void AddMumbleConfig_OnClick(object sender, RoutedEventArgs e)
        {
            _manage.SetMumbleConf(MumbleNickTextBox.Text);
        }

        private void TociApp_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (_manage.AppIsIntaled(_manage.App[AppToInstall.JoinMe]))
            {
                InstallJoinMeButton.IsEnabled = false;
                RunJoinMeApp.IsEnabled = true;
            }
            if (_manage.AppIsIntaled(_manage.App[AppToInstall.Mumble]))
            {
                InstallMumbleButton.IsEnabled = false;
                RunMumbleApp.IsEnabled = true;
            }
        }

        private void ChromiumWebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            WebBrowserChromium.BrowserSettings.WebSecurity = CefState.Enabled;
            WebBrowserChromium.Address =
                "https://m.facebook.com/ttooccii/?locale2=pl_PL&__nodl&refsrc=http%3A%2F%2Fwww.google.pl%2F&ref=external%3Awww.google.pl&_rdr";
        }
    }
}
