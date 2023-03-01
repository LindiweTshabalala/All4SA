using All4SA.Database;
using All4SA.Models;
using Npgsql;

namespace All4SA.CRUD
{
    public class JobsApprovedDetailsCRUD : DatabaseActionsBridge
    {


        public static new List<JobsApprovedDetails> GetAll()
        {
            List<JobsApprovedDetails> details = new List<JobsApprovedDetails>();

            string query = "SELECT * FROM vwApprovedJobDetails";

            using NpgsqlCommand command = new NpgsqlCommand(query, DatabaseConnection.GetConnection());
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                details.Add(new JobsApprovedDetails
                {
                    approvedjobid = reader.GetInt32(0),
                    jobrequestdescription = reader.GetString(1),
                    jobtypename = reader.GetString(2),
                    statusname = reader.GetString(3)
                   

                });
            }
            return details;
        }




    }
}
