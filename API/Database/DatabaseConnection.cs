using All4SA.Config;
using Npgsql;

namespace All4SA.Database
{
    public class DatabaseConnection
    {
        private static string ConnectionString= Configuration.SetConfiguration();
        private static NpgsqlConnection? connection;

        private static NpgsqlConnection? Connection
        {
            get { return connection; }
        }

        public static NpgsqlConnection GetConnection()
        {
            connection ??= new NpgsqlConnection();
            return connection;
        }

        public static void OpenConnection()
        {
            Console.WriteLine(ConnectionString);
            connection = new NpgsqlConnection(ConnectionString);
            connection.Open();
        }

        public static void DisposeConnection()
        {
            connection?.Close();
        }
    }
}
