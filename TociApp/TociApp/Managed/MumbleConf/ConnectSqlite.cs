using System;
using System.Data.SQLite;
using System.Windows.Shapes;

namespace TociApp.Managed.MumbleConf
{
    public static class ConnectSqlite
    {
        private static readonly string ConnectionString =
            Environment.GetEnvironmentVariable("APPDATA") + "\\Mumble\\mumble.sqlite";

        private static readonly SQLiteConnection Connect = new SQLiteConnection($"Data Source={ConnectionString}");

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