using System.Collections;
using Npgsql;

namespace ConsoleApp1
{
    public class NpSQL
    {
        protected NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Example;User Id=postgres;Password = programmer3rs; ");

        public Hashtable[] Select(string query)
        {

            return null;
        }

        public int insert(string query)
        {
            connection.Open();
            NpgsqlCommand command= new NpgsqlCommand(query);
            command.Connection = connection;
            command.ExecuteNonQuery();



            connection.Close();
            return 1;
        }

    }
}