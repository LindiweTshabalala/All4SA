using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class ImagesReferencesCRUD : DatabaseActionsBridge
    {
        public static new ImageReference GetByID(int ID)
        {
            return new ImageReference();
        }

        public static new List<ImageReference> GetAll()
        {
            return new List<ImageReference>();
        }

        public static DatabaseActionsResponses InsertEntry(ImageReference newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(int ID, ImageReference updateEntry)
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
