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
            List<PublicVote> publicVotesView = new List<PublicVote>();

            string query = "SELECT * FROM vwpublicvotes WHERE publicvoteid = @id";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("id", ID);

            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new PublicVote
                {
                    PublicVoteID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2),
                    JobRequestID = reader.GetInt32(3),
                    Upvotes = reader.GetInt32(4),
                    Downvotes = reader.GetInt32(5)

                };
            }
            return new PublicVote();
        }

        public static PublicVote GetByJobRequestID(int ID)
        {
            List<PublicVote> publicVotesView = new List<PublicVote>();

            string query = "SELECT * FROM vwpublicvotes WHERE jobrequestid = @id";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("id", ID);

            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new PublicVote
                {
                    PublicVoteID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2),
                    JobRequestID = reader.GetInt32(3),
                    Upvotes = reader.GetInt32(4),
                    Downvotes = reader.GetInt32(5)

                };
            }
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
