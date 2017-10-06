using System;
using TociApp.Interface;

namespace TociApp.Models
{
    [Serializable]
    public class Mumble : IAppToInstall
    {
        public string DownloadDirectory { get; set; }
        public string AppName => "mumble";
        public string FileName => "mumble-1.2.19.msi";
        public string FileDwnlName => "mumble.toci.msi";
        public string InstalledAppPath { get; set; }
        public bool IsDownloaded { get; set; }
    }
}