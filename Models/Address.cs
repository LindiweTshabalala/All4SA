using ProjectManagement.Database;
using static ProjectManagement.Database.DatabaseActions;

namespace All4SA.Models
{
    public class Address : DatabaseActionsBridge
    {
        public static Address GetByID(int ID)
        {
            return 
        };
        public static object GetAll() => new();
        public static DatabaseActionsResponses InsertEntry(object newEntry) => DatabaseActionsResponses.Failed;

        public static DatabaseActionsResponses UpdateEntryByID(int ID, object updateEntry) => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses DeleteEntryByID(int ID) => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses DeleteAll() => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses SoftDeleteEntryByID(int ID) => DatabaseActionsResponses.Failed;
    }
}
