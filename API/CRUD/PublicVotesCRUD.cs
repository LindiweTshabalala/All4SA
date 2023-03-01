using All4SA.Database;
using All4SA.Models;
using Npgsql;
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
            List<PublicVote> publicVotesView = new List<PublicVote>();

            string query = "SELECT * FROM vwpublicvotes";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                publicVotesView.Add(new PublicVote
                {
                    PublicVoteID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2),
                    JobRequestID = reader.GetInt32(3),
                    Upvotes = reader.GetInt32(4),
                    Downvotes = reader.GetInt32(5)

                });
            }
            return publicVotesView;
        }

        public static DatabaseActionsResponses InsertEntry(PublicVote newEntry)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO PublicVotes (UserID, JobRequestID, UpVotes, DownVotes) VALUES (@UserID, @JobRequestID, @UpVotes, @DownVotes)", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("UserID", newEntry.UserID);
                    cmd.Parameters.AddWithValue("JobRequestID", newEntry.JobRequestID);
                    cmd.Parameters.AddWithValue("UpVotes", newEntry.Upvotes);
                    cmd.Parameters.AddWithValue("DownVotes", newEntry.Downvotes);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("rowsAffected: "+ rowsAffected);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
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
