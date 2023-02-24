using Npgsql;

namespace ProjectManagement.Database
{
    public class DatabaseConnection
    {
        private static string ConnectionString;
        private static NpgsqlConnection connection;

        private static NpgsqlConnection Connection
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
            connection = new NpgsqlConnection(ConnectionString);
            connection.Open();
        }

        public static void DisposeConnection()
        {
            connection.Close();
        }
    }
}
