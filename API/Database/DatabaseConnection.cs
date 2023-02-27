using Npgsql;

namespace All4SA.Database
{
    public class DatabaseConnection
    {
        private static string ConnectionString= "Server=localhost;Port=5432;User Id=postgres;Password=F1234;Database=All4SA";
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
