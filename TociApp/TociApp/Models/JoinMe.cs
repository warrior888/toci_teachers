using System;
using TociApp.Interface;

namespace TociApp.Models
{
    [Serializable]
    public class JoinMe : IAppToInstall
    {
        public string DownloadDirectory { get; set; }
        public string AppName => "join.me";
        public string FileName => "join.me.msi";
        public string FileDwnlName => "join.me.toci.msi";
        public string InstalledAppPath { get; set; }
        public bool IsDownloaded { get; set; }
    }
}