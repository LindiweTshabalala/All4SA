using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;
using Npgsql;

namespace All4SA.CRUD
{
    public class ImagesReferencesCRUD : DatabaseActionsBridge
    {
        public static new ImageReference GetByID(int ID)
        {
            return new ImageReference();
        }

        public static new ImageReference GetByLink(string link)
        {
            Console.WriteLine(link);
            ImageReference linkOjbect = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM imageReferences WHERE imageReference = @link", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("link", link.Replace("%2F", "/"));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            linkOjbect = new ImageReference
                            {
                                imageReferenceID = reader.GetInt32(0),
                                imageReference = reader.GetString(1)
                            };
                            Console.WriteLine(linkOjbect.imageReferenceID);
                            Console.WriteLine(linkOjbect.imageReference);
                            Console.WriteLine("1");


                            return linkOjbect;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return linkOjbect;
        }


        public static new List<ImageReference> GetAll()
        {
            return new List<ImageReference>();
        }

        public static DatabaseActionsResponses InsertEntry(ImageReference newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(ImageReference updateEntry)
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
