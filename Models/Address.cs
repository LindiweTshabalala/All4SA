using ProjectManagement.Database;
using static ProjectManagement.Database.DatabaseActions;

namespace All4SA.Models
{
    public class Address : DatabaseActionsBridge
    {
        public static new Address GetByID(int ID)
        {
            return new Address();
        }

        public static new List<Address> GetAll()
        {
            return new List<Address>();
        }

        public static DatabaseActionsResponses InsertEntry(Address newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(int ID, Address updateEntry)
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
