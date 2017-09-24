using System;
using System.Net;

namespace Downloader
{
    public class Manage
    {
        public string DownloadDirectory { get; set; }
        public event System.ComponentModel.AsyncCompletedEventHandler ComplateDownload;
        public event DownloadProgressChangedEventHandler Progress;

        private readonly DownloadFile _downloadFile;

        public Manage()
        {
            _downloadFile = new DownloadFile();
        }

        public bool DownloadFile(string path, IAppToInstall app)
        {
            if (!String.IsNullOrEmpty(path))
            {
                DownloadDirectory = path;
                app.DownloadDirectory = path;

                _downloadFile.progress += Progress;
                _downloadFile.complate += ComplateDownload;
                _downloadFile.DwnloadFile(path, app.FileDwnlName);

                return true;
            }
            return false;
        }

        public void AppInstall(IAppToInstall app)
        {
            InstallApp.Install(app);
        }
    }
}