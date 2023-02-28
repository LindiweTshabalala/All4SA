using All4SA.Database;
using All4SA.Models;
using Npgsql;
using System;
using System.Net;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class JobRequestsCRUD : DatabaseActionsBridge
    { 
        public static new JobRequest GetByID(int id)
        {

            try
            {
                string query = $"SELECT * FROM JobRequests WHERE JobRequestID = @id";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
                cmd.Parameters.AddWithValue("id", id);

                using NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return new JobRequest
                    {
                        JobRequestID = reader.GetInt32(0),
                        JobRequestDescription = reader.GetString(1),
                        UserID = reader.GetInt32(2),
                        ImageReferenceID = reader.GetInt32(3),
                        JobTypeID = reader.GetInt32(4),
                        EstimatedCost = reader.GetDecimal(5),
                        Status = reader.GetBoolean(6)
                    };
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"ERROR - Could not get JobRequest with ID '{id}'");
            }

            return null;
        }


        public static new List<JobRequest> GetAll()
        {
            List<JobRequest> requests = new List<JobRequest>();

            string query = "SELECT * FROM JobRequests";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new JobRequest
                {
                    JobRequestID = reader.GetInt32(0),
                    JobRequestDescription = reader.GetString(1),
                    UserID = reader.GetInt32(2),
                    ImageReferenceID = reader.GetInt32(3),
                    JobTypeID = reader.GetInt32(4),
                    EstimatedCost = reader.GetDecimal(5),
                    Status = reader.GetBoolean(6)

            });
            }
            requests.Add(new JobRequest());
            return requests;
        }



        public static DatabaseActionsResponses InsertEntry(JobRequest newEntry)
        {
            JobRequest user = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO JobRequests (JobRequestDescription, UserID, ImageReferenceID, JobTypeID, EstimatedCost) VALUES (@JobRequestDescription, @UserID, @ImageReferenceID, @JobTypeID, @EstimatedCost)", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("JobRequestDescription", newEntry.JobRequestDescription);
                    cmd.Parameters.AddWithValue("UserID", newEntry.UserID);
                    cmd.Parameters.AddWithValue("ImageReferenceID", newEntry.ImageReferenceID);
                    cmd.Parameters.AddWithValue("JobTypeID", newEntry.JobTypeID);
                    cmd.Parameters.AddWithValue("EstimatedCost", newEntry.EstimatedCost);

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



        public static DatabaseActionsResponses UpdateEntryByID(JobRequest updateEntry)
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
