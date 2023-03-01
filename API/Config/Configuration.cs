using System.Text.Json;

namespace All4SA.Config
{
    internal class Configuration
    {
        private static readonly string dbConfig = @".\.dbConfig.json";
        public string? Host { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? DatabaseName { get; set; }

        public static string SetConfiguration()
        {
            try
            {
                string text = File.ReadAllText(dbConfig);
                var configuration = JsonSerializer.Deserialize<Configuration>(text);
                string connectionString = $"Host={configuration?.Host};Username={configuration?.Username};Password={configuration?.Password};Database={configuration?.DatabaseName};";

                return connectionString;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
