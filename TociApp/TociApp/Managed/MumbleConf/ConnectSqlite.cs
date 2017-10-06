using System;
using System.Data.SQLite;

namespace TociApp.Managed.MumbleConf
{
    public static class ConnectSqlite
    {
        private static readonly SQLiteConnection Connect = new SQLiteConnection(@"Data Source=%APPDATA%\Mumble\mumble.sqlite");

        public static void AddServerToMumble(string userNameInServer)
        {
            Connect.Open();

            if (String.IsNullOrEmpty(userNameInServer))
                userNameInServer = "User";
            
            string sqlSelect = $"insert into servers (name, hostname, port, username, password) values ('Toci', '46.41.128.92', 64738, '{userNameInServer}', 'tociteachers')";

            SQLiteCommand command = new SQLiteCommand(sqlSelect, Connect);

            command.ExecuteNonQuery();
        }
    }
}