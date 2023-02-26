using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class ApprovedJobsImagesCRUD : DatabaseActionsBridge
    {
        public static new ApprovedJobsImage GetByID(int ID)
        {
            return new ApprovedJobsImage();
        }

        public static new List<ApprovedJobsImage> GetAll()
        {
            return new List<ApprovedJobsImage>();
        }

        public static DatabaseActionsResponses InsertEntry(ApprovedJobsImage newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(ApprovedJobsImage updateEntry)
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
