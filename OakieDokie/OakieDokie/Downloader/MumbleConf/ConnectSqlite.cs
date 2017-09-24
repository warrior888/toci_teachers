using System.Data.SQLite;

namespace Downloader.MumbleConf
{
    public class ConnectSqlite
    {
        private readonly SQLiteConnection _connect;

        public ConnectSqlite(string userName)
        {
            _connect = new SQLiteConnection($@"Data Source=C:\Users\{userName}\AppData\Roaming\Mumble\mumble.sqlite");
        }

        public void AddServerToMumble(string userNameInServer)
        {
            // TODO: Dodac zabezpieczenie w pzrypadku błędnej nazwy użytkownika
            _connect.Open();
            string sqlSelect = $"insert into servers (name, hostname, port, username, password) values ('Toci', '46.41.128.92', 64738, '{userNameInServer}', 'tociteachers')";

            SQLiteCommand command = new SQLiteCommand(sqlSelect, _connect);

            command.ExecuteNonQuery();
        }
    }
}