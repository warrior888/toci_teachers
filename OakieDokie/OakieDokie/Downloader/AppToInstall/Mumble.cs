using OakieDokie.dab;

namespace Downloader.AppToInstall
{
    public class Mumble : IAppToInstall
    {
        public string DownloadDirectory { get; set; }
        public string FileName => "mumble.exe";
        public string FileDwnlName => "mumble-1.2.19.msi";
    }
}