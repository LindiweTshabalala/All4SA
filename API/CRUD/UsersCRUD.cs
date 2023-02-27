using All4SA.Database;
using All4SA.Models;
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
            return new List<User>();
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
