using System;
using System.IO;
using System.Net;

namespace Downloader
{
    class DownloadFile
    {
        public event System.ComponentModel.AsyncCompletedEventHandler complate;
        public event DownloadProgressChangedEventHandler progress;

        public void DwnloadFile(string path, string fileName)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += complate;
                wc.DownloadProgressChanged += progress;
                wc.DownloadFileAsync(new Uri("http://vps458649.ovh.net/" + fileName), Path.Combine(path + "\\" + fileName));
            }
        }
    }
}
