using All4SA.Database;
using All4SA.Models;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class PublicVotesCRUD : DatabaseActionsBridge
    {
        public static new PublicVote GetByID(int ID)
        {
            return new PublicVote();
        }

        public static new List<PublicVote> GetAll()
        {
            return new List<PublicVote>();
        }

        public static DatabaseActionsResponses InsertEntry(PublicVote newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(PublicVote updateEntry)
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
