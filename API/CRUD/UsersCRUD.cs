using All4SA.Database;
using All4SA.Models;
using Npgsql;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class UsersCRUD : DatabaseActionsBridge
    {
        public static new User GetByID(int ID)
        {
            return new User();
        }

        public static new List<User> GetAll()
        {
            List<User> userList = new List<User>();
            User user = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Users", DatabaseConnection.GetConnection()))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User
                            {
                                userID = reader.GetInt32(0),
                                firstName = reader.GetString(1),
                                Surname = reader.GetString(2),
                                idNumber = reader.GetString(3),
                                token = reader.GetString(4),
                            };
                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userList;
        }

        public static DatabaseActionsResponses InsertEntry(User newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(User updateEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static new DatabaseActionsResponses DeleteEntryByID(int ID)
        {
            return DatabaseActionsResponses.Failed;
        }
        public static new DatabaseActionsResponses DeleteAll()
        {
            return DatabaseActionsResponses.Failed;
        }
        public static new DatabaseActionsResponses SoftDeleteEntryByID(int ID)
        {
            return DatabaseActionsResponses.Failed;
        }
    }
}
