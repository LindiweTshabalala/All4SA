using All4SA.Database;
using All4SA.Models;
using Npgsql;
using static All4SA.Database.DatabaseActions;

namespace All4SA.CRUD
{
    public class JobTypesCRUD : DatabaseActionsBridge
    {
        public static new JobType GetByID(int ID)
        {
            return new JobType();
        }

        public static new List<JobType> GetAll()
        {
            List<JobType> jobLIst = new List<JobType>();
            JobType jobType = new();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM JobTypes", DatabaseConnection.GetConnection()))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jobType = new JobType
                            {
                                jobTypeID = reader.GetInt32(0),
                                jobTypeName = reader.GetString(1),
                                hourlyRate = reader.GetDecimal(2),
                            };
                            jobLIst.Add(jobType);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jobLIst; ;
        }

        public static DatabaseActionsResponses InsertEntry(JobType newEntry)
        {
            return DatabaseActionsResponses.Failed;
        }

        public static DatabaseActionsResponses UpdateEntryByID(JobType updateEntry)
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
