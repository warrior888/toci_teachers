namespace TociApp.Interface
{
    public interface IAppToInstall
    {
        string DownloadDirectory { get; set; }
        string AppName { get; }
        string FileName { get; }
        string FileDwnlName { get; }
        string InstalledAppPath { get; set; }
        bool IsDownloaded { get; set; }
    }
}