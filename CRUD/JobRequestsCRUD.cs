using All4SA.Database;
using All4SA.Models;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class JobRequestsCRUD : DatabaseActionsBridge
    { 
        public static new JobRequest GetByID(int ID)
        {
            return new JobRequest();
        }

        public static new List<JobRequest> GetAll()
        {
            return new List<JobRequest>();
        }

        public static DatabaseActionsResponses InsertEntry(JobRequest newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(int ID, JobRequest updateEntry)
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
