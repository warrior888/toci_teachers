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
        private Dictionary<AppToInstall, IAppToInstall> App { get; }
        private string _appConfigPath;

        public Manage()
        {
            App = new Dictionary<AppToInstall, IAppToInstall>
            {
                [AppToInstall.JoinMe] = new JoinMe(),
                [AppToInstall.Mumble] = new Mumble()
            };
            CreateConfigDirectory();
        }

        /// <summary>
        /// Check that the application is installed on the host.
        /// </summary>
        /// <param name="app">Enumeration type <see cref="TociApp.Managed.AppToInstall"/> representing applications.</param>
        /// <returns>Return true if application is installed, otherwise false.</returns>
        public bool AppIsIntaled(AppToInstall app)
        {
            return InstallApp.IsAppInstalled(App[app]);
        }

        /// <summary>
        /// Gets the file and assign methods to events.
        /// </summary>
        /// <param name="path">Specifies the absolute path where the file will be saved</param>
        /// <param name="app">Enumeration type <see cref="TociApp.Managed.AppToInstall"/> representing applications</param>
        /// <param name="completedDownload">Represents the method that will handle the MethodName<see langword="Completed" /> event of an asynchronous operation.</param>
        /// <param name="progress">Represents the method that will handle the <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> event of a <see cref="T:System.Net.WebClient" /></param>
        /// <exception cref="System.IO.DirectoryNotFoundException">The specified path was not found.</exception>
        public void DownloadFile(string path, AppToInstall app,
            AsyncCompletedEventHandler completedDownload = null, DownloadProgressChangedEventHandler progress = null)
        {
            if (String.IsNullOrEmpty(path) && !Directory.Exists(path))
            {
                throw new DirectoryNotFoundException("Directory not found or not exist");
            }
            DownloadFile downloadFile = new DownloadFile();

            App[app].DownloadDirectory = path;

            downloadFile.Progress += progress;
            downloadFile.Complate += completedDownload;
            downloadFile.DwnloadFile(path, App[app]);
        }

        public bool AppInstall(AppToInstall app)
        {
            try
            {
                return InstallApp.Install(App[app]);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                throw new FileNotFoundException();
            }
        }

        public void RunApplication(AppToInstall app)
        {
            InstallApp.RunApp(App[app]);
        }

        public void SetMumbleConf(string userName)
        {
            ConnectSqlite.AddServerToMumble(userName);
        }

        #region Serializacja
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
        #endregion

        private void CreateConfigDirectory()
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