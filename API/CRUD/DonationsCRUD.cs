using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class DonationsCRUD : DatabaseActionsBridge
    {
        public static new Donation GetByID(int ID)
        {
            return new Donation();
        }

        public static new List<Donation> GetAll()
        {
            return new List<Donation>();
        }

        public static DatabaseActionsResponses InsertEntry(Donation newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(Donation updateEntry)
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
