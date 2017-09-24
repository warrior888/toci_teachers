using System;
using System.Diagnostics;
using System.IO;

namespace Downloader
{
    public static class InstallApp
    {
        public static void Install(IAppToInstall app)
        {
            try
            {
                string path = app.DownloadDirectory + "\\" + app.FileDwnlName;
                Process.Start(path);
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                Console.WriteLine(e);
                throw new FileNotFoundException();
            }
        }
    }
}