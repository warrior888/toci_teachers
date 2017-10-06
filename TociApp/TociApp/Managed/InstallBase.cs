using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TociApp.Interface;

namespace TociApp.Managed
{
    public static class InstallApp
    {
        // Warning: Klucz rejestru przechowuje wszyskie binarki, jednak po odinstalowaniu nie zawsze są z niego usuwane wpisy.
        private const string RegistryPath =
            @"S-1-5-21-110281386-2591742775-2335758308-1001\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store";

        public static bool Install(IAppToInstall app)       //TODO: Dokonać zmian, aby metoda zwracała  enuma InstalledStatus
        {
            try
            {
                string path = app.DownloadDirectory + "\\" + app.FileDwnlName;

                //var pinfo = new ProcessStartInfo(path, "/qn");

                using (var process = Process.Start(path))
                {
                    if (process == null) return false;
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {
                        IsAppInstalled(app);
                        return true;
                    }
                }
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                Console.WriteLine(e);
                throw new FileNotFoundException();
            }
            return false;
        }

        /// <summary>
        /// Checks whether the application is installed in system.
        /// </summary>
        /// <param name="app">Class implemented IAppToInstall</param>
        /// <returns>If is installed return true otherwise return false.</returns>
        public static bool IsAppInstalled(IAppToInstall app)
        {
            var path = SearchRegistry(app.AppName).ToArray();
            if (path?.Any() != true) return false;

            app.InstalledAppPath = path.First();
            return true;

            #region Check windows registry

            /*var machineKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall") ??
                             Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            var userKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            bool found = false;

            if (machineKey == null && userKey == null)
                return false;

            if (machineKey != null)
            {
                found = machineKey.GetSubKeyNames()
                    .Select(keyName => machineKey.OpenSubKey(keyName))
                    .Select(subkey => subkey.GetValue("DisplayName") as string)
                    .Any(displayName => displayName != null && displayName.Contains(softwareName));
            }

            if (userKey != null && found != true)
            {
                found = userKey.GetSubKeyNames()
                    .Select(keyName => userKey.OpenSubKey(keyName))
                    .Select(subkey => subkey.GetValue("DisplayName") as string)
                    .Any(displayName => displayName != null && displayName.Contains(softwareName));
            }

            return found;*/

            #endregion
        }

        public static void RunApp(IAppToInstall app)
        {
            Process.Start(app.InstalledAppPath);
        }

        #region Check windows registry
        private static string[] SearchRegistry(string appName)
        {
            var usersKey = Registry.Users.OpenSubKey(RegistryPath);

            var path = usersKey?.GetValueNames()
                .Select(app => app)
                .Where(value => value.Contains(appName + ".exe"));
            return path?.ToArray();
        }
        #endregion
    }
}