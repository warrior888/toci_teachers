using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using TociApp.Interface;
using TociApp.Managed;
using TociApp.Managed.MumbleConf;
using TociApp.Models;

namespace TociApp.ViewModels
{
    public class Manage
    {
        public string DownloadDirectory { get; set; }
        public Dictionary<AppToInstall, IAppToInstall> App { get; }

        private string _appConfigPath;

        public Manage()
        {
            App = new Dictionary<AppToInstall, IAppToInstall>
            {
                [AppToInstall.JoinMe] = new JoinMe(),
                [AppToInstall.Mumble] = new Mumble()
            };
            CreateDirectory();
        }

        /// <summary>
        /// Check that the application is installed on the host.
        /// </summary>
        /// <param name="app">Class implemented IAppToInstall</param>
        /// <returns>Return true if application is installed.</returns>
        public bool AppIsIntaled(IAppToInstall app)
        {
            return InstallApp.IsAppInstalled(app);
        }

        public void DownloadFile(string path, IAppToInstall app, 
            AsyncCompletedEventHandler completedDownload = null, DownloadProgressChangedEventHandler progress = null)
        {
            if (!String.IsNullOrEmpty(path))
            {
                DownloadFile downloadFile = new DownloadFile();

                DownloadDirectory = path;
                app.DownloadDirectory = path;

                downloadFile.Progress += progress;
                downloadFile.Complate += completedDownload;
                downloadFile.DwnloadFile(path, app);
            }
        }

        public bool AppInstall(IAppToInstall app)
        {
            try
            {
                return InstallApp.Install(app);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                throw new FileNotFoundException();
            }
        }

        public void RunApplication(IAppToInstall app)
        {
            InstallApp.RunApp(app);
        }

        public void SetMumbleConf(string userName)
        {
            ConnectSqlite.AddServerToMumble(userName);
        }

        public void SerializeModels(IAppToInstall app)
        {
            using (var write = File.OpenWrite(_appConfigPath + $"\\{app.AppName}.bin"))  // ANOTHER_POSSIBILITY: Pobierać dane z serwera - nazwe pliku instalacyjnego  
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(write, app);

            }
        }

        public void LoadAppSettings(IAppToInstall app)
        {
            try
            {
                using (var input = File.OpenRead(_appConfigPath + $"\\{app.AppName}.bin"))
                {
                    var formatter = new BinaryFormatter();

                    var appTemp = (IAppToInstall)formatter.Deserialize(input);

                    app.InstalledAppPath = appTemp.InstalledAppPath;
                    app.DownloadDirectory = appTemp.DownloadDirectory;
                    app.IsDownloaded = appTemp.IsDownloaded;

                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void CreateDirectory()
        {
            if (Directory.Exists(Environment.SpecialFolder.LocalApplicationData + "\\TociApp"))
            {
                _appConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TociApp";
            }
            var path = Directory.CreateDirectory(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TociApp");
            _appConfigPath = path.FullName;
        }
    }
}