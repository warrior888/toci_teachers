using OakieDokie.dab;

namespace Downloader.AppToInstall
{
    public class JoinMe : IAppToInstall
    {
        public string DownloadDirectory { get; set; }
        public string FileName => "join.me.msi";
        public string FileDwnlName => "join.me.toci.msi";
    }
}