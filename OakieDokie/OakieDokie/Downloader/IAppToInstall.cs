namespace Downloader
{
    public interface IAppToInstall
    {
        string DownloadDirectory { get; set; }
        string FileName { get; }
        string FileDwnlName { get; }
    }
}