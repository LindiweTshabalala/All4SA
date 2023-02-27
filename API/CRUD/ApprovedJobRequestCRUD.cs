using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class ApprovedJobRequestCRUD : DatabaseActionsBridge
    {
        public static new ApprovedJobRequest GetByID(int ID)
        {
            return new ApprovedJobRequest();
        }

        public static new List<ApprovedJobRequest> GetAll()
        {
            return new List<ApprovedJobRequest>();
        }

        public static DatabaseActionsResponses InsertEntry(ApprovedJobRequest newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(ApprovedJobRequest updateEntry)
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
