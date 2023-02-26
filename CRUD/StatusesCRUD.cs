using All4SA.Database;
using All4SA.Models;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class StatusesCRUD : DatabaseActionsBridge
    {
        public static new Status GetByID(int ID)
        {
            return new Status();
        }

        public static new List<Status> GetAll()
        {
            return new List<Status>();
        }

        public static DatabaseActionsResponses InsertEntry(Status newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(Status updateEntry)
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
