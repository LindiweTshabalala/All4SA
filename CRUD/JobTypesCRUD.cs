using All4SA.Database;
using All4SA.Models;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class JobTypesCRUD : DatabaseActionsBridge
    {
        public static new JobType GetByID(int ID)
        {
            return new JobType();
        }

        public static new List<JobType> GetAll()
        {
            return new List<JobType>();
        }

        public static DatabaseActionsResponses InsertEntry(JobType newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(JobType updateEntry)
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
