using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using TociApp.Interface;

namespace TociApp.Managed
{
    public class DownloadFile
    {
        public event AsyncCompletedEventHandler Complate;
        public event DownloadProgressChangedEventHandler Progress;

        public void DwnloadFile(string path, IAppToInstall app)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += (sender, e) =>
                {       // TODO: Czy to dobra praktyka ;-) ?
                    Complate?.Invoke(app, e);
                };
                wc.DownloadProgressChanged += Progress;
                wc.DownloadFileTaskAsync(new Uri("http://vps458649.ovh.net/" + app.FileDwnlName), Path.Combine(path + "\\" + app.FileDwnlName));
            }
        }
    }
}
