using All4SA.Database;
using All4SA.Models;
using Npgsql;
using System;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class UserJobApplicationsCRUD : DatabaseActionsBridge
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



        public static DatabaseActionsResponses UpdateEntryByID_upvote(PublicVote updateEntry)
        {
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "UPDATE publicvotes SET upvotes = (upvotes + 1) WHERE UserID = @UserID and JobRequestID = @JobRequestID",
                    DatabaseConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("UserID", updateEntry.UserID);
                    command.Parameters.AddWithValue("JobRequestID", updateEntry.JobRequestID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
        }



        public static DatabaseActionsResponses UpdateEntryByID_downvote(PublicVote updateEntry)
        {
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "UPDATE publicvotes SET downvotes = (downvotes + 1) WHERE PublicVoteID = PublicVoteID",
                    DatabaseConnection.GetConnection()))
                {

                    command.Parameters.AddWithValue("publicvoteid", updateEntry.PublicVoteID);
                    command.Parameters.AddWithValue("downvotes", updateEntry.Downvotes);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return DatabaseActionsResponses.Failed;
            }
            return DatabaseActionsResponses.Success;
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
