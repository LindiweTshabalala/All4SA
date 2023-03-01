using All4SA.Models;
using All4SA.Database;
using static All4SA.Database.DatabaseActions;
using Npgsql;

namespace All4SA.CRUD
{
    public class JobRequestDetailsCRUD : DatabaseActionsBridge
    {
        public static new JobRequestDetails GetByID(int jobRequestID)
        {
            JobRequestDetails jobRequestDetails = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM vwJobRequestDetails WHERE jobRequestID = @jobRequestID", DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("jobRequestID", jobRequestID);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jobRequestDetails = new JobRequestDetails
                            {
                                firstName = reader.GetString(0),
                                jobRequestID = reader.GetInt32(1),
                                jobRequestDescription= reader.GetString(2),
                                jobType= reader.GetString(3),
                                estimatedCost = reader.GetDecimal(4),
                                imageReference = reader.GetString(5),                               
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jobRequestDetails;
        }

        public static new List<JobRequestDetails> GetAll()
        {
            List<JobRequestDetails> details = new List<JobRequestDetails>();

            string query = "SELECT * FROM vwJobRequestDetails";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                details.Add(new JobRequestDetails
                {
                    firstName= reader.GetString(0),
                    jobRequestID = reader.GetInt32(1),
                    jobRequestDescription= reader.GetString(2),
                    jobType = reader.GetString(3),
                    estimatedCost = reader.GetDecimal(4),
                    imageReference = reader.GetString(5)

                });
            }
            return details;
        }

        public static DatabaseActionsResponses InsertEntry(ApprovedJobRequest newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(ApprovedJobRequest updateEntry)
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
