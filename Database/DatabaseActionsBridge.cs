using static ProjectManagement.Database.DatabaseActions;

namespace ProjectManagement.Database
{
    public abstract class DatabaseActionsBridge : DatabaseActions
    {
        protected static readonly string currentDirectory = Directory.GetCurrentDirectory();

        public static object GetByID(int ID) => new();
        public static object GetAll() => new();
        public static DatabaseActionsResponses InsertEntry(object newEntry) => DatabaseActionsResponses.Failed;

        public static DatabaseActionsResponses UpdateEntryByID(int ID, object updateEntry) => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses DeleteEntryByID(int ID) => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses DeleteAll() => DatabaseActionsResponses.Failed;
        public static DatabaseActionsResponses SoftDeleteEntryByID(int ID) => DatabaseActionsResponses.Failed;
    }
}
