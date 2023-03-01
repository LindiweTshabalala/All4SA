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

        public static DatabaseActionsResponses InsertEntry(ImageReference newEntry)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO imageReferences (imageReference) VALUES (@imageReference)", DatabaseConnection.GetConnection()))
                {   
                    cmd.Parameters.AddWithValue("imageReference", newEntry.imageReference);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
        }

        public static new List<ImageReference> GetAll()
        {
            return new List<ImageReference>();
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
