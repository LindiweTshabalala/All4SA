using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class ContactsCRUD : DatabaseActionsBridge
    {
        public static new Contact GetByID(int ID)
        {
            return new Contact();
        }

        public static new List<Contact> GetAll()
        {
            return new List<Contact>();
        }

        public static DatabaseActionsResponses InsertEntry(Contact newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(int ID, Contact updateEntry)
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
